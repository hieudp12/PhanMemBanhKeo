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
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    public partial class ThemHangHoa : Form
    {
        private string MaPhieuXuatChuyen;
      
        public event EventHandler DaThemHangHoaXuat;
        public ThemHangHoa(string maPhieuXuatChuyen)
        {
            InitializeComponent();
            MaPhieuXuatChuyen = maPhieuXuatChuyen;
        }   

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet59.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter1.Fill(this.quanLyBanBanhKeo_DoAnDataSet59.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet58.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet58.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet48.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet48.Kho);
           

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (cmbHangHoa.SelectedValue == null || cmbKhoNhap.SelectedValue == null || cmbKhoXuat.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ hàng hóa và kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmbKhoNhap.SelectedValue.ToString() == cmbKhoXuat.SelectedValue.ToString())
            {
                MessageBox.Show("Kho xuất và kho nhập không được trùng nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtSoLuongXuat.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng xuất hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                conn.Open();


                string checkQuery = @"SELECT COUNT(*) FROM ChiTietPhieuXuatChuyen 
                                       WHERE MaPhieuXuatChuyen = @MaPhieuXuatChuyen 
                                       AND MaHangHoa = @MaHangHoa 
                                       AND MaKhoXuat = @MaKhoXuat 
                                       AND MaKhoNhap = @MaKhoNhap";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", MaPhieuXuatChuyen);
                    checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa.SelectedValue);
                    checkCmd.Parameters.AddWithValue("@MaKhoXuat", cmbKhoXuat.SelectedValue);
                    checkCmd.Parameters.AddWithValue("@MaKhoNhap", cmbKhoNhap.SelectedValue);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Hàng hóa này đã tồn tại trong phiếu xuất chuyển!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string maHangHoa = (string)cmbHangHoa.SelectedValue;
                int maKho = (int)cmbKhoXuat.SelectedValue;
                float tonKho = LaySoLuongTonKho(maHangHoa, maKho);
                if (soLuong > tonKho)
                {
                    MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string insertQuery = @"
                     INSERT INTO ChiTietPhieuXuatChuyen 
                     (MaPhieuXuatChuyen, MaKhoXuat, MaKhoNhap, MaHangHoa, SoLuongXuat, GhiChu)
                     VALUES 
                     (@MaPhieuXuatChuyen, @MaKhoXuat, @MaKhoNhap, @MaHangHoa, @SoLuongXuat, @GhiChu)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", MaPhieuXuatChuyen);
                    cmd.Parameters.AddWithValue("@MaKhoXuat", cmbKhoXuat.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaKhoNhap", cmbKhoNhap.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa.SelectedValue);
                    cmd.Parameters.AddWithValue("@SoLuongXuat", soLuong);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGC.Text ?? "");

                    cmd.ExecuteNonQuery();
                }
            }

            DaThemHangHoaXuat?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Thêm hàng xuất chuyển thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cmbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbHangHoa.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                

                string donViTinh = LayDonViTinh(maHang);
                txtDonViTinh.Text = donViTinh;
            }
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
