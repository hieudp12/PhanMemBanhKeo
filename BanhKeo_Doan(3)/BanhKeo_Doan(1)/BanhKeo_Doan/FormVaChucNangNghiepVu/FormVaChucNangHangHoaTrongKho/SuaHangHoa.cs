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
    public partial class SuaHangHoa : Form
    {
        public SuaHangHoa(string IdDuocChon)
        {
            InitializeComponent();
            this.ID = IdDuocChon;
        }
        public string ID;
        public event EventHandler DaSuaHangHoa;
        public string tenHangHoa { get; set; }
        public string soLuong { get; set; }
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = KetNoiCSDL.GetConnection();
            conn.Open();
            int index = cmbBoxHangHoa.FindStringExact(tenHangHoa);
            cmbBoxHangHoa.SelectedIndex = index;
            string maHangHoa = cmbBoxHangHoa.SelectedValue?.ToString();
            int maKho = (int)cmbBoxKho.SelectedValue;
            string insertQuery = "UPDATE HangHoaTrongKho SET " +
                    "SoLuong = @SoLuong, " +
                    "MaKho = @MaKho " +
                    "where ID = @ID ";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("@MaKho", cmbBoxKho.SelectedValue);
            cmd.ExecuteNonQuery();
            DaSuaHangHoa?.Invoke(this, EventArgs.Empty);
            MessageBox.Show("Sửa hàng hóa thành công.", "Thông báo", MessageBoxButtons.OK);
            this.Close();
            conn.Close();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SuaHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet107.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet107.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet106.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet106.HangHoa);
            cmbBoxHangHoa.Text = string.Empty;
            cmbBoxHangHoa.SelectedText = tenHangHoa;
            txtSoLuong.Text = soLuong;
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
