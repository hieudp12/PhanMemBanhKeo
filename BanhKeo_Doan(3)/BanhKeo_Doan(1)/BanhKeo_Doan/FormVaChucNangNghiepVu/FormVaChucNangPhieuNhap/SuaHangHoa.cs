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
    public partial class SuaHangHoa : Form
    {
        private string ID;
        private string MaPhieuNhap;
    
        public event EventHandler DaSuaHangHoa;
        public SuaHangHoa(string IdDuocChon, string maPhieuNhap)
        {
            InitializeComponent();
            this.ID = IdDuocChon;
            this.MaPhieuNhap = maPhieuNhap;
           
        }

       
        
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtSoLuongNhap1.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là số hợp lệ và > 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongNhap1.Focus();
                return;
            }

            if (!float.TryParse(txtPhanTramCK1.Text, out float phanTramCK) || phanTramCK < 0 || phanTramCK > 100)
            {
                MessageBox.Show("Chiết khấu phải là số từ 0 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhanTramCK1.Focus();
                return;
            }
            TinhToanTuDong();


            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                conn.Open();

                string maHangHoa = (string)cmbTenHang1.SelectedValue;
                int maKho = (int)cmbKho1.SelectedValue;

                string query = @"
                     UPDATE ChiTietPhieuNhap SET 
                         SoLuongNhap = @SoLuongNhap,
                         DonGiaChuaCK = @DonGiaChuaCK,
                         PhanTramCK = @PhanTramCK,
                         ChietKhau = @ChietKhau,
                         DonGiaSauCK = @DonGiaSauCK,
                         ThanhTien = @ThanhTien,
                         MaKho = @MaKho,
                         GhiChu = @GhiChu
                     WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@SoLuongNhap", soLuong);
                cmd.Parameters.AddWithValue("@DonGiaChuaCK", float.Parse(txtGiaTruocCK1.Text));
                cmd.Parameters.AddWithValue("@PhanTramCK", phanTramCK);
                cmd.Parameters.AddWithValue("@ChietKhau", float.Parse(txtGiaCK1.Text));
                cmd.Parameters.AddWithValue("@DonGiaSauCK", float.Parse(txtGiaSauCK1.Text));
                cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien1.Text);
                cmd.Parameters.AddWithValue("@MaKho", cmbKho1.SelectedValue);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu1.Text ?? "");

                cmd.ExecuteNonQuery();
                DaSuaHangHoa?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Sửa hàng nhập thành công!");
                this.Close();
            }
        }
        private void TinhToanTuDong()
        {
            if (float.TryParse(txtSoLuongNhap1.Text, out float soLuong) && float.TryParse(txtGiaTruocCK1.Text, out float donGiaTruocCK) && float.TryParse(txtPhanTramCK1.Text, out float phanTramCK))
            {

                float giaCK = donGiaTruocCK * (phanTramCK / 100);
                float donGiaSauCK = donGiaTruocCK * (1 - (phanTramCK / 100));
                float thanhTien = soLuong * donGiaSauCK;

                txtGiaCK1.Text = giaCK.ToString("0.##");
                txtGiaSauCK1.Text = donGiaSauCK.ToString("0.##");
                txtThanhTien1.Text = thanhTien.ToString("0.##");

            }
            else
            {

                txtGiaCK1.Text = "";
                txtGiaSauCK1.Text = "";
                txtThanhTien1.Text = "";
            }
        }

       

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet91.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet91.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet41.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet41.Kho);

            LoadThongTinChiTietNhap();
        }
        private void LoadThongTinChiTietNhap()
        {
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
                    SELECT ct.MaHangHoa, 
                            dvt.TenDVT, 
                            ct.SoLuongNhap,  
                           ct.DonGiaChuaCK, 
                            ct.PhanTramCK, 
                            ct.ChietKhau, 
                           ct.DonGiaSauCK, 
                            ct.ThanhTien, 
                            ct.MaKho, 
                            ct.GhiChu
                    FROM ChiTietPhieuNhap ct
                    JOIN HangHoa hh ON ct.MaHangHoa = hh.MaHangHoa
                    JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                    WHERE ct.ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        cmbKho1.SelectedValue = reader["MaKho"].ToString();
                        cmbTenHang1.SelectedValue = reader["MaHangHoa"].ToString();

                        txtDVT1.Text = reader["TenDVT"]?.ToString() ?? "";
                        txtSoLuongNhap1.Text = Convert.ToDouble(reader["SoLuongNhap"]).ToString("0.##");
                        txtGiaTruocCK1.Text = Convert.ToDecimal(reader["DonGiaChuaCK"]).ToString("0.##");
                        txtPhanTramCK1.Text = Convert.ToDecimal(reader["PhanTramCK"]).ToString("0.##");
                        txtGiaCK1.Text = Convert.ToDecimal(reader["ChietKhau"]).ToString("0.##");
                        txtGiaSauCK1.Text = Convert.ToDecimal(reader["DonGiaSauCK"]).ToString("0.##");
                        txtThanhTien1.Text = Convert.ToDecimal(reader["ThanhTien"]).ToString("0.##");
                        txtGhiChu1.Text = reader["GhiChu"]?.ToString() ?? "";
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTenHang1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbTenHang1.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                float donGia = LayGiaNhap(maHang);
                
                txtGiaTruocCK1.Text = donGia.ToString("0.##");

                string donViTinh = LayDonViTinh(maHang);
                txtDVT1.Text = donViTinh;
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
        private void txtSoLuongNhap1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
            
        }

        private void txtPhanTramCK1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
            
        }
       
    }
}
