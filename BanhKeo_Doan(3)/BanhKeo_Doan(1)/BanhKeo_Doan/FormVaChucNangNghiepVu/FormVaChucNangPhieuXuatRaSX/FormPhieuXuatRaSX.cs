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
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatChuyen;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatRaSX
{
    public partial class FormPhieuXuatRaSX : Form
    {
        public FormPhieuXuatRaSX()
        {
            InitializeComponent();
        }
        private string maPhieuSX = "";
        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            
            ThemHangHoa themHangHoa = new ThemHangHoa(maPhieuSX);
            themHangHoa.DaThemHangHoaXuatSX += (s, args) =>
            {
                LoadChiTietPhieuXuatRaSX(maPhieuSX);
            };
            themHangHoa.Show();
        }
       
        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietSX.CurrentRow != null)
            {

                string idDuocChon = dgvChiTietSX.CurrentRow.Cells["ID"].Value.ToString();

                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon);

                suaHangHoa.DaSuaHangHoaSanXuat += (s, args) =>
                {
                    LoadChiTietPhieuXuatRaSX(maPhieuSX);
                };
                suaHangHoa.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemPhieuXuatRaSX_Click(object sender, EventArgs e)
        {
            ThemPhieuXuatRaSX form = new ThemPhieuXuatRaSX();
            form.DaThemPhieuPhieuSX += (s, args) => LoadPhieuSX();
            form.Show();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPhieuXuatRaSX_Load(object sender, EventArgs e)
        {
            LoadPhieuSX();
        }
        private void LoadPhieuSX()
        {
            try
            {
                string query = @"
                SELECT 
                    pxsx.MaPhieuXuatSX AS [Mã phiếu],
                    pxsx.NgayXuat AS [Ngày xuất],
                    pxsx.LoaiXuat AS [Loại xuất],
                    kh.MaKeHoach AS [Số kế hoạch],
                    nv.TenNhanVien AS [Nhân viên],
                    pxsx.GhiChu AS [Ghi chú]
                FROM PhieuXuatRaSX pxsx
                JOIN KeHoachSanXuat kh ON pxsx.MaKeHoach = kh.MaKeHoach
                JOIN NhanVien nv ON pxsx.MaNhanVien = nv.MaNhanVien";

                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPhieuXuatSX.DataSource = dt;
                    dgvPhieuXuatSX.Columns["Ngày xuất"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           

            if (ckbKeHoach.Checked && string.IsNullOrWhiteSpace(txtKeHoach.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu cần tìm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"
                SELECT 
                    pxsx.MaPhieuXuatSX AS [Mã phiếu],
                    pxsx.NgayXuat AS [Ngày xuất],
                    pxsx.LoaiXuat AS [Loại xuất],
                    kh.MaKeHoach AS [Số kế hoạch],
                    nv.TenNhanVien AS [Nhân viên],
                    pxsx.GhiChu AS [Ghi chú]
                FROM PhieuXuatRaSX pxsx
                JOIN KeHoachSanXuat kh ON pxsx.MaKeHoach = kh.MaKeHoach
                JOIN NhanVien nv ON pxsx.MaNhanVien = nv.MaNhanVien
                WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (ckbKeHoach.Checked)
            {
                string soKeHoach = txtKeHoach.Text.Trim();
                if (string.IsNullOrEmpty(soKeHoach))
                {
                    MessageBox.Show("Vui lòng nhập số kế hoạch cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                query += " AND kh.MaKeHoach LIKE @SoKeHoach";
                parameters.Add(new SqlParameter("@SoKeHoach", "%" + soKeHoach + "%"));
            }

            
            if (ckbTheoNgay.Checked)
            {
                DateTime tuNgay = dtmTuNGay.Value.Date;
                DateTime denNgay = dtmDenNgay.Value.Date.AddDays(1).AddTicks(-1);
                query += " AND pxsx.NgayXuat BETWEEN @tuNgay AND @denNgay";
                parameters.Add(new SqlParameter("@tuNgay", tuNgay));
                parameters.Add(new SqlParameter("@denNgay", denNgay));
            }

            if (ckbLoaiXuat.Checked)
            {
                if (cmbLoaiXuat.SelectedItem != null)
                {
                    query += " AND pxsx.LoaiXuat = @LoaiXuat";
                    parameters.Add(new SqlParameter("@LoaiXuat", cmbLoaiXuat.SelectedItem.ToString()));
                }
            }

            
            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPhieuXuatSX.DataSource = dt;
            }
        }
        private void LoadChiTietPhieuXuatRaSX(string maPhieuSX)
        {
            string query = @"
                            SELECT 
                                ctpsx.ID AS [ID],
                                hh.TenHangHoa AS [Tên hàng],
                                dvt.TenDVT AS[Đơn vị tính],
                                ctpsx.SoLuong AS [Số lượng],
                                ctpsx.DonGia AS [Đơn giá],
                                ctpsx.ThanhTien AS [Thành tiền],
                                k.TenKho AS [Tên Kho],
                                ctpsx.GhiChu AS [Ghi chú]
                            FROM ChiTietPhieuXuatRaSX ctpsx
                            JOIN HangHoa hh ON ctpsx.MaHangHoa = hh.MaHangHoa
                            JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                            JOIN Kho k ON ctpsx.MaKho = k.MaKho

                            WHERE ctpsx.MaPhieuXuatSX = @MaPhieuXuatSX";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuXuatSX", maPhieuSX);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTietSX.DataSource = dt;
                dgvChiTietSX.Columns["Số lượng"].DefaultCellStyle.Format = "N2";
                dgvChiTietSX.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
                dgvChiTietSX.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
            }
        }

        private void dgvPhieuXuatSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuXuatSX.Rows[e.RowIndex];

                maPhieuSX = row.Cells["Mã phiếu"].Value?.ToString();

                txtPhieuXuatSX.Text = maPhieuSX;
                dtmNgayXuat.Value = Convert.ToDateTime(row.Cells["Ngày xuất"].Value);
                txtLoaiXuatSX.Text = row.Cells["Loại xuất"].Value?.ToString();
                txtKH.Text = row.Cells["Số kế hoạch"].Value?.ToString();
                txtNhanvien.Text = row.Cells["Nhân viên"].Value?.ToString();
                txtGhiChuXuat.Text = row.Cells["Ghi chú"].Value?.ToString();
                LoadChiTietPhieuXuatRaSX(maPhieuSX);

                tabPhieuXuatSX.SelectedTab = tabChiTiet;


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhieuSX))
            {
                MessageBox.Show("Vui lòng chọn một phiếu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa phiếu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();


                        SqlCommand cmdChiTiet = new SqlCommand("DELETE FROM ChiTietPhieuXuatRaSX WHERE MaPhieuXuatSX = @MaPhieuXuatSX", conn);
                        cmdChiTiet.Parameters.AddWithValue("@MaPhieuXuatSX", maPhieuSX);
                        cmdChiTiet.ExecuteNonQuery();


                        SqlCommand cmdPhieu = new SqlCommand("DELETE FROM PhieuXuatRaSX WHERE MaPhieuXuatSX = @MaPhieuXuatSX", conn);
                        cmdPhieu.Parameters.AddWithValue("@MaPhieuXuatSX", maPhieuSX);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuSX();
                    dgvChiTietSX.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietSX.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng chi tiết để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idDuocChon = dgvChiTietSX.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietPhieuXuatRaSX WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", idDuocChon);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietPhieuXuatRaSX(maPhieuSX);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvChiTietSX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvChiTietSX.Rows[e.RowIndex];


                string idDuocChon = row.Cells["ID"].Value.ToString();


                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon);


                suaHangHoa.DaSuaHangHoaSanXuat += (s, args) =>
                {
                    LoadChiTietPhieuXuatRaSX(maPhieuSX);
                };

                suaHangHoa.Show();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            InPhieuXuatRaSX phieuXuatRaSX = new InPhieuXuatRaSX(maPhieuSX);
            phieuXuatRaSX.Show();
        }
    }
}
