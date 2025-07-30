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
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy
{
    public partial class ThemHangHoa : Form
    {
        private string MaPhieuXuatHuy;
        
        public event EventHandler DaThemHangHoaXuatHuy;
        public ThemHangHoa(string maPhieuXuatHuy)
        {
            InitializeComponent();
            MaPhieuXuatHuy = maPhieuXuatHuy;
            
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet57.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet57.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet56.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet56.HangHoa);

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (cmbHangHoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbKho.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtSoLuong.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(txtDonGia.Text, out float donGiaTruocCK) || !float.TryParse(txtThanhTien.Text, out float giaCK) )
            {
                MessageBox.Show("Vui lòng chọn hàng hóa", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TinhToanTuDong();

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                conn.Open();


                string kiemTraTrungQuery = @"
         SELECT COUNT(*) FROM ChiTietPhieuXuatHuy
         WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy
           AND MaHangHoa = @MaHangHoa
           AND MaKho = @MaKho";
                SqlCommand kiemTraTrungCmd = new SqlCommand(kiemTraTrungQuery, conn);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaPhieuXuatHuy", MaPhieuXuatHuy);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa.SelectedValue);
                kiemTraTrungCmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);

                int soLuongTrung = (int)kiemTraTrungCmd.ExecuteScalar();
                if (soLuongTrung == 0)
                {

                    string maHangHoa = (string)cmbHangHoa.SelectedValue;
                    int maKho = (int)cmbKho.SelectedValue;
                    float soluong = float.Parse(txtSoLuong.Text);
                    float tonKho = LaySoLuongTonKho(maHangHoa, maKho);
                    if (soluong > tonKho)
                    {
                        MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string insertQuery = @"
             INSERT INTO ChiTietPhieuXuatHuy
             ( MaPhieuXuatHuy,MaHangHoa ,  SoLuong, DonGia, ThanhTien , MaKho, GhiChu )
             VALUES 
             ( @MaPhieuXuatHuy, @MaHangHoa ,  @SoLuong, @DonGia, @ThanhTien , @MaKho,@GhiChu )";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuXuatHuy", MaPhieuXuatHuy);
                        cmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa.SelectedValue);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                        cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
                        cmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);
                        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text ?? "");
                        cmd.ExecuteNonQuery();
                        DaThemHangHoaXuatHuy?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Thêm hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }

                }
                else
                {
                    MessageBox.Show("Hàng hóa này đã tồn tại với cùng kho!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
            }
        }
        private void TinhToanTuDong()
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                txtThanhTien.Text = "";
                return;
            }


            if (float.TryParse(txtSoLuong.Text, out float soLuong) && float.TryParse(txtDonGia.Text, out float donGia))
            {
                float thanhTien = soLuong * donGia;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            else
            {

                txtThanhTien.Text = "";
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void cmbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbHangHoa.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                float donGia = LayGiaNhap(maHang);
                txtDonGia.Text = donGia.ToString("N0");
                
                string donViTinh = LayDonViTinh(maHang);
                txtDVT.Text = donViTinh;
            }
        }
        private float LayGiaNhap(string maHang)
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
    }
}
