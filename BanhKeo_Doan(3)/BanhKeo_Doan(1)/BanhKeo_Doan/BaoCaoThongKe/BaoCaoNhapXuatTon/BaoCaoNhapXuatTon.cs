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
    public partial class BaoCaoNhapXuatTon : Form
    {
        public BaoCaoNhapXuatTon()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            reportNhapXuatTon.Reset();
            reportNhapXuatTon.ProcessingMode = ProcessingMode.Local;
            reportNhapXuatTon.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoNhapXuatTon\InBaoCaoNhapXuatTon.rdlc";
            ReportDataSource rds = new ReportDataSource("DataNhapXuatTon", GetData());
            reportNhapXuatTon.LocalReport.DataSources.Clear();
            reportNhapXuatTon.LocalReport.DataSources.Add(rds);
            DateTime ngayBD = dtmTuNgay.Value.Date;
            DateTime ngayKT = dtmDenNgay.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("TuNgay", ngayBD.ToString("dd/MM/yyyy")),
                 new ReportParameter("DenNgay", ngayKT.ToString("dd/MM/yyyy")),
            };
            reportNhapXuatTon.LocalReport.SetParameters(parameters);
            try
            {
                reportNhapXuatTon.RefreshReport();
            }
            catch (LocalProcessingException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                if (ex.InnerException != null)
                    MessageBox.Show("Chi tiết: " + ex.InnerException.Message);
            }
        }
        private DataTable GetData()
        {
            string sql = "sp_XuatNhapTon";
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                DateTime ngayBatDau = dtmTuNgay.Value.Date;
                DateTime ngayKetThuc = dtmDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                cmd.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);


                if (ckbMatHang.Checked && !string.IsNullOrWhiteSpace(cmbMatHang.Text))
                    cmd.Parameters.AddWithValue("@TenHangHoa", cmbMatHang.Text);
                else
                    cmd.Parameters.AddWithValue("@TenHangHoa", DBNull.Value);

                
                if (ckbLoai.Checked && !string.IsNullOrWhiteSpace(cmbLoai.Text))
                    cmd.Parameters.AddWithValue("@TenLoaiHang", cmbLoai.Text);
                else
                    cmd.Parameters.AddWithValue("@TenLoaiHang", DBNull.Value);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void BaoCaoNhapXuatTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet89.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet89.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet88.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet88.LoaiHang);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet89.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet89.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet88.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet88.LoaiHang);

            this.reportNhapXuatTon.RefreshReport();
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
                saveFileDialog.FileName = "BaoCaoNhapXuatTon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoNhapXuatTon\InBaoCaoNhapXuatTon.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataNhapXuatTon", GetData());
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
