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
using static BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang.InHoaDonXuatHang;

namespace BanhKeo_Doan.BaoCaoThongKe.DoanhSoBanHang
{
    public partial class BaoCaoDoanhSoBanHang : Form
    {
        public BaoCaoDoanhSoBanHang()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhSoBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet34.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet34.KhachHang);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet33.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet33.HangHoa);

            this.rpDoanhSoBanHang.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rpDoanhSoBanHang.Reset();
            rpDoanhSoBanHang.ProcessingMode = ProcessingMode.Local;
            rpDoanhSoBanHang.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\DoanhSoBanHang\DoanhSoBanHang.rdlc";
            if(cbHangHoa.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData1());
                rpDoanhSoBanHang.LocalReport.DataSources.Clear();
                rpDoanhSoBanHang.LocalReport.DataSources.Add(rds);
            }
            if(cbKhachHang.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData2());
                rpDoanhSoBanHang.LocalReport.DataSources.Clear();
                rpDoanhSoBanHang.LocalReport.DataSources.Add(rds);
            }
            if(cbKhachHang.Checked ==false && cbHangHoa.Checked ==false)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData());
                rpDoanhSoBanHang.LocalReport.DataSources.Clear();
                rpDoanhSoBanHang.LocalReport.DataSources.Add(rds);
            }               
            DateTime ngayBD = dateNgayBD.Value.Date;
            DateTime ngayKT = dateNgayKT.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
                 new ReportParameter("NgayBD", ngayBD.ToString("yyyy-MM-dd")),
                 new ReportParameter("NgayKT", ngayKT.ToString("yyyy-MM-dd")),
            };
            rpDoanhSoBanHang.LocalReport.SetParameters(parameters);
            try
            {
                rpDoanhSoBanHang.RefreshReport();
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
            string sql = @"SELECT * FROM vDoanhSoBanHang Where NgayXuat between @NgayBD and @NgayKT";

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
            string sql = @"SELECT * FROM vDoanhSoBanHang Where TenHangHoa = @tenHangHoa";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tenHangHoa", cmbBoxHangHoa.SelectedValue);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private DataTable GetData2()
        {
            string sql = @"SELECT * FROM vDoanhSoBanHang Where TenKhachHang = @tenKhachHang";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@tenKhachHang", cmbBoxKH.SelectedValue);
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

        private void btnInDoanhSo_Click(object sender, EventArgs e)
        {
            LocalReport report = new LocalReport();
            report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\DoanhSoBanHang\DoanhSoBanHang.rdlc";
            if (cbHangHoa.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData1());
                report.DataSources.Clear();
                report.DataSources.Add(rds);
            }
            if (cbKhachHang.Checked)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData2());
                report.DataSources.Clear();
                report.DataSources.Add(rds);
            }
            if (cbKhachHang.Checked == false && cbHangHoa.Checked == false)
            {
                ReportDataSource rds = new ReportDataSource("dataDoanhSoBanHang", GetData());
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
                saveFileDialog.FileName = "Báo cáo doanh số bán hàng từ ngày " + ngayBD.ToString("yyyy-MM-dd") + " đến ngày " + ngayKT.ToString("yyyy-MM-dd") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show("Đã in báo cáo doanh số bán hàng ra file PDF:\n" + savePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }         
        }
    }
}
