using BanhKeo_Doan.Chuc_nang_danh_muc;
using DevExpress.Utils.Zip.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangDonHang
{
    public partial class ThemHangHoa : Form
    {
        public ThemHangHoa(string MaDonHangDuocChon)
        {
            InitializeComponent();
            this.MaDonHang = MaDonHangDuocChon;
        }

        private KetNoiCSDL ketnoiCSDL = new KetNoiCSDL();
        private string MaDonHang;
        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadCmbBoxHH();
        }
        public event EventHandler DaThemHangHoa;

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDGchuaCK.Text))
            {
                MessageBox.Show("Vui lòng đơn giá trước chiết khấu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhanTramCK.Text))
            {
                MessageBox.Show("Vui lòng phần trăm chiết khấu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM ChiTietDonHang WHERE ChiTietDonHang.MaHangHoa = @MaHangHoa and MaDonHang = @MaDonHang";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
            checkCmd.Parameters.AddWithValue("@MaDonHang", MaDonHang);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                string maHangHoa = (string)cmbBoxHangHoa.SelectedValue;
                int maKho = (int)cmbBoxKho.SelectedValue;
                float soluong = float.Parse(txtSoLuong.Text);
                float DGtruocCK = float.Parse(txtDGchuaCK.Text);
                float PhanTramCK = float.Parse(txtPhanTramCK.Text) / 100;
                float DGsauCK = DGtruocCK * (1 - PhanTramCK);
                float SoTienCK = DGtruocCK - DGsauCK;
                txtDGsauCK.Text = DGsauCK.ToString();
                txtSoTienCK.Text = SoTienCK.ToString();
                txtThanhTien.Text = (soluong * DGsauCK).ToString();
                float tonKho = LaySoLuongTonKho(maHangHoa, maKho);
                if (soluong > tonKho)
                {
                    MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string insertQuery = "INSERT INTO ChiTietDonHang (MaDonHang, MaHangHoa, SoLuong, DonGiaTruocCK, PhanTramCK, SoTienChietKhau, DonGiaSauCK, ThanhTien, MaKho, GhiChu) " +
                   "VALUES (@MaDonHang, @MaHangHoa, @SoLuong, @DonGiaTruocCK, @PhanTramCK, @SoTienChietKhau, @DonGiaSauCK, @ThanhTien, @MaKho, @GhiChu)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaDonHang", MaDonHang);
                cmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@DonGiaTruocCK", txtDGchuaCK.Text);
                cmd.Parameters.AddWithValue("@PhanTramCK", txtPhanTramCK.Text);
                cmd.Parameters.AddWithValue("@SoTienChietKhau", txtSoTienCK.Text);
                cmd.Parameters.AddWithValue("@DonGiaSauCK", txtDGsauCK.Text);
                cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
                cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                DaThemHangHoa?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hàng hóa đã tồn tại! Vui lòng chọn hàng hóa khác.");
            }
            conn.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void txtDGchuaCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPhanTramCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void cmbBoxHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbBoxHangHoa.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {
                if (checkBanBuon.Checked)
                {
                    float donGia = LayGiaBuon(maHang);
                    txtDGchuaCK.Text = donGia.ToString("N0");
                }
                else
                {
                    float donGia = LayGiaBanLe(maHang);
                    txtDGchuaCK.Text = donGia.ToString("N0");
                }
            }
        }
        private float LayGiaBanLe(string maHang)
        {
            float donGia = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT GiaBanLe FROM BangGia WHERE MaHangHoa = @MaHangHoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && float.TryParse(result.ToString(), out float temp))
                {
                    donGia = temp;
                }
            }
            return donGia;
        }

        private float LayGiaBuon(string maHang)
        {
            float donGia = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT GiaBuon FROM BangGia WHERE MaHangHoa = @MaHangHoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && float.TryParse(result.ToString(), out float temp))
                {
                    donGia = temp;
                }
            }
            return donGia;
        }

        private float LaySoLuongTonKho(string maHangHoa, int maKho)
        {
            float soLuongTon = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT SoLuong FROM HangHoaTrongKho WHERE MaHangHoa = @MaHangHoa AND MaKho = @MaKho";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);
                    cmd.Parameters.AddWithValue("@MaKho", maKho);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        soLuongTon = Convert.ToSingle(result);
                    }
                }
            }
            return soLuongTon;
        }

        public void LoadCmbBoxHH()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query = @"SELECT HangHoa.MaHangHoa, HangHoa.TenHangHoa
                 FROM HangHoa
                 JOIN LoaiHang ON HangHoa.MaLoaiHang = LoaiHang.MaLoaiHang
                 JOIN NganhHang ON LoaiHang.MaNganhHang = NganhHang.MaNganhHang
                 WHERE NganhHang.MaNganhHang = 1";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBoxHangHoa.DataSource = dt;
            cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            cmbBoxHangHoa.ValueMember = "MaHangHoa";
            conn.Close();
        }
    }
}
