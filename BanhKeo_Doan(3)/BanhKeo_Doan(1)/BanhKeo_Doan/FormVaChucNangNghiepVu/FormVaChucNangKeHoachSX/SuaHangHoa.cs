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
    public partial class SuaHangHoa : Form
    {
        public SuaHangHoa(string iD)
        {
            InitializeComponent();
            this.ID = iD;
        }
        private string ID;
        public string tenHangHoa { get; set; }
        public string soLuong { get; set; }
        public string donGia { get; set; }
        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler DaSuaHangHoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            float soluong = float.Parse(txtSoLuong.Text);
            float DonGia = float.Parse(txtDonGia.Text);
            txtThanhTien.Text = (soluong * DonGia).ToString();
            string insertQuery = "UPDATE ChiTietKeHoachSX SET " +
                    "SoLuong = @SoLuong, " +
                    "DonGia = @DonGia, " +
                    "ThanhTien = @ThanhTien," +
                    "MaKho = @MaKho," +
                    "GhiChu = @GhiChu " +
                    "where ID = @ID ";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("@DonGia", txtDonGia.Text);
            cmd.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text);
            cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
            cmd.ExecuteNonQuery();
            DaSuaHangHoa?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Sửa hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
            this.Close();
            conn.Close();
        }

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet26.Kho' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet25.HangHoa);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet26.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet26.Kho);
            cmbBoxHangHoa.Text = string.Empty;
            cmbBoxHangHoa.SelectedText = tenHangHoa;
            txtSoLuong.Text = soLuong;
            txtDonGia.Text = donGia;
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

        private void Huy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
