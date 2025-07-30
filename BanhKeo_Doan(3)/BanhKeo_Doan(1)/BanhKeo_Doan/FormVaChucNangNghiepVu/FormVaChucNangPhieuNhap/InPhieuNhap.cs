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
using DevExpress.Utils.About;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap
{
    public partial class InPhieuNhap : Form
    {
        private string MaPhieuNhap;
        public InPhieuNhap(string maPhieuNhap)
        {
            InitializeComponent();
            MaPhieuNhap = maPhieuNhap;
        }

        private void InPhieuNhap_Load(object sender, EventArgs e)
        {
            
            rprPhieuNhap.Reset();
            rprPhieuNhap.ProcessingMode = ProcessingMode.Local;
            rprPhieuNhap.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuNhap\ReportPhieuNhap.rdlc";
           

            
            ReportDataSource rds = new ReportDataSource("DataSet1", GetData());
            rprPhieuNhap.LocalReport.DataSources.Clear();
            rprPhieuNhap.LocalReport.DataSources.Add(rds);

            


            ThongTinNCC ncc = GetThongTinNCC();
            
            ReportParameter[] parameters = new ReportParameter[]
            {
             new ReportParameter("TenNhaCungCap", ncc.TenNhaCungCap),
             new ReportParameter("DiaChiNhaCungCap", ncc.DiaChiNhaCungCap),
               new ReportParameter("NgayNhapHang", ncc.NgayNhapHang.ToString("dd/MM/yyyy")),
               new ReportParameter("MaPhieuNhap",MaPhieuNhap),
             };

            rprPhieuNhap.LocalReport.SetParameters(parameters);

            
            rprPhieuNhap.RefreshReport();
        }
        private DataTable GetData()
        {
            string sql = @"SELECT * FROM ViewPhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        
        public class ThongTinNCC
        {
            public string TenNhaCungCap { get; set; }
            public string DiaChiNhaCungCap { get; set; }
            public DateTime NgayNhapHang { get; set; }
            

        }

        private ThongTinNCC GetThongTinNCC()
        {
            string sql = @"
                SELECT NhaCungCap.TenNhaCungCap, NhaCungCap.DiaChi, PhieuNhap.NgayNhap
                FROM PhieuNhap
                INNER JOIN NhaCungCap ON PhieuNhap.MaNhaCungCap = NhaCungCap.MaNhaCungCap
                WHERE PhieuNhap.MaPhieuNhap = @MaPhieuNhap";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ThongTinNCC info = new ThongTinNCC();
                if (reader.Read())
                {
                    info.TenNhaCungCap = reader["TenNhaCungCap"].ToString();
                    info.DiaChiNhaCungCap = reader["DiaChi"].ToString();
                    info.NgayNhapHang = Convert.ToDateTime(reader["NgayNhap"]);



                    conn.Close();
                    return info;
                }
            }
            return null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không","Xác nhận thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "InNhapHang_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();

                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangPhieuNhap\ReportPhieuNhap.rdlc";


                        ReportDataSource rds = new ReportDataSource("DataSet1", GetData());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);

                        var info = GetThongTinNCC();
                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            

                            new ReportParameter("TenNhaCungCap", info?.TenNhaCungCap.ToString()??""),
                            new ReportParameter("DiaChiNhaCungCap", info?.DiaChiNhaCungCap.ToString()??""),
                            new ReportParameter("NgayNhapHang", info?.NgayNhapHang.ToString("dd/MM/yyyy")??""),
                            new ReportParameter("MaPhieuNhap",MaPhieuNhap),
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

        private void rprPhieuNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
