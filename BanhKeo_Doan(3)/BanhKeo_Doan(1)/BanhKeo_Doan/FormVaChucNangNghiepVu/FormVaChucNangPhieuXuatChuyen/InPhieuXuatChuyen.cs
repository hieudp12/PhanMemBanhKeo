using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap;
using Microsoft.Reporting.WinForms;
using static BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap.InPhieuNhap;
using System.Data.SqlClient;
using System.IO;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    public partial class InPhieuXuatChuyen : Form
    {
        private string MaPhieuXuatChuyen;
        public InPhieuXuatChuyen(string maPhieuXuatChuyen)
        {
            InitializeComponent();
            MaPhieuXuatChuyen = maPhieuXuatChuyen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không","Xác nhận thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void InPhieuXuatChuyen_Load(object sender, EventArgs e)
        {
            rprPhieuXuatChuyen.Reset();
            rprPhieuXuatChuyen.ProcessingMode = ProcessingMode.Local;
            rprPhieuXuatChuyen.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatChuyen\ReportPhieuXuatChuyen.rdlc";



            ReportDataSource rds = new ReportDataSource("DataSet1", GetData());
            rprPhieuXuatChuyen.LocalReport.DataSources.Clear();
            rprPhieuXuatChuyen.LocalReport.DataSources.Add(rds);




            thongTinXuatChuyen ncc = getThongTinXuatChuyen();

            ReportParameter[] parameters = new ReportParameter[]
            {
             new ReportParameter("NhanVien", ncc.NhanVien),
               new ReportParameter("NgayXuat", ncc.NgayXuat.ToString("dd/MM/yyyy")),
               new ReportParameter("MaPhieuXuatChuyen",MaPhieuXuatChuyen),
             };

            rprPhieuXuatChuyen.LocalReport.SetParameters(parameters);


            rprPhieuXuatChuyen.RefreshReport();
        }
        private DataTable GetData()
        {
            string sql = @"SELECT * FROM ViewPhieuXuatChuyen WHERE MaPhieuXuatChuyen = @MaPhieuXuatChuyen";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", MaPhieuXuatChuyen);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public class thongTinXuatChuyen
        {
            public string NhanVien { get; set; }
           
            public DateTime NgayXuat { get; set; }


        }

        private thongTinXuatChuyen getThongTinXuatChuyen()
        {
            string sql = @"
                SELECT NhanVien.TenNhanVien, PhieuXuatChuyen.NgayXuatChuyen
                FROM PhieuXuatChuyen
                INNER JOIN NhanVien ON PhieuXuatChuyen.MaNhanVien = NhanVien.MaNhanVien
                WHERE PhieuXuatChuyen.MaPhieuXuatChuyen = @MaPhieuXuatChuyen";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", MaPhieuXuatChuyen);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                thongTinXuatChuyen info = new thongTinXuatChuyen();
                if (reader.Read())
                {
                    info.NhanVien = reader["TenNhanVien"].ToString();
                    
                    info.NgayXuat = Convert.ToDateTime(reader["NgayXuatChuyen"]);


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
                saveFileDialog.FileName = "InXuatChuyen_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuXuatChuyen\ReportPhieuXuatChuyen.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataSet1", GetData());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);

                        var info = getThongTinXuatChuyen();
                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            new ReportParameter("MaPhieuXuatChuyen",MaPhieuXuatChuyen),
                            new ReportParameter("NgayXuat", info?.NgayXuat.ToString("dd/MM/yyyy") ?? ""),
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
