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
using DevExpress.Data.Svg;

namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangHangTon
{
    public partial class FormHangTon : Form
    {
        public FormHangTon()
        {
            InitializeComponent();
            LoadData();
            LocDuLieu();
        }

        private void btnThemHangTon_Click(object sender, EventArgs e)
        {
            ThemHangTon themHangTon = new ThemHangTon();
            if (themHangTon.ShowDialog() == DialogResult.OK)
            {
                LoadData(); 
            }
        }

        private void btnSuaHangTon_Click(object sender, EventArgs e)
        {
            
            if (dgvHangTonKho.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvHangTonKho.CurrentRow.Cells["ID"].Value);
                SuaHangTon suaHangTon = new SuaHangTon(id);

               suaHangTon.DaSuaHangTon += (s, args) =>
                {
                    LoadData();
                };
                suaHangTon.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadData()
        {
                string query = @"
            SELECT 
                hk.ID AS [ID],
                hk.NgayTon AS [Ngày tồn],
                hh.TenHangHoa AS [Tên hàng hóa],
                dv.TenDVT AS [Đơn vị tính],
                hk.SoLuong AS [Số lượng],
                hk.DonGia AS [Đơn giá],
                hk.ThanhTien AS [Thành tiền],
                k.TenKho AS [Ten kho]
            FROM HangTonKho hk
            JOIN HangHoa hh ON hk.MaHangHoa = hh.MaHangHoa
            JOIN DonViTinh dv ON hh.MaDVT = dv.MaDVT
            JOIN Kho k ON hk.MaKho = k.MaKho";

                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHangTonKho.DataSource = dt;
                    dgvHangTonKho.Columns["Số lượng"].DefaultCellStyle.Format = "N2";
                    dgvHangTonKho.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
                    dgvHangTonKho.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
                    dgvHangTonKho.Columns["Ngày tồn"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cboTenHangHoa.Enabled = chkTheoTenHang.Checked;
            LocDuLieu();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cboKho.Enabled = chkTheoKho.Checked;
            LocDuLieu();
        }
        private void LocDuLieu()
        {
            string query = @"
                SELECT 
                    hk.ID AS [ID],
                hk.NgayTon AS [Ngày tồn],
                hh.TenHangHoa AS [Tên hàng hóa],
                dv.TenDVT AS [Đơn vị tính],
                hk.SoLuong AS [Số lượng],
                hk.DonGia AS [Đơn giá],
                hk.ThanhTien AS [Thành tiền],
                k.TenKho AS [Ten kho]
            FROM HangTonKho hk
            JOIN HangHoa hh ON hk.MaHangHoa = hh.MaHangHoa
            JOIN DonViTinh dv ON hh.MaDVT = dv.MaDVT
            JOIN Kho k ON hk.MaKho = k.MaKho
            WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (chkTheoTenHang.Checked && cboTenHangHoa.SelectedValue != null)
            {
                query += " AND hk.MaHangHoa = @MaHangHoa";
                parameters.Add(new SqlParameter("@MaHangHoa", cboTenHangHoa.SelectedValue));
            }

            if (chkTheoKho.Checked && cboKho.SelectedValue != null)
            {
                query += " AND hk.MaKho = @MaKho";
                parameters.Add(new SqlParameter("@MaKho", cboKho.SelectedValue));
            }

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHangTonKho.DataSource = dt;
            }
        }

        private void FormHangTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet36.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet36.Kho);
            // TODO: This line of code loads data into the 'quanLyBanBanhKeo_DoAnDataSet35.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.quanLyBanBanhKeo_DoAnDataSet35.HangHoa);

        }

        private void cboTenHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkTheoTenHang.Checked && cboTenHangHoa.SelectedValue != null)
                LocDuLieu();
        }

        private void cboKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkTheoKho.Checked && cboKho.SelectedValue != null)
                LocDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHangTonKho.CurrentRow != null)
            {
                
                int id = Convert.ToInt32(dgvHangTonKho.CurrentRow.Cells["ID"].Value);

                
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng hàng tồn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM HangTonKho WHERE ID = @ID";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.ExecuteNonQuery();
                    }

                  
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHangTonKho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHangTonKho.Rows[e.RowIndex];

                int id = Convert.ToInt32(dgvHangTonKho.CurrentRow.Cells["ID"].Value);
                SuaHangTon suaHangTon = new SuaHangTon(id);
                if (suaHangTon.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

       

       
       

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hangHoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void khoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvHangTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    