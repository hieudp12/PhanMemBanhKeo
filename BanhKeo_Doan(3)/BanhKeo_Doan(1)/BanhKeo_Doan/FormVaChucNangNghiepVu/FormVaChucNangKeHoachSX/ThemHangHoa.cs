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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangKeHoachSX
{
    public partial class ThemHangHoa : Form
    {
        public ThemHangHoa(string MaKeHoachDuocChon)
        {
            InitializeComponent();
            this.MaKeHoach = MaKeHoachDuocChon;
        }
        private string MaKeHoach;
        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler DaThemHangHoa;
        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet28.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet28.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet27.HangHoa' table. You can move, or remove it, as needed.
            //this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet27.HangHoa);
            LoadCmbBoxHH();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM ChiTietKeHoachSX WHERE ChiTietKeHoachSX.MaHangHoa = @MaHangHoa and MaKeHoach = @MaKeHoach and ChiTietKeHoachSX.MaKho = @MaKho";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
            checkCmd.Parameters.AddWithValue("@MaKeHoach", MaKeHoach);
            checkCmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                float soluong = float.Parse(txtSoLuong.Text);
                float DonGia = float.Parse(txtDonGia.Text);
                txtThanhTien.Text = (soluong * DonGia).ToString();
                string insertQuery = "INSERT INTO ChiTietKeHoachSX (MaKeHoach, MaHangHoa, SoLuong, DonGia, ThanhTien, MaKho, GhiChu) " +
                   "VALUES (@MaKeHoach, @MaHangHoa, @SoLuong, @DonGia, @ThanhTien, @MaKho, @GhiChu)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaKeHoach", MaKeHoach);
                cmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
                cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
                cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
                cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                cmd.ExecuteNonQuery();
                DaThemHangHoa?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm hàng hóa thành công.!", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hàng hóa đã tồn tại! Vui lòng chọn hàng hóa khác.");
            }
            conn.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbBoxHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maHang = cmbBoxHangHoa.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(maHang))
            {              
                 float donGia = LayGiaSanXuat(maHang);
                 txtDonGia.Text = donGia.ToString("N0");               
            }
        }       
       

        private float LayGiaSanXuat(string maHang)
        {
            float donGia = 0;
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string query = @"SELECT SUM(ISNULL(DinhLuong.SoLuong, 0) * ISNULL(BangGia.GiaNhap, 0)) AS DonGiaSanXuat
                                FROM DinhLuong
                                INNER JOIN BangGia ON DinhLuong.MaHangHoaNL = BangGia.MaHangHoa
                                WHERE DinhLuong.MaHangHoa = @MaHangHoa";
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

        public void LoadCmbBoxHH()
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            string query = @"SELECT HangHoa.MaHangHoa, HangHoa.TenHangHoa
                 FROM HangHoa
                 JOIN LoaiHang ON HangHoa.MaLoaiHang = LoaiHang.MaLoaiHang
                 JOIN NganhHang ON LoaiHang.MaNganhHang = NganhHang.MaNganhHang
                 WHERE NganhHang.MaNganhHang = 1";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBoxHangHoa.DataSource = dt;
            cmbBoxHangHoa.DisplayMember = "TenHangHoa";
            cmbBoxHangHoa.ValueMember = "MaHangHoa";
            conn.Close();
        }
    }
}
