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

namespace BanhKeo_Doan.BaoCaoThongKe
{
    public partial class HangDoiTra : Form
    {
        public HangDoiTra()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rpHangDoiTra.Reset();
            rpHangDoiTra.ProcessingMode = ProcessingMode.Local;
            rpHangDoiTra.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\HangDoiTra\HangDoiTra.rdlc";
            ReportDataSource rds = new ReportDataSource("dataHangDoiTra", GetData());
            rpHangDoiTra.LocalReport.DataSources.Clear();
            rpHangDoiTra.LocalReport.DataSources.Add(rds);
            DateTime ngayBD = dateNgayBD.Value.Date;
            DateTime ngayKT = dateNgayKT.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("NgayBD", ngayBD.ToString("yyyy-MM-dd")),
                 new ReportParameter("NgayKT", ngayKT.ToString("yyyy-MM-dd")),
            };
            rpHangDoiTra.LocalReport.SetParameters(parameters);
            try
            {
                rpHangDoiTra.RefreshReport();
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
            string sql = @"SELECT * FROM vHangDoiTra Where NgayChungTu between @NgayBD and @NgayKT";
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@NgayBD", dateNgayBD.Value.Date);
                cmd.Parameters.AddWithValue("@NgayKT", dateNgayKT.Value.Date);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void HangDoiTra_Load(object sender, EventArgs e)
        {

            
        }

        private void btnInHangDoiTra_Click(object sender, EventArgs e)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\HangDoiTra\HangDoiTra.rdlc";           
            ReportDataSource rds = new ReportDataSource("dataHangDoiTra", GetData());
            report.DataSources.Clear();
            report.DataSources.Add(rds);
            DateTime ngayBD = dateNgayBD.Value.Date;
            DateTime ngayKT = dateNgayKT.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("NgayBD", ngayBD.ToString("yyyy-MM-dd")),
                 new ReportParameter("NgayKT", ngayKT.ToString("yyyy-MM-dd")),
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
                saveFileDialog.FileName = "Báo cáo hàng đổi trả từ ngày " + ngayBD.ToString("yyyy-MM-dd") + " đến ngày " + ngayKT.ToString("yyyy-MM-dd") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in báo cáo hàng đổi trả ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
