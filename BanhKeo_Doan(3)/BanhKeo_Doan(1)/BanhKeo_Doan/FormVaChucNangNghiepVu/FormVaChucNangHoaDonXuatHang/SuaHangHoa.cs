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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHoaDonXuatHang
{
    public partial class SuaHangHoa : Form
    {
        public SuaHangHoa(string IdDuocChon)
        {
            InitializeComponent();
            this.ID = IdDuocChon;
        }
        private string ID;

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet20.Kho' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet19.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet20.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet20.Kho);
            cmbBoxHangHoa.Text = string.Empty;
            cmbBoxHangHoa.SelectedText = tenHangHoa;
            txtSoLuong.Text = soLuong;
            txtDGchuaCK.Text = donGia;
            txtPhanTramCK.Text = phanTramCK;
        }
        public event EventHandler DaSuaHangHoa;
        public string tenHangHoa { get; set; }
        public string soLuong { get; set; }
        public string donGia { get; set; }
        public string phanTramCK { get; set; }
        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            int index = cmbBoxHangHoa.FindStringExact(tenHangHoa);
            cmbBoxHangHoa.SelectedIndex = index;
            string maHangHoa = cmbBoxHangHoa.SelectedValue?.ToString();
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
            string insertQuery = "UPDATE ChiTietHoaDonXuatHang SET " +
                    "SoLuong = @SoLuong, " +
                    "DonGiaTruocCK = @DonGiaTruocCK, " +
                    "PhanTramCK = @PhanTramCK, " +
                    "ChietKhau = @SoTienChietKhau, " +
                    "DonGiaSauCK = @DonGiaSauCK, " +
                    "ThanhTien = @ThanhTien," +
                    "MaKho = @MaKho, " +
                    "GhiChu = @GhiChu " +
                    "where ID = @ID ";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGiaTruocCK", txtDGchuaCK.Text);
            cmd.Parameters.AddWithValue("@PhanTramCK", txtPhanTramCK.Text);
            cmd.Parameters.AddWithValue("@SoTienChietKhau", txtSoTienCK.Text);
            cmd.Parameters.AddWithValue("@DonGiaSauCK", txtDGsauCK.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
            cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            DaSuaHangHoa?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Sửa hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
            this.Close();
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
