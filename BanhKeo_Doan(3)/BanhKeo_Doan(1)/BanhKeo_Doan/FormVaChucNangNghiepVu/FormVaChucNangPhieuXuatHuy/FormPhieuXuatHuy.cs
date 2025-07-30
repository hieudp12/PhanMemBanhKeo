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
using BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuNhap;
namespace BanhKeo_Doan.FormVaChucNangNghiepVu.FormVaChucNangPhieuXuatHuy
{
    public partial class FormPhieuXuatHuy : Form
    {
        public FormPhieuXuatHuy()
        {
            InitializeComponent();
        }
        private string maPhieuHuy = "";
        private void btnThemPhieuXuatHuy_Click(object sender, EventArgs e)
        {
            ThemPhieuXuatHuy form = new ThemPhieuXuatHuy();
            form.DaThemPhieuPhieuXuatHuy += (s, args) => LoadPhieuXuatHuy();
            form.Show();
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            
            ThemHangHoa themHangHoa = new ThemHangHoa(maPhieuHuy);
            themHangHoa.DaThemHangHoaXuatHuy += (s, args) =>
            {
                LoadChiTietPhieuXuatHuy(maPhieuHuy);
                LoadPhieuXuatHuy();
            };
            themHangHoa.Show();
        }
       
        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHuy.CurrentRow != null)
            {

                string idDuocChon = dgvChiTietHuy.CurrentRow.Cells["ID"].Value.ToString();
                
                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon, maPhieuHuy);

