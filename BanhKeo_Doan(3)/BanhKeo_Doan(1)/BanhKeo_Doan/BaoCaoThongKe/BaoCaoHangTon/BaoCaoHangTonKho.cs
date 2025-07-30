using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;
namespace BanhKeo_Doan.Báo_cáo_thống_kê
{
    public partial class BaoCaoHangTonKho : Form
    {
        public BaoCaoHangTonKho()
        {
            InitializeComponent();
        }

        private void BaoCaoHangTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet85.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet85.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet63.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet63.LoaiHang);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet62.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet62.Kho);
            this.rprBaoCaoHangTonKho.RefreshReport();
           
        }

        private DataTable LayDuLieu()
        {
            StringBuilder sql = new StringBuilder("SELECT * FROM ViewHangTonKho WHERE NgayTon = @NgayTon");

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            using (SqlCommand cmd = new SqlCommand())
            {
                DateTime tungay = dtmNgay.Value.Date;
                
                cmd.Connection = conn;
                
                cmd.Parameters.AddWithValue("@NgayTon", tungay);

                if (ckbKho.Checked && cmbKho.SelectedValue != null)
                {
                    sql.Append(" AND TenKho = @TenKho");
                    cmd.Parameters.AddWithValue("@TenKho", cmbKho.SelectedValue.ToString());
                }

                if (ckbMatHang.Checked && cmbMatHang.SelectedValue != null)
                {
                    sql.Append(" AND TenHangHoa = @TenHangHoa");
                    cmd.Parameters.AddWithValue("@TenHangHoa", cmbMatHang.SelectedValue.ToString());
                }
                if (ckbLoai.Checked && cmbLoaiHang.SelectedValue != null)
                {
                    sql.Append(" AND TenLoaiHang = @TenLoaiHang");
                    cmd.Parameters.AddWithValue("@TenLoaiHang", cmbLoaiHang.SelectedValue.ToString());
                }
               
                cmd.CommandText = sql.ToString();

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            rprBaoCaoHangTonKho.Reset();
            rprBaoCaoHangTonKho.ProcessingMode = ProcessingMode.Local;
            rprBaoCaoHangTonKho.LocalReport.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoHangTon\InBaoCaoHangTonKho.rdlc";

            ReportDataSource rds = new ReportDataSource("DataHangTon", LayDuLieu());
            rprBaoCaoHangTonKho.LocalReport.DataSources.Clear();
            rprBaoCaoHangTonKho.LocalReport.DataSources.Add(rds);

            
            DateTime ngay = dtmNgay.Value.Date;
            ReportParameter[] parameters = new ReportParameter[]
            {
               
                new ReportParameter("NgayTon", ngay.ToString("dd/MM/yyyy"))
            };
            rprBaoCaoHangTonKho.LocalReport.SetParameters(parameters);

            try
            {
                rprBaoCaoHangTonKho.RefreshReport();
            }
            catch (LocalProcessingException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                if (ex.InnerException != null)
                    MessageBox.Show("Chi tiết: " + ex.InnerException.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Chọn nơi lưu báo cáo";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "BaoCaoTonKho_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocalReport report = new LocalReport();
                        
                        report.ReportPath = @"C:\Users\Admin\Desktop\BanhKeo_Doan(3)\BanhKeo_Doan(1)\BanhKeo_Doan\BaoCaoThongKe\BaoCaoHangTon\InBaoCaoHangTonKho.rdlc";

                        
                        ReportDataSource rds = new ReportDataSource("DataHangTon", LayDuLieu());
                        report.DataSources.Clear();
                        report.DataSources.Add(rds);

                        ReportParameter[] parameters = new ReportParameter[]
                        {
                            
                            new ReportParameter("NgayTon", dtmNgay.Value.ToString("dd/MM/yyyy"))
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
