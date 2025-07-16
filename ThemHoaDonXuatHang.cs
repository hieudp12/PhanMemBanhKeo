using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang;
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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
{
    public partial class ThemHoaDonXuatHang : Form
    {
        public ThemHoaDonXuatHang()
        {
            InitializeComponent();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler DaThemHoaDon;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHD.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhanTramCK.Text))
            {
                MessageBox.Show("Vui lòng nhập phần trăm chiết khấu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraMaHoaDon(txtMaHD.Text))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ. Vui lòng nhập theo định dạng: XHxxxx-xxx");
                txtMaHD.Focus();
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM HoaDonXuatHang WHERE MaHoaDonXuatHang = @MaHoaDonXuatHang";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@MaHoaDonXuatHang", txtMaHD.Text);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                string insertQuery = "INSERT INTO HoaDonXuatHang (MaHoaDonXuatHang, NgayXuat, MaKhachHang, TongChuaCK, PhanTramCK, ChietKhau, TongTien, MaNhanVien, GhiChu) " +
                   "VALUES (@MaHoaDonXuatHang, @NgayXuat, @MaKhachHang, @TongChuaCK, @PhanTramCK, @ChietKhau, @TongTien, @MaNhanVien, @GhiChu)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaHoaDonXuatHang", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@NgayXuat", dateNgayXuat.Value);
                cmd.Parameters.AddWithValue("@MaKhachHang", cmbBoxKH.SelectedValue);
                cmd.Parameters.AddWithValue("@TongChuaCK", txtTongChuaCK.Text);
                cmd.Parameters.AddWithValue("@PhanTramCK", txtPhanTramCK.Text);
                cmd.Parameters.AddWithValue("@ChietKhau", txtSoTienCK.Text);
                cmd.Parameters.AddWithValue("@MaNhanVien", cmbBoxNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TongTien", txtTongSauCK.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                DaThemHoaDon?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại! Vui lòng nhập mã khác.");
            }
            conn.Close();
        }

        private void ThemHoaDonXuatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet14.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet14.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet13.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet13.KhachHang);

        }

        private void txtPhanTramCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool KiemTraMaHoaDon(string ma)
        {
            return Regex.IsMatch(ma, @"^XH\d{4}-\d{3}$");
        }
    }
}
