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
    public partial class ThemPhieuNhap : Form
    {
        public event EventHandler DaThemPhieuNhap;
        public ThemPhieuNhap()
        {
            InitializeComponent();
        }

        private void ThemPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet61.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet61.NhanVien);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet60.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet60.NhaCungCap);

        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieuNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieuNhap.Focus();
                return;
            }

            if (cbLoaiNhap.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLoaiNhap.Focus();
                return;
            }

            if (cbNCC.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNCC.Focus();
                return;
            }

            if (cbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNhanVien.Focus();
                return;
            }

           
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM PhieuNhap WHERE MaPhieuNhap = @MaPhieuNhap";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                   
                    string insertQuery = @"INSERT INTO PhieuNhap (MaPhieuNhap, NgayNhap, LoaiNhap, MaNhaCungCap, TongTien, MaNhanVien, GhiChu)
                                   VALUES (@MaPhieuNhap, @NgayNhap, @LoaiNhap, @MaNhaCungCap, @TongTien, @MaNhanVien, @GhiChu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuNhap", txtMaPhieuNhap.Text);
                    cmd.Parameters.AddWithValue("@NgayNhap", dateNgayNhap.Value);
                    cmd.Parameters.AddWithValue("@LoaiNhap", cbLoaiNhap.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@MaNhaCungCap", cbNCC.SelectedValue);
                    cmd.Parameters.AddWithValue("@TongTien", txtTongTien.Text);
                    cmd.Parameters.AddWithValue("@MaNhanVien", cbNhanVien.SelectedValue); 
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DaThemPhieuNhap?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiNhap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nhaCungCapBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