                suaHangHoa.DaSuaHangHoaHuy += (s, args) =>
                {
                    LoadChiTietPhieuXuatHuy(maPhieuHuy);
                    LoadPhieuXuatHuy();
                };
                suaHangHoa.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private void LoadPhieuXuatHuy()
        {

            try
            {
                using (SqlConnection conn = KetNoiCSDL.GetConnection())
                {
                    conn.Open();


                    string updateTongTienQuery = @"
                                UPDATE PhieuXuatHuy
                                SET TongTien = (
                                    SELECT SUM(ThanhTien)
                                    FROM ChiTietPhieuXuatHuy
                                    WHERE ChiTietPhieuXuatHuy.MaPhieuXuatHuy = PhieuXuatHuy.MaPhieuXuatHuy)";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateTongTienQuery, conn))
                    {
                        cmdUpdate.ExecuteNonQuery();
                    }

                    string query = @"
                        SELECT 
                            pxh.MaPhieuXuatHuy AS [Mã phiếu hủy],
                            pxh.NgayXuatHuy AS [Ngày xuất hủy],
                            nv.TenNhanVien AS [Nhân viên],
                            pxh.TongTien AS [Tổng tiền],
                            k.TenKho AS [Tên kho],
                            pxh.GhiChu AS [Ghi chú]
                        FROM PhieuXuatHuy pxh
                        JOIN Kho k ON pxh.MaKho = k.MaKho
                        JOIN NhanVien nv ON pxh.MaNhanVien = nv.MaNhanVien"
                    ;


                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPhieuHuy.DataSource = dt;
                        dgvPhieuHuy.Columns["Tổng tiền"].DefaultCellStyle.Format = "N0";
                        dgvPhieuHuy.Columns["Ngày xuất hủy"].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        
        
            
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           

            if (ckbPhieuHuy.Checked && string.IsNullOrWhiteSpace(txtPhieuHuy.Text))
            {
                MessageBox.Show("Vui lòng nhập số phiếu cần tìm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = @"
                SELECT 
                    pxh.MaPhieuXuatHuy AS [Mã phiếu hủy],
                    pxh.NgayXuatHuy AS [Ngày xuất hủy],
                    nv.TenNhanVien AS [Nhân viên],
                    pxh.TongTien AS [Tổng tiền],
                    k.TenKho AS [Tên kho],
                    pxh.GhiChu AS [Ghi chú]
                FROM PhieuXuatHuy pxh
                JOIN Kho k ON pxh.MaKho = k.MaKho
                JOIN NhanVien nv ON pxh.MaNhanVien = nv.MaNhanVien
                WHERE 1=1";

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (ckbPhieuHuy.Checked)
            {
                string maPhieu = txtPhieuHuy.Text.Trim();
                if (string.IsNullOrEmpty(maPhieu))
                {
                    MessageBox.Show("Vui lòng nhập số phiếu cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                query += " AND pxh.MaPhieuXuatHuy LIKE @maPhieu";
                parameters.Add(new SqlParameter("@maPhieu", "%" + maPhieu + "%"));
            }


            if (ckbTheoNgay.Checked)
            {
                DateTime tuNgay = dtmTuNgay.Value.Date;
                DateTime denNgay = dtmDenNgay.Value.Date;

                query += " AND CAST(pxh.NgayXuatHuy AS DATE) BETWEEN @TuNgay AND @DenNgay";
                parameters.Add(new SqlParameter("@TuNgay", tuNgay));
                parameters.Add(new SqlParameter("@DenNgay", denNgay));
            }

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddRange(parameters.ToArray());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào.");
                }

                dgvPhieuHuy.DataSource = dt;
            }

        }

        private void FormPhieuXuatHuy_Load(object sender, EventArgs e)
        {
            LoadPhieuXuatHuy();
        }
        private void LoadChiTietPhieuXuatHuy(string maPhieuHuy)
        {
            string query = @"
                            SELECT 
                                ctpxh.ID AS [ID],
                                hh.TenHangHoa AS [Tên hàng],
                                dvt.TenDVT AS [Đơn vị tính],
                                ctpxh.SoLuong AS [Số lượng],
                                ctpxh.DonGia AS [Đơn giá],
                                ctpxh.ThanhTien AS [Thành tiền],
                                k.TenKho AS[Tên kho],
                                ctpxh.GhiChu AS [Ghi chú]
                            FROM ChiTietPhieuXuatHuy ctpxh
                            JOIN HangHoa hh ON ctpxh.MaHangHoa = hh.MaHangHoa
                            JOIN Kho k ON ctpxh.MaKho = k.MaKho
                            JOIN DonViTinh dvt ON hh.MaDVT = dvt.MaDVT
                            WHERE ctpxh.MaPhieuXuatHuy = @MaPhieuXuatHuy";

            using (SqlConnection conn = KetNoiCSDL.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhieuXuatHuy", maPhieuHuy);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvChiTietHuy.DataSource = dt;
                dgvChiTietHuy.Columns["Số lượng"].DefaultCellStyle.Format = "N2";
                dgvChiTietHuy.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
                dgvChiTietHuy.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
            }
        }
        private void dgvPhieuHuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuHuy.Rows[e.RowIndex];

                maPhieuHuy = row.Cells["Mã phiếu hủy"].Value?.ToString();

                txtSoPhieuHuy.Text = maPhieuHuy;
                dtmNgayHuy.Value = Convert.ToDateTime(row.Cells["Ngày xuất hủy"].Value);
                txtNhanVien.Text = row.Cells["Nhân viên"].Value?.ToString();
                txtTongTien.Text = row.Cells["Tổng tiền"].Value?.ToString();
                txtKho.Text = row.Cells["Tên kho"].Value?.ToString();
                txtGhiChu.Text = row.Cells["Ghi chú"].Value?.ToString();
                LoadChiTietPhieuXuatHuy(maPhieuHuy);

                tabPhieuHuy.SelectedTab = tabChiTietHuy;


            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maPhieuHuy))
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


                        SqlCommand cmdChiTiet = new SqlCommand("DELETE FROM ChiTietPhieuXuatHuy WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy", conn);
                        cmdChiTiet.Parameters.AddWithValue("@MaPhieuXuatHuy", maPhieuHuy);
                        cmdChiTiet.ExecuteNonQuery();


                        SqlCommand cmdPhieu = new SqlCommand("DELETE FROM PhieuXuatHuy WHERE MaPhieuXuatHuy = @MaPhieuXuatHuy", conn);
                        cmdPhieu.Parameters.AddWithValue("@MaPhieuXuatHuy", maPhieuHuy);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    MessageBox.Show("Xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhieuXuatHuy();
                    dgvChiTietHuy.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa phiếu chuyển: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHuy.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng chi tiết để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idDuocChon = dgvChiTietHuy.CurrentRow.Cells["ID"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = KetNoiCSDL.GetConnection())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM ChiTietPhieuXuatHuy WHERE ID = @ID", conn);
                        cmd.Parameters.AddWithValue("@ID", idDuocChon);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiTietPhieuXuatHuy(maPhieuHuy);
                    LoadPhieuXuatHuy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvChiTietHuy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvChiTietHuy.Rows[e.RowIndex];


                string idDuocChon = row.Cells["ID"].Value.ToString();

             
                SuaHangHoa suaHangHoa = new SuaHangHoa(idDuocChon, maPhieuHuy);


                suaHangHoa.DaSuaHangHoaHuy += (s, args) =>
                {
                    LoadChiTietPhieuXuatHuy(maPhieuHuy);
                };

                suaHangHoa.Show();
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            InPhieuXuatHuy phieuXuatHuy = new InPhieuXuatHuy(maPhieuHuy);
            phieuXuatHuy.Show();
        }
    }
}
