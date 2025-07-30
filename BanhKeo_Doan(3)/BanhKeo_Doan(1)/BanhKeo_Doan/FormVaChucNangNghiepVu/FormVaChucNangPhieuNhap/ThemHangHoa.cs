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
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap
{
    public partial class ThemHangHoa : Form
    {
        private string MaPhieuNhap;
        
        

        public event EventHandler DaThemHangHoa;
        public ThemHangHoa(string maPhieuNhap)
        {
            InitializeComponent();
            this.MaPhieuNhap = maPhieuNhap;
            

        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {

            if (cmbTenHang.SelectedIndex == -1 || cmbTenHang.SelectedValue == null || string.IsNullOrWhiteSpace(cmbTenHang.Text))
            {
                MessageBox.Show("Bạn chưa chọn hàng hóa!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTenHang.Focus();
                return;
            }

            if (cmbKho.SelectedIndex == -1 || cmbKho.SelectedValue == null || string.IsNullOrWhiteSpace(cmbKho.Text))
            {
                MessageBox.Show("Bạn chưa chọn kho!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKho.Focus();
                return;
            }

            if (!float.TryParse(txtSoLuongNhap.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số hợp lệ và > 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongNhap.Focus();
                return;
            }

            if (!float.TryParse(txtPhanTramCK.Text, out float phanTramCK) || phanTramCK < 0 || phanTramCK > 100)
            {
                MessageBox.Show("Chiết khấu phải là số từ 0 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramCK.Focus();
                return;
            }
            if (!float.TryParse(txtGiaTruocCK.Text, out float donGiaTruocCK) || !float.TryParse(txtGiaCK.Text, out float giaCK) || !float.TryParse(txtGiaSauCK.Text, out float donGiaSauCK) || !decimal.TryParse(txtThanhTien.Text, out decimal thanhTien))
            {
                MessageBox.Show("Vui lòng chọn hàng hóa!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TinhToanTuDong();
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                conn.Open();


                string kiemTraTrungQuery = @"
                         SELECT COUNT(*) FROM ChiTietPhieuNhap
                         WHERE MaPhieuNhap = @MaPhieuNhap
                           AND MaHangHoa = @MaHangHoa
                           AND MaKho = @MaKho";
                SqlCommand kiemTraTrungCmd = new SqlCommand(kiemTraTrungQuery, conn);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaHangHoa", cmbTenHang.SelectedValue);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);

                int soLuongTrung = (int)kiemTraTrungCmd.ExecuteScalar();
                if (soLuongTrung == 0)
                {

                    string insertQuery = @"
                         INSERT INTO ChiTietPhieuNhap (
                             MaPhieuNhap, MaHangHoa, SoLuongNhap,  DonGiaChuaCK, PhanTramCK, ChietKhau, DonGiaSauCK, ThanhTien, MaKho, GhiChu)
                         VALUES (
                             @MaPhieuNhap, @MaHangHoa, @SoLuongNhap, @DonGiaChuaCK, @PhanTramCK, @ChietKhau, @DonGiaSauCK, @ThanhTien, @MaKho, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
                    cmd.Parameters.AddWithValue("@MaHangHoa", cmbTenHang.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuongNhap", soLuong);
                    cmd.Parameters.AddWithValue("@DonGiaChuaCK", donGiaTruocCK);
                    cmd.Parameters.AddWithValue("@PhanTramCK", phanTramCK);
                    cmd.Parameters.AddWithValue("@ChietKhau", giaCK);
                    cmd.Parameters.AddWithValue("@DonGiaSauCK", donGiaSauCK);
                    cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text ?? "");
                    cmd.ExecuteNonQuery();
                    DaThemHangHoa?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show("Thêm hàng nhập thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hàng hóa này đã tồn tại trong phiếu nhập với cùng kho!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
        }
        private void TinhToanTuDong()
        {
            if (float.TryParse(txtSoLuongNhap.Text, out float soLuong) && float.TryParse(txtGiaTruocCK.Text, out float donGiaTruocCK) && float.TryParse(txtPhanTramCK.Text, out float phanTramCK))
            {

                float giaCK = donGiaTruocCK * (phanTramCK / 100);
                float donGiaSauCK = donGiaTruocCK * (1 - (phanTramCK / 100));
                float thanhTien = soLuong * donGiaSauCK;

                txtGiaCK.Text = giaCK.ToString("0.##");
                txtGiaSauCK.Text = donGiaSauCK.ToString("0.##");
                txtThanhTien.Text = thanhTien.ToString("0.##");

            }
            else
            {

                txtGiaCK.Text = "";
                txtGiaSauCK.Text = "";
                txtThanhTien.Text = "";
            }
        }


        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void txtPhanTramCK_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet43.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet43.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet42.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet42.HangHoa);

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void cmbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbTenHang.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {
                
                    float donGia = LayGiaNhap(maHang);
                    txtGiaTruocCK.Text = donGia.ToString("0.##");

                    string donViTinh = LayDonViTinh(maHang);
                    txtDVT.Text = donViTinh;
            }
        }
        private float LayGiaNhap(string maHang)
        {
            float donGia = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT GiaNhap FROM BangGia WHERE MaHangHoa = @MaHangHoa";
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

        private string LayDonViTinh(string maHang)
        {
            string donViTinh = "";
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
            SELECT dvt.TenDVT 
            FROM HangHoa hh 
            JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT 
            WHERE hh.MaHangHoa = @MaHangHoa";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    donViTinh = result.ToString();
                }
            }
            return donViTinh;
        }
    }
}
