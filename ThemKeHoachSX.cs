using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX
{
    public partial class ThemKeHoachSX : Form
    {
        public ThemKeHoachSX()
        {
            InitializeComponent();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler DaThemKeHoachSX;
        private void btnThemKeHoach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKeHoach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã kế hoạch sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraMaKeHoach(txtMaKeHoach.Text))
            {
                MessageBox.Show("Mã kế hoạch không hợp lệ. Vui lòng nhập theo định dạng: KHxxxx-xxx");
                txtMaKeHoach.Focus();
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM KeHoachSanXuat WHERE MaKeHoach = @maKeHoachSanXuat";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@maKeHoachSanXuat", txtMaKeHoach.Text);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                string checkQuery1 = "SELECT COUNT(*) FROM DonHang WHERE MaDonHang = @MaDonHang";
                SqlCommand checkCmd1 = new SqlCommand(checkQuery1, conn);
                checkCmd1.Parameters.AddWithValue("@MaDonHang", txtMaDonHang.Text);
                int count1 = (int)checkCmd1.ExecuteScalar();
                if (count1 > 0 || string.IsNullOrWhiteSpace(txtMaDonHang.Text))
                {
                    string insertQuery = "INSERT INTO KeHoachSanXuat (MaKeHoach, NgayLap, TongTien, MaNhanVien, MaDonHang, GhiChu) " +
                   "VALUES (@MaKeHoach, @NgayLap, @TongTien, @MaNhanVien, @MaDonHang, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaKeHoach", txtMaKeHoach.Text);
                    cmd.Parameters.AddWithValue("@NgayLap", dateNgayLapKeHoach.Value);
                    cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbBoxNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaDonHang", txtMaDonHang.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    cmd.ExecuteNonQuery();
                    DaThemKeHoachSX?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Thêm kế hoạch sản xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã đơn hàng không tồn tại! Vui lòng nhập mã khác.");
                }
            }
            else
            {
                MessageBox.Show("Kế hoạch sản xuất đã tồn tại! Vui lòng nhập mã khác.");
            }
            conn.Close();
        }

        private void ThemKeHoachSX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet21.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet21.NhanVien);

        }

        private bool KiemTraMaKeHoach(string ma)
        {
            return Regex.IsMatch(ma, @"^KH\d{4}-\d{3}$");
        }
    }
}
