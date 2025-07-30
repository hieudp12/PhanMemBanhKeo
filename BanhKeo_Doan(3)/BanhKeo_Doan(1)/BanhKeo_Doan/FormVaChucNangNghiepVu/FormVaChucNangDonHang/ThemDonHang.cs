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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang
{
    public partial class ThemDonHang : Form
    {
        public ThemDonHang()
        {
            InitializeComponent();
        }

        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet15.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet15.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet14.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet14.KhachHang);

        }

        private void cmbBoxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public event EventHandler DaThemDonHang;

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDonHang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraMaDonHang(txtMaDonHang.Text))
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ. Vui lòng nhập theo định dạng: DHxxxx-xxx");
                txtMaDonHang.Focus();
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM DonHang WHERE MaDonHang = @MaDonHang";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@MaDonHang", txtMaDonHang.Text);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                string insertQuery = "INSERT INTO DonHang (MaDonHang, NgayLap, NgayGiao, LaDonDatTruoc, MaKhachHang, MaNhanVien, TongTien, GhiChu) " +
                   "VALUES (@MaDonHang, @NgayLap, @NgayGiao, @LaDonDatTruoc, @MaKhachHang, @MaNhanVien, @TongTien, @GhiChu)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaDonHang", txtMaDonHang.Text);
                cmd.Parameters.AddWithValue("@NgayLap", dateTimeNgayLap.Value);
                if (dateNgayGiao.Enabled)
                {
                    cmd.Parameters.AddWithValue("@NgayGiao", dateNgayGiao.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayGiao", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@LaDonDatTruoc", cbLaDonDatTruoc.Checked);
                cmd.Parameters.AddWithValue("@MaKhachHang", cmbBoxKhachHang.SelectedValue);
                cmd.Parameters.AddWithValue("@MaNhanVien", cmbBoxNhanVien.SelectedValue);
                cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                DaThemDonHang?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã đơn hàng đã tồn tại! Vui lòng nhập mã khác.");
            }
            conn.Close();
            
        }

        private void cbLaDonDatTruoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLaDonDatTruoc.Checked)
            {
                dateNgayGiao.Enabled = true;
            }
            else
            {
                dateNgayGiao.Enabled = false;
            }
        }

        private bool KiemTraMaDonHang(string ma)
        {
            return Regex.IsMatch(ma, @"^DH\d{4}-\d{3}$");
        }
    }
}
