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
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    public partial class ThemPhieuXuatRaSX : Form
    {
        public event EventHandler DaThemPhieuPhieuSX;
        public ThemPhieuXuatRaSX()
        {
            InitializeComponent();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuSX.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu xuất hủy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieuSX.Focus();
                return;
            }
          
            if (cmbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNhanVien.Focus();
                return;
            }

            if (cmbKeHoach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kế hoạch.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKeHoach.Focus();
                return;
            }
            if (cmbLoaiXuat.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiXuat.Focus();
                return;
            }
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM PhieuXuatRaSX WHERE MaPhieuXuatSX = @MaPhieuXuatSX";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhieuXuatSX", txtMaPhieuSX.Text);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {

                    string insertQuery = @"INSERT INTO PhieuXuatRaSX (MaPhieuXuatSX, NgayXuat, LoaiXuat, MaKeHoach, MaNhanVien, GhiChu)
                                   VALUES (@MaPhieuXuatSX, @NgayXuat, @LoaiXuat, @MaKeHoach, @MaNhanVien, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuXuatSX", txtMaPhieuSX.Text);
                    cmd.Parameters.AddWithValue("@NgayXuat", dtmXuatSX.Value);
                    cmd.Parameters.AddWithValue("@LoaiXuat", cmbLoaiXuat.SelectedItem);
                    cmd.Parameters.AddWithValue("@MaKeHoach", cmbKeHoach.SelectedValue);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DaThemPhieuPhieuSX?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã phiếu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ThemPhieuXuatRaSX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet51.KeHoachSanXuat' table. You can move, or remove it, as needed.
            this.keHoachSanXuatTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet51.KeHoachSanXuat);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet50.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet50.NhanVien);

        }
    }
}
