using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang
{
    public partial class InBaoGiaDonHang : Form
    {
        public InBaoGiaDonHang(string maDonHangDuocChon)
        {
            InitializeComponent();
            this.maDonHangDuocChon = maDonHangDuocChon;
        }

        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();
        private string maDonHangDuocChon;

        private void InBaoGiaDonHang_Load(object sender, EventArgs e)
        {
            rpVBaoGiaDonHang.Reset();
            rpVBaoGiaDonHang.ProcessingMode = ProcessingMode.Local;
            rpVBaoGiaDonHang.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangDonHang\BaoGiaDonHang.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", GetData());
            rpVBaoGiaDonHang.LocalReport.DataSources.Clear();
            rpVBaoGiaDonHang.LocalReport.DataSources.Add(rds);
            string tenKhachHang = GetTenKhachHang();
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("TenKhachHang", tenKhachHang)
            };
            rpVBaoGiaDonHang.LocalReport.SetParameters(parameters);
            rpVBaoGiaDonHang.RefreshReport();
        }

        private DataTable GetData()
        {
            string sql = @"SELECT * FROM vBaoGiaDonHang WHERE MaDonHang = @MaDonHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaDonHang", maDonHangDuocChon);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        private string GetTenKhachHang()
        {
            string sql = @" SELECT KH.TenKhachHang
                    FROM DonHang DH
                    INNER JOIN KhachHang KH ON DH.MaKhachHang = KH.MaKhachHang
                    WHERE DH.MaDonHang = @MaDonHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDonHang", maDonHangDuocChon);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    return result?.ToString() ?? "";
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangDonHang\BaoGiaDonHang.rdlc";
            var dt = GetData(); 
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("DataSet1", dt));
            string tenKhachHang = GetTenKhachHang();
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("TenKhachHang", tenKhachHang)
            };
            report.SetParameters(parameters);
            string deviceInfo = @"<DeviceInfo><EmbedFonts>None</EmbedFonts></DeviceInfo>";
            Warning[] warnings;
            string[] streamIds;
            string mimeType, encoding, extension;
            byte[] bytes = report.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Lưu file PDF";
                saveFileDialog.FileName = "Báo giá đơn hàng " + maDonHangDuocChon + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in báo giá đơn hàng ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
