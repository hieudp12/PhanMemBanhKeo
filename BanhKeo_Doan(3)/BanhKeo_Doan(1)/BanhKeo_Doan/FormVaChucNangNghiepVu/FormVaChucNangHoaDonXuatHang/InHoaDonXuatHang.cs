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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
{
    public partial class InHoaDonXuatHang : Form
    {
        public InHoaDonXuatHang(string maHoaDonDuocChon)
        {
            InitializeComponent();
            this.maHoaDonDuocChon = maHoaDonDuocChon;
        }
        private string maHoaDonDuocChon;

        private void InHoaDonXuatHang_Load(object sender, EventArgs e)
        {
            rpVHoaDonXuatHang.Reset();
            rpVHoaDonXuatHang.ProcessingMode = ProcessingMode.Local;
            rpVHoaDonXuatHang.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangHoaDonXuatHang\HoaDonXuatHang.rdlc";
            ReportDataSource rds = new ReportDataSource("dataSetHoaDonXuatHang", GetData());
            rpVHoaDonXuatHang.LocalReport.DataSources.Clear();
            rpVHoaDonXuatHang.LocalReport.DataSources.Add(rds);
            KhachHangInfo khach = GetThongTinKhachHang();
            HoaDonXuatInfo hoaDonXuat = GetThongTinHoaDon();
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("TenKhachHang", khach.TenKhachHang),
                 new ReportParameter("DiaChi", khach.DiaChi),
                 new ReportParameter("DienThoai", khach.DienThoai),
                 new ReportParameter("MaHoaDon", hoaDonXuat.MaHoaDon),
                 new ReportParameter("NgayXuat", hoaDonXuat.NgayXuat.ToString("dd/MM/yyyy")),
            };
            rpVHoaDonXuatHang.LocalReport.SetParameters(parameters);
            rpVHoaDonXuatHang.RefreshReport();
        }

        private DataTable GetData()
        {
            string sql = @"SELECT * FROM vHoaDonXuatHang WHERE MaHoaDonXuatHang = @MaHoaDonXuatHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHoaDonXuatHang", maHoaDonDuocChon);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public class KhachHangInfo
        {
            public string TenKhachHang { get; set; }
            public string DiaChi { get; set; }
            public string DienThoai { get; set; }
        }

        private KhachHangInfo GetThongTinKhachHang()
        {
            string sql = @"
        SELECT TenKhachHang, DiaChi, Tel
        FROM HoaDonXuatHang
        INNER JOIN KhachHang ON HoaDonXuatHang.MaKhachHang = KhachHang.MaKhachHang
        WHERE HoaDonXuatHang.MaHoaDonXuatHang = @MaHoaDonXuatHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHoaDonXuatHang", maHoaDonDuocChon);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                KhachHangInfo info = new KhachHangInfo();
                if (reader.Read())
                {
                    info.TenKhachHang = reader["TenKhachHang"].ToString();
                    info.DiaChi = reader["DiaChi"].ToString();
                    info.DienThoai = reader["Tel"].ToString();
                }
                conn.Close();
                return info;
            }
        }
        public class HoaDonXuatInfo
        {
            public string MaHoaDon { get; set; }
            public DateTime NgayXuat { get; set; }

        }
        private HoaDonXuatInfo GetThongTinHoaDon()
        {
            string sql = @"
        SELECT 
            HoaDonXuatHang.MaHoaDonXuatHang,
            HoaDonXuatHang.NgayXuat 
        FROM HoaDonXuatHang
        WHERE HoaDonXuatHang.MaHoaDonXuatHang = @MaHoaDonXuatHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaHoaDonXuatHang", maHoaDonDuocChon);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                HoaDonXuatInfo info = new HoaDonXuatInfo();
                if (reader.Read())
                {
                    info.MaHoaDon = reader["MaHoaDonXuatHang"].ToString();
                    info.NgayXuat = Convert.ToDateTime(reader["NgayXuat"]);
                }
                conn.Close();
                return info;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangHoaDonXuatHang\HoaDonXuatHang.rdlc";
            var dt = GetData();
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("dataSetHoaDonXuatHang", dt));
            KhachHangInfo khach = GetThongTinKhachHang();
            HoaDonXuatInfo hoaDonXuat = GetThongTinHoaDon();
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("TenKhachHang", khach.TenKhachHang),
                 new ReportParameter("DiaChi", khach.DiaChi),
                 new ReportParameter("DienThoai", khach.DienThoai),
                 new ReportParameter("MaHoaDon", hoaDonXuat.MaHoaDon),
                 new ReportParameter("NgayXuat", hoaDonXuat.NgayXuat.ToString("dd/MM/yyyy")),
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
                saveFileDialog.FileName = "Hóa đơn xuất hàng " + maHoaDonDuocChon + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in hóa đơn xuất hàng ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
