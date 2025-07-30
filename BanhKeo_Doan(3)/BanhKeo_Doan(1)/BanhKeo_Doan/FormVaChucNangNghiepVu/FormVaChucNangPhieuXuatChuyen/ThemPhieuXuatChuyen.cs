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

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    public partial class ThemPhieuXuatChuyen : Form
    {
        public event EventHandler DaThemPhieuPhieuXuatChuyen;
        public ThemPhieuXuatChuyen()
        {
            InitializeComponent();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemPhieuXuatChuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet47.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet47.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet23.NhanVien' table. You can move, or remove it, as needed.
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (cmbNhanVien1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNhanVien1.Focus();
                return;
            }
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM PhieuXuatChuyen WHERE MaPhieuXuatChuyen = @MaPhieuXuatChuyen";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", txtMaPhieu.Text);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {

                    string insertQuery = @"INSERT INTO PhieuXuatChuyen (MaPhieuXuatChuyen, NgayXuatChuyen, MaNhanVien, GhiChu)
                                   VALUES (@MaPhieuXuatChuyen, @NgayXuatChuyen, @MaNhanVien, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", txtMaPhieu.Text);
                    cmd.Parameters.AddWithValue("@NgayXuatChuyen", dtmPhieuNhap.Value);
                    
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbNhanVien1.SelectedValue);
                    
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChuPX.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DaThemPhieuPhieuXuatChuyen?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã phiếu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
