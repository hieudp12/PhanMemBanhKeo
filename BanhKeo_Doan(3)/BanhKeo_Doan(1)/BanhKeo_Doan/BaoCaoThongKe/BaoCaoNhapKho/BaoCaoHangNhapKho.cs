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
    public partial class BaoCaoHangNhapKho : Form
    {
        public BaoCaoHangNhapKho()
        {
            InitializeComponent();
        }

        private void BaoCaoHangNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet78.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet78.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet77.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet77.NhaCungCap);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet76.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet76.LoaiHang);
            this.rprNhapHang.RefreshReport();
            
        }
        private DataTable LayDuLieu()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM ViewBaoCaoNhapHang WHERE NgayNhap >= @TuNgay AND NgayNhap < @DenNgay");

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand())
            {
                DateTime tungay = dtmTuNgay.Value.Date;
                DateTime denngay = dtmDenNgay.Value.Date.AddDays(1);
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TuNgay", tungay);
                cmd.Parameters.AddWithValue("@DenNgay", denngay);

                if (ckbMatHang.Checked && cmbMatHang.SelectedValue != null)
                {
                    sql.Append(" AND TenHangHoa = @TenHangHoa");
                    cmd.Parameters.AddWithValue("@TenHangHoa", cmbMatHang.SelectedValue.ToString());
                }

                if (ckbLoaiHang.Checked && cmbLoaiHang.SelectedValue != null)
                {
                    sql.Append(" AND TenLoaiHang = @TenLoaiHang");
                    cmd.Parameters.AddWithValue("@TenLoaiHang", cmbLoaiHang.SelectedValue.ToString());
                }

                if (ckbNCC.Checked && cmbNhaCungCap.SelectedValue != null)
                {
                    sql.Append(" AND TenNhaCungCap = @TenNhaCungCap");
                    cmd.Parameters.AddWithValue("@TenNhaCungCap", cmbNhaCungCap.SelectedValue.ToString());
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
            rprNhapHang.Reset();
            rprNhapHang.ProcessingMode = ProcessingMode.Local;
            rprNhapHang.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoNhapKho\InBaoCaoHangNhapKho.rdlc";

            ReportDataSource rds = new ReportDataSource("DataNhapHang", LayDuLieu());
            rprNhapHang.LocalReport.DataSources.Clear();
            rprNhapHang.LocalReport.DataSources.Add(rds);

            DateTime tungay = dtmTuNgay.Value.Date;
            DateTime denngay = dtmDenNgay.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("TuNgay", tungay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", denngay.ToString("dd/MM/yyyy"))
            };
            rprNhapHang.LocalReport.SetParameters(parameters);

            try
            {
                rprNhapHang.RefreshReport();
            }
            catch (LocalProcessingException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                if (ex.InnerException != null)
                    MessageBox.Show("Chi tiết: " + ex.InnerException.Message);
            }
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
                saveFileDialog.FileName = "BaoCaoNhapHang_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();
                       
                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoNhapKho\InBaoCaoHangNhapKho.rdlc";

                    
                        ReportDataSource rds = new ReportDataSource("DataNhapHang", LayDuLieu());
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
