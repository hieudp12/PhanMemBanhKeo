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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangTon
{
    public partial class ThemHangTon : Form
    {
        public ThemHangTon()
        {
            InitializeComponent();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemHangTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet39.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet39.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet38.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet38.HangHoa);
            cmbMatHang.SelectedIndexChanged += cmbMatHang_SelectedIndexChanged;
            
        }
        
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMatHang.SelectedValue == null || cmbKho.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng và kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtSoLuong.Text, out decimal soLuongMoi) || soLuongMoi <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia <= 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maHang = cmbMatHang.SelectedValue.ToString();
                string maKho = cmbKho.SelectedValue.ToString();
                DateTime ngayTon = dtmNgayTon.Value.Date;
               decimal thanhTien = soLuongMoi * donGia;

                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    conn.Open();
                    
                    string checkQuery = @"SELECT SoLuong FROM HangTonKho 
                                  WHERE MaHangHoa = @MaHangHoa AND MaKho = @MaKho AND NgayTon = @NgayTon";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                    checkCmd.Parameters.AddWithValue("@MaKho", maKho);
                    checkCmd.Parameters.AddWithValue("@NgayTon", ngayTon);

                    object result = checkCmd.ExecuteScalar();

                    if (result != null)
                    {
                        decimal soLuongCu = Convert.ToInt32(result);
                        decimal tongSoLuong = soLuongCu + soLuongMoi;
                        decimal thanhTienMoi = tongSoLuong * donGia;

                        string updateQuery = @"UPDATE HangTonKho 
                                       SET SoLuong = @TongSoLuong, 
                                           DonGia = @DonGia, 
                                           ThanhTien = @ThanhTien
                                       WHERE MaHangHoa = @MaHangHoa AND MaKho = @MaKho AND NgayTon = @NgayTon";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@TongSoLuong", tongSoLuong);
                        updateCmd.Parameters.AddWithValue("@DonGia", donGia);
                        updateCmd.Parameters.AddWithValue("@ThanhTien", thanhTienMoi);
                        updateCmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                        updateCmd.Parameters.AddWithValue("@MaKho", maKho);
                        updateCmd.Parameters.AddWithValue("@NgayTon", ngayTon);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật hàng tồn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                   {
                        string insertQuery = @"INSERT INTO HangTonKho (NgayTon, MaHangHoa, SoLuong, DonGia, ThanhTien, MaKho) 
                                       VALUES (@NgayTon, @MaHangHoa, @SoLuong, @DonGia, @ThanhTien, @MaKho)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@NgayTon", ngayTon);
                        insertCmd.Parameters.AddWithValue("@MaHangHoa", maHang);
                        insertCmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                        insertCmd.Parameters.AddWithValue("@DonGia", donGia);
                        insertCmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                        insertCmd.Parameters.AddWithValue("@MaKho", maKho);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm hàng tồn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hàng tồn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TinhThanhTien()
        {
            if (decimal.TryParse(txtSoLuong.Text, out decimal soLuong) &&
               decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;
                txtThanhTien.Text = thanhTien.ToString("N0");
            }
            else
            {
                txtThanhTien.Text = "0";
            }

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
           TinhThanhTien();
        }

       
        

        private void cmbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
         
            string maHang = cmbMatHang.SelectedValue?.ToString();
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
       

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
    }
}
