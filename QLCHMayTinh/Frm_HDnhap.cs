using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QLCHMayTinh
{
    public partial class Frm_HDnhap : Form
    {
        public event EventHandler HDNhapClosed;
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_HDnhap()
        {
            InitializeComponent();
            conn.Open();
        }
        private Form curFormChild;
        private void OpenChildFrm(Form Childform)
        {
            if (curFormChild != null)
            {
                curFormChild.Close();
            }
            curFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            pnCTHDNhap.Controls.Add(Childform);
            pnCTHDNhap.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }
        private void Frm_HDnhap_Load(object sender, EventArgs e)
        {
            LoaddgvPhieunhap();
            LoadcbbNhacc();
            LoadNVNhap();
        }

        void LoadcbbNhacc()
        {
            var ncc = new SqlCommand("select * from NHACUNGCAP", conn);
            var dr = ncc.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbNhacc.DisplayMember = "TEN";
            cbbNhacc.DataSource = dt;
            cbbNhacc.SelectedIndex = -1;
        }

        void LoadNVNhap()
        {
            var nv = new SqlCommand("SELECT * FROM NHANVIEN WHERE CHUCVU NOT IN (N'Bảo vệ', N'Nhân viên bán hàng')", conn);
            var dr = nv.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbNVnhap.DisplayMember = "HOTEN";
            cbbNVnhap.DataSource = dt;
            cbbNVnhap.SelectedIndex = -1;
            txtManv.Clear();
        }

        void LoaddgvPhieunhap()
        {
            string query = "SELECT * FROM PHIEUNHAP";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhieunhap.DataSource = dt;
        }

        private void ClearForm()
        {
            txtMapn.Clear();
            txtManv.Clear();
            cbbNhacc.SelectedIndex = -1;
            cbbNVnhap.SelectedIndex = -1; ;
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMapn.Text.Trim()))
            {
                MessageBox.Show("Mã phiếu nhập không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMapn.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtManv.Text.Trim()))
            {
                MessageBox.Show("Nhân viên nhập không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbNVnhap.Focus();
                return;
            }

            if (cbbNhacc.SelectedIndex == -1)
            {
                MessageBox.Show("Nhà cung cấp không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbNhacc.Focus();
                return;
            }

            string query = "SELECT * FROM NHACUNGCAP WHERE TEN = @TEN";
            string manhacc = null;
            if (cbbNhacc.SelectedIndex != -1)
            {
                try
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN", cbbNhacc.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                manhacc = reader["MANCC"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhà cung cấp");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            int tongtien = 0;
            int manv = Convert.ToInt32(txtManv.Text.Trim());
            int mapn = Convert.ToInt32(txtMapn.Text.Trim());
            int nhacc = Convert.ToInt32(manhacc);
            DateTime ngaynhap = DateTime.Parse(txtNgaynhap.Text);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PHIEUNHAP VALUES (@maPN, @ngayNhap, @mancc, @manvnhap, @tongTien)", conn);
                cmd.Parameters.AddWithValue("@maPN", mapn);
                cmd.Parameters.AddWithValue("@ngayNhap", ngaynhap);
                cmd.Parameters.AddWithValue("@mancc", nhacc);
                cmd.Parameters.AddWithValue("@manvnhap", manv);
                cmd.Parameters.AddWithValue("@tongTien", tongtien);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvPhieunhap();
            ClearForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
            if (HDNhapClosed != null)
            {
                HDNhapClosed(this, EventArgs.Empty);
            }
        }

        private void cbbNVnhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN WHERE HOTEN = @TEN";

            if (cbbNVnhap.SelectedIndex != -1)
            {
                try
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN", cbbNVnhap.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtManv.Text = reader["MANV"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvPhieunhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            txtMapn.Text = dgvPhieunhap.Rows[dong].Cells["MAPN"].Value.ToString();
            txtNgaynhap.Text = dgvPhieunhap.Rows[dong].Cells["NGAYNHAP"].Value.ToString();
            txtManv.Text = dgvPhieunhap.Rows[dong].Cells["MANVNHAP"].Value.ToString();


            // Lấy tên NCC từ datagridview
            string ncc = dgvPhieunhap.Rows[dong].Cells["NHACUNGCAP"].Value.ToString();
            string query = "SELECT TEN FROM NHACUNGCAP WHERE MANCC = @maNcc";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@maNcc", ncc);
            SqlDataAdapter da = new SqlDataAdapter(com);
            // Tạo StringBuilder để gộp dữ liệu
            StringBuilder tenncc = new StringBuilder();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                tenncc.Append(row["TEN"].ToString());
                tenncc.Append(", ");
            }

            if (tenncc.Length > 0)
            {
                tenncc.Remove(tenncc.Length - 2, 2);
            }
            string x = tenncc.ToString();
            int index = cbbNhacc.FindString(x);
            if (index != -1)
            {
                cbbNhacc.SelectedIndex = index;
            }

            // Lấy mã nhà cung cấp từ datagridview
            string manv = txtManv.Text;
            string queryz = "SELECT HOTEN FROM NHANVIEN WHERE MANV = @maNV";
            SqlCommand comz = new SqlCommand(queryz, conn);
            comz.CommandType = CommandType.Text;
            comz.Parameters.AddWithValue("@maNV", manv);
            SqlDataAdapter daz = new SqlDataAdapter(comz);
            // Tạo StringBuilder để gộp dữ liệu
            StringBuilder tennv = new StringBuilder();
            DataTable dtz = new DataTable();
            daz.Fill(dtz);
            foreach (DataRow row in dtz.Rows)
            {
                tennv.Append(row["HOTEN"].ToString());
                tennv.Append(", ");
            }

            if (tennv.Length > 0)
            {
                tennv.Remove(tennv.Length - 2, 2);
            }
            string y = tennv.ToString();
            int indexz = cbbNVnhap.FindString(y);
            cbbNVnhap.SelectedIndex = indexz;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mapn = Convert.ToInt32(txtMapn.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM PHIEUNHAP WHERE MAPN = {mapn}", conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvPhieunhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            pnCTHDNhap.Visible = true;
            Frm_CTHDNhap cthdn = new Frm_CTHDNhap();
            OpenChildFrm(cthdn);
            cthdn.CTHDNhapClosed += CTHDNhapClosedHandler;
        }
        
        private void CTHDNhapClosedHandler(object sender, EventArgs e)
        {
            pnCTHDNhap.Visible = false;
        }
    }
}
