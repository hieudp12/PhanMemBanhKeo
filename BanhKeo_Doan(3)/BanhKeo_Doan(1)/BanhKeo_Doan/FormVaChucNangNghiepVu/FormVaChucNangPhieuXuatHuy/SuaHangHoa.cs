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
    public partial class SuaHangHoa : Form
    {
        private string ID;
        private string MaPhieuXuatHuy;
       
        public event EventHandler DaSuaHangHoaHuy;
        public SuaHangHoa(string IdDuocChonHuy, string maPhieuXuatHuy)
        {
            InitializeComponent();
            
            ID = IdDuocChonHuy;
            MaPhieuXuatHuy = maPhieuXuatHuy;
            
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapNhan1_Click(object sender, EventArgs e)
        {
           

            if (!float.TryParse(txtSoLuong1.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (float.TryParse(txtThanhTien1.Text, out float thanhTienMoi))
            {
                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {

                    conn.Open();
                    string kiemTraTrungQuery = @"
                        SELECT COUNT(*) FROM ChiTietPhieuXuatHuy
                        WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy
                          AND MaHangHoa = @MaHangHoa
                          AND MaKho = @MaKho
                          AND ID <> @ID";
                    SqlCommand kiemTraTrungCmd = new SqlCommand(kiemTraTrungQuery, conn);
                    kiemTraTrungCmd.Parameters.AddWithValue("@MaPhieuXuatHuy", MaPhieuXuatHuy);
                    kiemTraTrungCmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa1.SelectedValue);
                    kiemTraTrungCmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);
                    kiemTraTrungCmd.Parameters.AddWithValue("@ID", ID);

                    int soLuongTrung = (int)kiemTraTrungCmd.ExecuteScalar();
                    if (soLuongTrung == 0)
                    {
                        string maHangHoa = (string)cmbHangHoa1.SelectedValue;
                        int maKho = (int)cmbKho.SelectedValue;
                        float soluong = float.Parse(txtSoLuong1.Text);
                        float soLuongCu = LaySoLuongCu();
                        float tonKho = LaySoLuongTonKho(maHangHoa, maKho);
                        if (soluong > tonKho + soLuongCu)
                        {
                            MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        string query = @"
                            UPDATE ChiTietPhieuXuatHuy 
                            SET  
                                MaHangHoa = @MaHangHoa, 
                                SoLuong = @SoLuong, 
                                DonGia = @DonGia, 
                                ThanhTien = @ThanhTien,
                                MaKho =@MaKho,
                                GhiChu = @GhiChu
                            WHERE ID = @ID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa1.SelectedValue);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DonGia", txtDonGia1.Text);
                        cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien1.Text);
                        cmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);
                        cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu1.Text ?? "");

                        cmd.ExecuteNonQuery();


                        DaSuaHangHoaHuy?.Invoke(this, EventArgs.Empty);
                        MessageBox.Show("Sửa hàng hóa trong phiếu hủy thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hàng hóa này đã tồn tại trong phiếu nhập với cùng kho!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }
        private void TinhToanTuDong()
        {
            if (float.TryParse(txtSoLuong1.Text, out float soLuong) && float.TryParse(txtDonGia1.Text, out float donGia))
            {

                float thanhTien = soLuong * donGia;


                txtThanhTien1.Text = thanhTien.ToString("N0");
            }
            else
            {


                txtThanhTien1.Text = "";
            }
        }
        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet93.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter1.Fill(this.quanLyBanBanhKeo_DoAnDataSet93.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet41.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet41.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet35.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet35.HangHoa);
            LoadThongTinChiTietHuy(); 
        }
        private void LoadThongTinChiTietHuy()
        {
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
                    SELECT ph.MaHangHoa, dvt.TenDVT, ph.SoLuong, ph.DonGia, ph.ThanhTien, ph.MaKho, ph.GhiChu
                    FROM ChiTietPhieuXuatHuy ph
                    JOIN HangHoa hh ON ph.MaHangHoa = hh.MaHangHoa
                    JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbHangHoa1.SelectedValue = reader["MaHangHoa"].ToString();
                        txtDVT1.Text = reader["TenDVT"]?.ToString() ?? "";
                        txtSoLuong1.Text = Convert.ToDouble(reader["SoLuong"]).ToString("0.##");
                        txtDonGia1.Text = Convert.ToDecimal(reader["DonGia"]).ToString("0.##");
                        txtThanhTien1.Text = Convert.ToDecimal(reader["ThanhTien"]).ToString("0.##");
                        cmbKho.SelectedValue = reader["MaKho"].ToString();
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

        private void txtDonGia1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTuDong();
        }

        private void cmbHangHoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbHangHoa1.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                float donGia = LayGiaNhap(maHang);
                txtDonGia1.Text = donGia.ToString("N0");
                
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
                string query = "SELECT SoLuong FROM ChiTietPhieuXuatHuy WHERE ID = @ID";
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
