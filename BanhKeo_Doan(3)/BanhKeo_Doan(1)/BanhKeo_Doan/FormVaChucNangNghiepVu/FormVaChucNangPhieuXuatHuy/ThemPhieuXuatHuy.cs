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
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy
{
    public partial class ThemPhieuXuatHuy : Form
    {
        public event EventHandler DaThemPhieuPhieuXuatHuy;
        public ThemPhieuXuatHuy()
        {
            InitializeComponent();
        }


        private void ThemPhieuXuatHuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet94.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet94.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet55.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet55.Kho);

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhieuXuatHuy.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu xuất hủy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhieuXuatHuy.Focus();
                return;
            }
            
            if (cmbNhanVien.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNhanVien.Focus();
                return;
            }
           
            if (cmbKho.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKho.Focus();
                return;
            }
          
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM PhieuXuatHuy WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhieuXuatHuy", txtPhieuXuatHuy.Text);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {

                    string insertQuery = @"INSERT INTO PhieuXuatHuy (MaPhieuXuatHuy, NgayXuatHuy, MaNhanVien, TongTien, MaKho, GhiChu)
                                   VALUES (@MaPhieuXuatHuy, @NgayXuatHuy, @MaNhanVien, @TongTien, @MaKho, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuXuatHuy", txtPhieuXuatHuy.Text);
                    cmd.Parameters.AddWithValue("@NgayXuatHuy", dtmNgayHuy.Value);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cmbNhanVien.SelectedValue);
                    cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                    cmd.Parameters.AddWithValue("@MaKho", cmbKho.SelectedValue);
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DaThemPhieuPhieuXuatHuy?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã phiếu đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
