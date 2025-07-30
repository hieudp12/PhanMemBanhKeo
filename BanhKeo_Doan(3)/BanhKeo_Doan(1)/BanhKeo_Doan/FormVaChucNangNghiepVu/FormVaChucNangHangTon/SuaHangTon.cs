using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanhKeo_Doan.Chuc_nang_danh_muc.Danh_muc_Kho;
using System.Data.SqlClient;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangTon
{
  
    public partial class SuaHangTon : Form
    {
       
        private int idHangTon;
        public event EventHandler DaSuaHangTon;
        public SuaHangTon(int id)
        {
            InitializeComponent();
            idHangTon = id;

        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void SuaHangTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet97.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet97.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet96.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet96.HangHoa);

            LoadThongTinHangTon();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSoLuong.Text, out decimal soLuongMoi) || soLuongMoi < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal donGia = Convert.ToDecimal(txtDonGia1.Text);
            decimal thanhTien = soLuongMoi * donGia;
            string maHangHoa = cmbMatHang.SelectedValue.ToString();
            string maKho = cmbKho.SelectedValue.ToString();
            DateTime ngayTon = dtmNgayTon.Value.Date;

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                try
                {
                    conn.Open();


                    string checkQuery = @"SELECT ID, SoLuong FROM HangTonKho 
                      WHERE MaHangHoa = @MaHangHoa AND MaKho = @MaKho AND NgayTon = @NgayTon AND ID != @ID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);
                    checkCmd.Parameters.AddWithValue("@MaKho", maKho);
                    checkCmd.Parameters.AddWithValue("@NgayTon", ngayTon);
                    checkCmd.Parameters.AddWithValue("@ID", idHangTon);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            int idTrung = Convert.ToInt32(reader["ID"]);
                            decimal soLuongCu = Convert.ToInt32(reader["SoLuong"]);
                            reader.Close();

                            decimal tongSoLuong = soLuongCu + soLuongMoi;
                            decimal thanhTienMoi = tongSoLuong * donGia;


                            string updateQuery = @"UPDATE HangTonKho 
                               SET SoLuong = @TongSoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien 
                               WHERE ID = @IDTrung";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@TongSoLuong", tongSoLuong);
                            updateCmd.Parameters.AddWithValue("@DonGia", donGia);
                            updateCmd.Parameters.AddWithValue("@ThanhTien", thanhTienMoi);
                            updateCmd.Parameters.AddWithValue("@IDTrung", idTrung);
                            updateCmd.ExecuteNonQuery();


                            string deleteQuery = "DELETE FROM HangTonKho WHERE ID = @IDHienTai";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                            deleteCmd.Parameters.AddWithValue("@IDHienTai", idHangTon);
                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Đã gộp vào bản ghi trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            reader.Close();
                            string updateQuery = @"UPDATE HangTonKho 
                       SET NgayTon =@NgayTon,MaHangHoa = @MaHangHoa,SoLuong = @SoLuong, DonGia = @DonGia, ThanhTien = @ThanhTien , MaKho = @MaKho
                       WHERE ID = @ID";

                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@NgayTon", ngayTon);
                            updateCmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                            updateCmd.Parameters.AddWithValue("@DonGia", donGia);
                            updateCmd.Parameters.AddWithValue("@ThanhTien", thanhTien);
                            updateCmd.Parameters.AddWithValue("@MaHangHoa", maHangHoa);
                            updateCmd.Parameters.AddWithValue("@MaKho", maKho);
                            updateCmd.Parameters.AddWithValue("@ID", idHangTon);
                            updateCmd.ExecuteNonQuery();
                            DaSuaHangTon?.Invoke(this, EventArgs.Empty);
                           
                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void LoadThongTinHangTon()
        {
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
                    SELECT ht.NgayTon,ht.MaHangHoa, dvt.TenDVT, ht.SoLuong, ht.DonGia, ht.ThanhTien, ht.MaKho
                    FROM HangTonKho ht
                    JOIN HangHoa hh ON ht.MaHangHoa = hh.MaHangHoa
                    JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", idHangTon);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (reader["NgayTon"] != DBNull.Value)
                        {
                            dtmNgayTon.Value = Convert.ToDateTime(reader["NgayTon"]);
                        }
                        cmbMatHang.SelectedValue = reader["MaHangHoa"].ToString();
                        txtDVT1.Text = reader["TenDVT"]?.ToString() ?? "";
                        txtSoLuong.Text = Convert.ToDouble(reader["SoLuong"]).ToString("0.##");
                        txtDonGia1.Text = Convert.ToDecimal(reader["DonGia"]).ToString("0.##");
                        txtThanhTien.Text = Convert.ToDecimal(reader["ThanhTien"]).ToString("0.##");
                        cmbKho.SelectedValue = reader["MaKho"].ToString();
                       
                    }
                }
            }
            TinhThanhTien();
        }
        private void TinhThanhTien()
        {
            if (decimal.TryParse(txtSoLuong.Text, out decimal soLuong) &&
                decimal.TryParse(txtDonGia1.Text, out decimal donGia))
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

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        

        private void cmbMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbMatHang.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                float donGia = LayGiaNhap(maHang);
                txtDonGia1.Text = donGia.ToString("N0");

                string donViTinh = LayDonViTinh(maHang);
                txtDVT1.Text = donViTinh;
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

        private void Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
