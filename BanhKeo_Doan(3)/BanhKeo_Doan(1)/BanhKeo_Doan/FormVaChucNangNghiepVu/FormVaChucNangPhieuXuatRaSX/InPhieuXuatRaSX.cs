using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen;
using Microsoft.Reporting.WinForms;
using static BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen.InPhieuXuatChuyen;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Text;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    public partial class InPhieuXuatRaSX : Form
    {
        private string MaPhieuSX;
        public InPhieuXuatRaSX(string maPhieuSX)
        {
            
            InitializeComponent();
            MaPhieuSX = maPhieuSX;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void InPhieuXuatRaSX_Load(object sender, EventArgs e)
        {
            rprPhieuXuatSX.Reset();
            rprPhieuXuatSX.ProcessingMode = ProcessingMode.Local;
            rprPhieuXuatSX.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatRaSX\ReportPhieuXuatRaSX.rdlc";



            ReportDataSource rds = new ReportDataSource("DataSX", GetData());
            rprPhieuXuatSX.LocalReport.DataSources.Clear();
            rprPhieuXuatSX.LocalReport.DataSources.Add(rds);




            thongTinXuatSX ncc = getThongTinXuatSX();

            ReportParameter[] parameters = new ReportParameter[]
            {
             new ReportParameter("NhanVien", ncc.NhanVien),
               new ReportParameter("NgayXuatSX", ncc.NgayXuatSX.ToString("dd/MM/yyyy")),
               new ReportParameter("MaPhieuXuatSX",MaPhieuSX),
             };

            rprPhieuXuatSX.LocalReport.SetParameters(parameters);


            rprPhieuXuatSX.RefreshReport();
        }
        private DataTable GetData()
        {
            string sql = @"SELECT * FROM ViewPhieuXuatSX WHERE MaPhieuXuatSX = @MaPhieuXuatSX";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatSX", MaPhieuSX);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public class thongTinXuatSX
        {
            public string NhanVien { get; set; }

            public DateTime NgayXuatSX { get; set; }


        }

        private thongTinXuatSX getThongTinXuatSX()
        {
            string sql = @"
                SELECT NhanVien.TenNhanVien, PhieuXuatRaSX.NgayXuat
                FROM PhieuXuatRaSX
                INNER JOIN NhanVien ON PhieuXuatRaSX.MaNhanVien = NhanVien.MaNhanVien
                WHERE PhieuXuatRaSX.MaPhieuXuatSX = @MaPhieuXuatSX";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatSX", MaPhieuSX);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                thongTinXuatSX info = new thongTinXuatSX();
                if (reader.Read())
                {
                    info.NhanVien = reader["TenNhanVien"].ToString();

                    info.NgayXuatSX = Convert.ToDateTime(reader["NgayXuat"]);


                    conn.Close();
                    return info;
                }
            }
            return null;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "InXuatNguyenLieu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatRaSX\ReportPhieuXuatRaSX.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataSX", GetData());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);

                        var info = getThongTinXuatSX();
                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            new ReportParameter("MaPhieuXuatSX",MaPhieuSX),
                            new ReportParameter("NgayXuatSX", info?.NgayXuatSX.ToString("dd/MM/yyyy") ?? ""),
                            new ReportParameter("NhanVien", info?.NhanVien.ToString() ?? ""),

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
