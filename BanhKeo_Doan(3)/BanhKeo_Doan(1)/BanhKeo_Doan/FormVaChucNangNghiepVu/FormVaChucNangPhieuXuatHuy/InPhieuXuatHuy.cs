using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using System.IO;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy
{
    public partial class InPhieuXuatHuy : Form
    {
        private string MaPhieuXuatHuy;
        public InPhieuXuatHuy(string maPhieuXuatHuy)
        {
            InitializeComponent();
            MaPhieuXuatHuy = maPhieuXuatHuy; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void InPhieuXuatHuy_Load(object sender, EventArgs e)
        {
            rprPhieuXuatHuy.Reset();
            rprPhieuXuatHuy.ProcessingMode = ProcessingMode.Local;
            rprPhieuXuatHuy.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatHuy\ReportPhieuXuatHuy.rdlc";



            ReportDataSource rds = new ReportDataSource("DataHuy", GetData());
            rprPhieuXuatHuy.LocalReport.DataSources.Clear();
            rprPhieuXuatHuy.LocalReport.DataSources.Add(rds);




            thongTinXuatHuy ncc = getthongTinXuatHuy();

            ReportParameter[] parameters = new ReportParameter[]
            {
             new ReportParameter("NhanVien", ncc.NhanVien),
               new ReportParameter("NgayHuy", ncc.NgayHuy.ToString("dd/MM/yyyy")),
               new ReportParameter("MaPhieuXuatHuy",MaPhieuXuatHuy),
             };

            rprPhieuXuatHuy.LocalReport.SetParameters(parameters);


            rprPhieuXuatHuy.RefreshReport();
        }
        private DataTable GetData()
        {
            string sql = @"SELECT * FROM ViewPhieuHuy WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatHuy", MaPhieuXuatHuy);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public class thongTinXuatHuy
        {
            public string NhanVien { get; set; }

            public DateTime NgayHuy { get; set; }


        }

        private thongTinXuatHuy getthongTinXuatHuy()
        {
            string sql = @"
                SELECT NhanVien.TenNhanVien, PhieuXuatHuy.NgayXuatHuy
                FROM PhieuXuatHuy
                INNER JOIN NhanVien ON PhieuXuatHuy.MaNhanVien = NhanVien.MaNhanVien
                WHERE PhieuXuatHuy.MaPhieuXuatHuy = @MaPhieuXuatHuy";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatHuy", MaPhieuXuatHuy);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                thongTinXuatHuy info = new thongTinXuatHuy();
                if (reader.Read())
                {
                    info.NhanVien = reader["TenNhanVien"].ToString();

                    info.NgayHuy = Convert.ToDateTime(reader["NgayXuatHuy"]);


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
                saveFileDialog.FileName = "InXuatHuy_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatHuy\ReportPhieuXuatHuy.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataHuy", GetData());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);

                        var info = getthongTinXuatHuy();
                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            new ReportParameter("MaPhieuXuatHuy",MaPhieuXuatHuy),
                            new ReportParameter("NgayHuy", info?.NgayHuy.ToString("dd/MM/yyyy") ?? ""),
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

