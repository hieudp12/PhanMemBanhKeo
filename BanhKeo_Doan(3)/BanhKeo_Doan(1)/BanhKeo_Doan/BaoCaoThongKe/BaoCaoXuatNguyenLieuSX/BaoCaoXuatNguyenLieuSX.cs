using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.IO;
namespace BanhKeo_Doan.Báo_cáo_thống_kê
{
    public partial class BaoCaoXuatNguyenLieuSX : Form
    {
        public BaoCaoXuatNguyenLieuSX()
        {
            InitializeComponent();
        }

        private DataTable LayDuLieu()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM ViewBaoCaoXuatNguyenLieu WHERE NgayXuat >= @TuNgay AND NgayXuat < @DenNgay");

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand())
            {
                DateTime tungay = dtmTuNgay.Value.Date;
                DateTime denngay = dtmDenNgay.Value.Date.AddDays(1);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TuNgay", tungay);
                cmd.Parameters.AddWithValue("@DenNgay", denngay);

                if (ckbDH.Checked && cmbDH.SelectedValue != null)
                {
                    sql.Append(" AND MaDonHang = @MaDonHang");
                    cmd.Parameters.AddWithValue("@MaDonHang", cmbDH.SelectedValue.ToString());
                }

                

                if (ckbMatHang.Checked && cmbMatHang.SelectedValue != null)
                {
                    sql.Append(" AND TenHangHoa = @TenHangHoa");
                    cmd.Parameters.AddWithValue("@TenHangHoa", cmbMatHang.SelectedValue.ToString());
                }

                cmd.CommandText = sql.ToString();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            rprXuatNL.Reset();
            rprXuatNL.ProcessingMode = ProcessingMode.Local;
            rprXuatNL.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoXuatNguyenLieuSX\InBaoCaoXuatNguyenLieuSX.rdlc";

            ReportDataSource rds = new ReportDataSource("DataXuatNL", LayDuLieu());
            rprXuatNL.LocalReport.DataSources.Clear();
            rprXuatNL.LocalReport.DataSources.Add(rds);
           
            DateTime tungay = dtmTuNgay.Value.Date;
            DateTime denngay = dtmDenNgay.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("TuNgay", tungay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", denngay.ToString("dd/MM/yyyy"))
            };
            rprXuatNL.LocalReport.SetParameters(parameters);

            try
            {
                rprXuatNL.RefreshReport();
            }
            catch (LocalProcessingException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                if (ex.InnerException != null)
                    MessageBox.Show("Chi tiết: " + ex.InnerException.Message);
            }
        }

        private void BaoCaoXuatNguyenLieuSX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet72.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet72.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet71.DonHang' table. You can move, or remove it, as needed.
            this.donHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet71.DonHang);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "BaoCaoXuatNguyenLieu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoXuatNguyenLieuSX\InBaoCaoXuatNguyenLieuSX.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataXuatNL", LayDuLieu());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);


                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            new ReportParameter("TuNgay", dtmTuNgay.Value.ToString("dd/MM/yyyy")),
                            new ReportParameter("DenNgay", dtmDenNgay.Value.ToString("dd/MM/yyyy"))
                        };
                        report.SetParameters(parameters);


                        string deviceInfo = @"<DeviceInfo><EmbedFonts>None</EmbedFonts></DeviceInfo>";
                        Warning[] warnings;
                        string[] streamIds;
                        string mimeType, encoding, extension;

                        byte[] bytes = report.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);


                        File.WriteAllBytes(saveFileDialog.FileName, bytes);

                        MessageBox.Show("Đã xuất báo cáo ra file PDF:\n" + saveFileDialog.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
