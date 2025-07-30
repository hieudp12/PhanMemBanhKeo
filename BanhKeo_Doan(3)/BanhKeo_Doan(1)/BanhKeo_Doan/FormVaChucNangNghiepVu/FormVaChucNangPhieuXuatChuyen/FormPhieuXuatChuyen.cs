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
using DevExpress.XtraBars.Navigation;
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap;
using BanhKeo_Doan.Chuc_nang_danh_muc.Danh_muc_Kho;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen
{
    public partial class FormPhieuXuatChuyen : Form
    {
        public FormPhieuXuatChuyen()
        {
            InitializeComponent();
        }
        private string maPhieuXuat = "";
   
       
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            ThemHangHoa themHangHoa = new ThemHangHoa(maPhieuXuat);

            themHangHoa.DaThemHangHoaXuat += (s, args) =>
            {
                LoadChiTietPhieuXuatChuyen(maPhieuXuat);
            };
            themHangHoa.Show();
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.CurrentRow != null)
            {

                string idDuocChon = dgvChiTietPhieuXuat.CurrentRow.Cells["ID"].Value.ToString();

                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon);

                suaHangHoa.DaSuaHangHoaXuat += (s, args) =>
                {
                    LoadChiTietPhieuXuatChuyen(maPhieuXuat);
                };
                suaHangHoa.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemPhieuXuatChuyen_Click(object sender, EventArgs e)
        {
            ThemPhieuXuatChuyen form = new ThemPhieuXuatChuyen();
            form.DaThemPhieuPhieuXuatChuyen += (s, args) => LoadPhieuXuat();
            form.Show();
        }

        private void FormPhieuXuatChuyen_Load(object sender, EventArgs e)
        {
           
            LoadPhieuXuat();
            dgvPhieuXuatChuyen.CellClick += dgvPhieuXuatChuyen_CellClick;
        }
        private void LoadPhieuXuat()
        {
            try
            {
                string query = @"
                SELECT 
                    px.MaPhieuXuatChuyen AS [Mã phiếu xuất],
                    px.NgayXuatChuyen AS [Ngày xuất kho],
                    nv.TenNhanVien AS [Nhân viên giao],
                    px.GhiChu AS [Ghi chú]
                    
                FROM PhieuXuatChuyen px
                
                JOIN NhanVien nv ON px.MaNhanVien = nv.MaNhanVien";

                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhieuXuatChuyen.DataSource = dt;
                    dgvPhieuXuatChuyen.Columns["Ngày xuất kho"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            if (!ckbMaPhieu.Checked && !ckbTheoNgay.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một tiêu chí để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            

            
            if (ckbMaPhieu.Checked && string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu cần tìm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                SELECT 
                    px.MaPhieuXuatChuyen AS [Mã phiếu xuất],
                    px.NgayXuatChuyen AS [Ngày xuất kho],
                    
                    nv.TenNhanVien AS [Nhân viên giao],
                    px.GhiChu AS [Ghi chú]
                FROM PhieuXuatChuyen px
                
                JOIN NhanVien nv ON px.MaNhanVien = nv.MaNhanVien
                WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (ckbMaPhieu.Checked)
            {
                query += " AND px.MaPhieuXuatChuyen LIKE @maPhieu";
                parameters.Add(new SqlParameter("@maPhieu", "%" + txtMaPhieu.Text.Trim() + "%"));
            }

            if (ckbTheoNgay.Checked)
            {
                DateTime tuNgay = dtmTuNgay.Value.Date;
                DateTime denNgay = dtmDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                query += " AND px.NgayXuatChuyen BETWEEN @tuNgay AND @denNgay";
                parameters.Add(new SqlParameter("@tuNgay", tuNgay));
                parameters.Add(new SqlParameter("@denNgay", denNgay));
            }

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPhieuXuatChuyen.DataSource = dt;  
            }
        }
        private void LoadChiTietPhieuXuatChuyen(string maPhieuXuat)
        {
            string query = @"
                            SELECT 
                                ctpxc.ID AS [ID],
                                k1.TenKho AS [Kho xuất],
                                k2.TenKho AS [Kho nhập],
                                hh.TenHangHoa AS [Tên hàng],
                                dvt.TenDVT AS [Đơn vị tính],
                                ctpxc.SoLuongXuat AS [Số lượng xuất],
                                ctpxc.GhiChu AS [Ghi chú]
                            FROM ChiTietPhieuXuatChuyen ctpxc
                            JOIN HangHoa hh ON ctpxc.MaHangHoa = hh.MaHangHoa
                            JOIN Kho k1 ON ctpxc.MaKhoXuat = k1.MaKho
                            JOIN Kho k2 ON ctpxc.MaKhoNhap = k2.MaKho
                            JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                            WHERE ctpxc.MaPhieuXuatChuyen = @MaPhieuXuatChuyen";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuXuatChuyen", maPhieuXuat);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTietPhieuXuat.DataSource = dt;
                dgvChiTietPhieuXuat.Columns["Số lượng xuất"].DefaultCellStyle.Format = "N2";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhieuXuat))
            {
                MessageBox.Show("Vui lòng chọn một phiếu xuất chuyển để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu xuất chuyển này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();

                       
                        SqlCommand cmdChiTiet = new SqlCommand("DELETE FROM ChiTietPhieuXuatChuyen WHERE MaPhieuXuatChuyen = @MaPhieuXuat", conn);
                        cmdChiTiet.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                        cmdChiTiet.ExecuteNonQuery();

                        
                        SqlCommand cmdPhieu = new SqlCommand("DELETE FROM PhieuXuatChuyen WHERE MaPhieuXuatChuyen = @MaPhieuXuat", conn);
                        cmdPhieu.Parameters.AddWithValue("@MaPhieuXuat", maPhieuXuat);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa phiếu xuất chuyển thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuXuat();
                    dgvChiTietPhieuXuat.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu xuất chuyển: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPhieuXuatChuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuXuatChuyen.Rows[e.RowIndex];

                maPhieuXuat = row.Cells["Mã phiếu xuất"].Value?.ToString();

                txtSoPhieu.Text = maPhieuXuat;
                dtmNgayXuatChuyen.Value = Convert.ToDateTime(row.Cells["Ngày xuất kho"].Value);
                
                txtNhanVien.Text = row.Cells["Nhân viên giao"].Value?.ToString();
                txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();
                LoadChiTietPhieuXuatChuyen(maPhieuXuat);

                tabPhieuXuatChuyen.SelectedTab = tabChiTiet;


            }
        }
      
        private void dgvChiTietPhieuXuat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvChiTietPhieuXuat.Rows[e.RowIndex];


                string idDuocChon = row.Cells["ID"].Value.ToString();


                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon);


                suaHangHoa.DaSuaHangHoaXuat += (s, args) =>
                {
                    LoadChiTietPhieuXuatChuyen(maPhieuXuat);
                };

                suaHangHoa.Show();
            }
        }

       
        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng chi tiết để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idDuocChon = dgvChiTietPhieuXuat.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietPhieuXuatChuyen WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", idDuocChon);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietPhieuXuatChuyen(maPhieuXuat);
                    LoadPhieuXuat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            InPhieuXuatChuyen phieuXuatChuyen = new InPhieuXuatChuyen(maPhieuXuat);
            phieuXuatChuyen.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

                    