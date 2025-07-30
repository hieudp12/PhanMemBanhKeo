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
    public partial class SuaHangHoa : Form
    {
        private string ID;
        public event EventHandler DaSuaHangHoaXuat;
        public SuaHangHoa(string IdDuocChonXuat)
        {
            InitializeComponent();
            ID = IdDuocChonXuat;
        }



        public string tenHangHoa { get; set; }

        private void Huy1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet98.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter1.Fill(this.quanLyBanBanhKeo_DoAnDataSet98.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet92.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet92.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet49.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet49.Kho);
            LoadThongTinChiTietXuat();

        }

        private void btnChapNhan1_Click(object sender, EventArgs e)
        {
            

            if (cmbKhoXuat1.SelectedValue.ToString() == cmbKhoNhap1.SelectedValue.ToString())
            {
                MessageBox.Show("Kho xuất và kho nhập không được trùng nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(txtSoLuongXuat1.Text, out float soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng xuất hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    conn.Open();
                    string checkQuery = @"
                        SELECT COUNT(*) FROM ChiTietPhieuXuatChuyen 
                        WHERE ID <> @ID
                        AND MaPhieuXuatChuyen = (SELECT MaPhieuXuatChuyen FROM ChiTietPhieuXuatChuyen WHERE ID = @ID)
                        AND MaHangHoa = @MaHangHoa 
                        AND MaKhoXuat = @MaKhoXuat 
                        AND MaKhoNhap = @MaKhoNhap";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ID", ID);
                        checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa1.SelectedValue);
                        checkCmd.Parameters.AddWithValue("@MaKhoXuat", cmbKhoXuat1.SelectedValue);
                        checkCmd.Parameters.AddWithValue("@MaKhoNhap", cmbKhoNhap1.SelectedValue);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {

                            string maHangHoa = (string)cmbHangHoa1.SelectedValue;
                            int maKho = (int)cmbKhoXuat1.SelectedValue;
                            float soLuongCu = LaySoLuongCu();
                            float tonKho = LaySoLuongTonKho(maHangHoa, maKho);
                            if (soLuong > tonKho + soLuongCu)
                            {
                                MessageBox.Show($"Số lượng vượt quá tồn kho ({tonKho}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            string query = @"
                                UPDATE ChiTietPhieuXuatChuyen  SET 
                      
                                    MaKhoXuat = @MaKhoXuat, 
                                    MaKhoNhap = @MaKhoNhap,
                                    MaHangHoa = @MaHangHoa, 
                                    SoLuongXuat = @SoLuongXuat, 
                                    GhiChu = @GhiChu
                                WHERE ID = @ID";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@MaHangHoa", cmbHangHoa1.SelectedValue);
                            cmd.Parameters.AddWithValue("@MaKhoXuat", cmbKhoXuat1.SelectedValue);
                            cmd.Parameters.AddWithValue("@MaKhoNhap", cmbKhoNhap1.SelectedValue);
                            cmd.Parameters.AddWithValue("@SoLuongXuat", soLuong);
                            cmd.Parameters.AddWithValue("@GhiChu", txtGhiC.Text);

                            cmd.ExecuteNonQuery();
                            DaSuaHangHoaXuat?.Invoke(this, EventArgs.Empty);
                            MessageBox.Show("Sửa hàng nhập thành công!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bản ghi trùng với bản ghi khác đã có!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật dữ liệu:\n" + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadThongTinChiTietXuat()
        {
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"
                    SELECT pxc.MaPhieuXuatChuyen, pxc.MaKhoXuat, pxc.MaKhoNhap, pxc.MaHangHoa, 
                            dvt.TenDVT, pxc.SoLuongXuat, pxc.GhiChu
                        FROM ChiTietPhieuXuatChuyen pxc
                        JOIN HangHoa hh ON pxc.MaHangHoa = hh.MaHangHoa
                        JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                        WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbKhoXuat1.SelectedValue = reader["MaKhoXuat"].ToString();
                        cmbKhoNhap1.SelectedValue = reader["MaKhoNhap"].ToString();
                        cmbHangHoa1.SelectedValue = reader["MaHangHoa"].ToString();
                        txtDVT1.Text = reader["TenDVT"].ToString();
                        txtSoLuongXuat1.Text = Convert.ToDouble(reader["SoLuongXuat"]).ToString("0.##");
                        txtGhiC.Text = reader["GhiChu"]?.ToString() ?? "";
                    }
                }
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
        private float LaySoLuongCu()
        {
            float soLuongCu = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = "SELECT SoLuongXuat FROM ChiTietPhieuXuatChuyen WHERE ID = @ID";
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
        private void cmbHangHoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbHangHoa1.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {

                

                string donViTinh = LayDonViTinh(maHang);
                txtDVT1.Text = donViTinh;
            }
        }
    }
}
