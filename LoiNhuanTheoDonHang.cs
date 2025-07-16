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

namespace BanhKeo_Doan.BaoCaoThongKe.LoiNhuanTheoDonHang
{
    public partial class LoiNhuanTheoDonHang : Form
    {
        public LoiNhuanTheoDonHang()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rpLoiNhuan.Reset();
            rpLoiNhuan.ProcessingMode = ProcessingMode.Local;
            rpLoiNhuan.LocalReport.ReportPath = @"C:\Users\Hieu\source\repos\BanhKeo_Doan\BanhKeo_Doan\BaoCaoThongKe\LoiNhuanTheoDonHang\LoiNhuanTheoDonHang.rdlc";
            if (cbDonHang.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataLoiNhuan", GetData1());
                rpLoiNhuan.LocalReport.DataSources.Clear();
                rpLoiNhuan.LocalReport.DataSources.Add(rds);
            }
            if (cbDonHang.Checked == false)
            {
                ReportDataSource rds = new ReportDataSource("dataLoiNhuan", GetData());
                rpLoiNhuan.LocalReport.DataSources.Clear();
                rpLoiNhuan.LocalReport.DataSources.Add(rds);
            }
            DateTime ngayBD = dateNgayBD.Value.Date;
            DateTime ngayKT = dateNgayKT.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("NgayBD", ngayBD.ToString("yyyy-MM-dd")),
                 new ReportParameter("NgayKT", ngayKT.ToString("yyyy-MM-dd")),
            };
            rpLoiNhuan.LocalReport.SetParameters(parameters);
            try
            {
                rpLoiNhuan.RefreshReport();
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
            string sql = @"SELECT * FROM vLoiNhuanTheoDonHang1 Where NgayLap between @NgayBD and @NgayKT";
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
        private DataTable GetData1()
        {
            string sql = @"SELECT * FROM vLoiNhuanTheoDonHang1 Where MaDonHang = @maDonHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@maDonHang", txtMaDonHang.Text);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void btnInLoiNhuan_Click(object sender, EventArgs e)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"C:\Users\Hieu\source\repos\BanhKeo_Doan\BanhKeo_Doan\BaoCaoThongKe\LoiNhuanTheoDonHang\LoiNhuanTheoDonHang.rdlc";
            if (cbDonHang.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataLoiNhuan", GetData1());
                report.DataSources.Clear();
                report.DataSources.Add(rds);
            }
            if (cbDonHang.Checked == false)
            {
                ReportDataSource rds = new ReportDataSource("dataLoiNhuan", GetData());
                report.DataSources.Clear();
                report.DataSources.Add(rds);
            }
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
                saveFileDialog.FileName = "Báo cáo lợi nhuận theo đơn hàng từ ngày " + ngayBD.ToString("yyyy-MM-dd") + " đến ngày " + ngayKT.ToString("yyyy-MM-dd") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in báo cáo lợi nhuận theo đơn hàng ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
