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
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    public partial class SuaHangHoa : Form
    {
        private string ID;
        public event EventHandler DaSuaHangHoaSanXuat;
        public SuaHangHoa(string IdDuocChonSX)
        {
            InitializeComponent();
            ID = IdDuocChonSX;
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet95.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet95.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet54.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet54.Kho);
            LoadThongTinChiTietSanXuat();
        }
        
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (cmbTenHang1.SelectedValue == null || cmbKho1.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ hàng hóa và kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtSoLuong1.Text, out float soLuong) || soLuong <= 0 ||
                !float.TryParse(txtGia1.Text, out float donGia) || donGia < 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng và đơn giá hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtThanhTien1.Text, out float thanhTien))
            {
                MessageBox.Show("Thành tiền không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                conn.Open();
                string checkQuery = @"
                    SELECT COUNT(*) FROM ChiTietPhieuXuatRaSX
                    WHERE ID <> @ID
                    AND MaPhieuXuatSX = (SELECT MaPhieuXuatSX FROM ChiTietPhieuXuatRaSX WHERE ID = @ID)
                    AND MaHangHoa = @MaHangHoa 
                    AND MaKho = @MaKho
                    ";

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@ID", ID);
                    checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbTenHang1.SelectedValue);
                    checkCmd.Parameters.AddWithValue("@MaKho", cmbKho1.SelectedValue);
                   
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Đã trùng với dòng đã có!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string maHangHoa = (string)cmbTenHang1.SelectedValue;
                int maKho = (int)cmbKho1.SelectedValue;
                float soLuongCu = LaySoLuongCu();
                float tonKho = LaySoLuongTonKho(maHangHoa, maKho);

                if (soLuong > tonKho + soLuongCu)
                {
                    MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = @"
                    UPDATE ChiTietPhieuXuatRaSX   
                    SET  
                        MaHangHoa = @MaHangHoa, 
                        SoLuong = @SoLuong, 
                        DonGia = @DonGia, 
                        ThanhTien = @ThanhTien, 
                        MaKho = @MaKho, 
                        GhiChu = @GhiChu
                    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@MaHangHoa", cmbTenHang1.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                cmd.Parameters.AddWithValue("@MaKho", cmbKho1.SelectedValue);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu1.Text ?? "");

                cmd.ExecuteNonQuery();
            }

            DaSuaHangHoaSanXuat?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Sửa hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void TinhToanTuDong()
        {
            if (float.TryParse(txtSoLuong1.Text, out float soLuong) && float.TryParse(txtGia1.Text, out float donGia) )
            {
                
                float thanhTien = soLuong * donGia;

                
                txtThanhTien1.Text = thanhTien.ToString("N0");
            }
            else
            {

                
                txtThanhTien1.Text = "";
            }
        }
        private void LoadThongTinChiTietSanXuat()
        {
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
                    SELECT sx.MaHangHoa, dvt.TenDVT, sx.SoLuong, sx.DonGia, sx.ThanhTien, sx.MaKho, sx.GhiChu
                    FROM ChiTietPhieuXuatRaSX sx
                    JOIN HangHoa hh ON sx.MaHangHoa = hh.MaHangHoa
                    JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbTenHang1.SelectedValue = reader["MaHangHoa"].ToString();
                        txtDonViTinh1.Text = reader["TenDVT"]?.ToString() ?? "";
                        cmbKho1.SelectedValue = reader["MaKho"].ToString();
                        txtSoLuong1.Text = Convert.ToDouble(reader["SoLuong"]).ToString("0.##");
                        txtGia1.Text = Convert.ToDecimal(reader["DonGia"]).ToString("0.##");
                        txtThanhTien1.Text = Convert.ToDecimal(reader["ThanhTien"]).ToString("0.##");
                        txtGhiChu1.Text = reader["GhiChu"]?.ToString() ?? "";
                    }
                }
            }
            TinhToanTuDong();
        }

        private void txtSoLuong1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void txtGia1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void cmbTenHang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbTenHang1.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                float donGia = LayGiaNhap(maHang);
                txtGia1.Text = donGia.ToString("N0");

                string donViTinh = LayDonViTinh(maHang);
                txtDonViTinh1.Text = donViTinh;
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
        private float LaySoLuongCu()
        {
            float soLuongCu = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT SoLuong FROM ChiTietPhieuXuatRaSX WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    soLuongCu = Convert.ToSingle(result);
                }
            }
            return soLuongCu;
        }
        private void Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
