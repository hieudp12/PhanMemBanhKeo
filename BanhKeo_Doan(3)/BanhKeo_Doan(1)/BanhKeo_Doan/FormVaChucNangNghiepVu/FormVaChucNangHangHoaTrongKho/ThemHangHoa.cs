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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangHoaTrongKho
{
    public partial class ThemHangHoa : Form
    {
        public ThemHangHoa()
        {
            InitializeComponent();
        }
        public event EventHandler DaThemHangHoa;
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection conn = KetNoiCSDL.GetConnection();
            string checkQuery = "SELECT COUNT(*) FROM HangHoaTrongKho WHERE MaHangHoa = @MaHangHoa and MaKho = @MaKho";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
            checkCmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            if (count == 0)
            {
                string insertQuery = "INSERT INTO HangHoaTrongKho(MaHangHoa, SoLuong, MaKho) " +
                   "VALUES (@MaHangHoa, @SoLuong, @MaKho)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@MaHangHoa", cmbBoxHangHoa.SelectedValue);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
                cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
                cmd.ExecuteNonQuery();
                DaThemHangHoa?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Thêm hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
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

        private void ThemHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet105.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet105.Kho);
            LoadCmbBoxHH();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
