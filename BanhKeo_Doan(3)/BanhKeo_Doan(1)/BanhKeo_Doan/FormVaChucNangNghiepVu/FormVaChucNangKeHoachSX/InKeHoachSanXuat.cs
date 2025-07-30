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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX
{
    public partial class InKeHoachSanXuat : Form
    {
        public InKeHoachSanXuat(string maKeHoachDuocChon)
        {
            InitializeComponent();
            this.maKeHoachDuocChon = maKeHoachDuocChon;
        }
        private string maKeHoachDuocChon;
        private void InKeHoachSanXuat_Load(object sender, EventArgs e)
        {
            rpKeHoachSX.Reset();
            rpKeHoachSX.ProcessingMode = ProcessingMode.Local;
            rpKeHoachSX.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangKeHoachSX\InKeHoachSX.rdlc";
            ReportDataSource rds = new ReportDataSource("dataKeHoachSX", GetData());
            rpKeHoachSX.LocalReport.DataSources.Clear();
            rpKeHoachSX.LocalReport.DataSources.Add(rds);
            ReportParameter[] parameters = new ReportParameter[]
            {
            };
            rpKeHoachSX.LocalReport.SetParameters(parameters);
            try
            {
                rpKeHoachSX.RefreshReport();
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
            string sql = @"SELECT * FROM vKeHoachSX Where MaKeHoach = @maKeHoach";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@maKeHoach", maKeHoachDuocChon);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
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
            report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\FormVaChucNangNghiepVu\FormVaChucNangKeHoachSX\InKeHoachSX.rdlc";
            var dt = GetData();
            report.DataSources.Clear();
            report.DataSources.Add(new ReportDataSource("dataKeHoachSX", dt));
            string deviceInfo = @"<DeviceInfo><EmbedFonts>None</EmbedFonts></DeviceInfo>";
            Warning[] warnings;
            string[] streamIds;
            string mimeType, encoding, extension;
            byte[] bytes = report.Render("PDF", deviceInfo, out mimeType, out encoding, out extension, out streamIds, out warnings);
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Lưu file PDF";
                saveFileDialog.FileName = "Kế hoạch sản xuất " + maKeHoachDuocChon + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in kế hoạch sản xuất ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
