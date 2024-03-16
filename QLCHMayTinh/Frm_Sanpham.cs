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

namespace QLCHMayTinh
{
    public partial class Frm_Sanpham : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recPnl1;
        private Rectangle recRdo1;
        public Frm_Sanpham()
        {
            InitializeComponent();
            conn.Open();
        }

        void LoadccbDanhmucSP()
        {
            var dmsp = new SqlCommand("select * from DANHMUCSP", conn);
            var dr = dmsp.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbDanhmucSP.DisplayMember = "TENDMUC";
            cbbDanhmucSP.DataSource = dt;
        }

        void LoadccbNcc()
        {
            var ncc = new SqlCommand("select * from NHACUNGCAP", conn);
            var dr = ncc.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbNcc.DisplayMember = "TEN";
            cbbNcc.DataSource = dt;
        }

        void LoaddgvDSsanpham()
        {
            string query = "SELECT MADMUC, MASP, TENSP, DVT, GIA, MANHACC FROM SANPHAM";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDSsanpham.DataSource = dt;
        }

        private void cbbNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHACUNGCAP WHERE TEN = @TEN";

            if (cbbNcc.SelectedIndex != -1)
            {
                try
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN", cbbNcc.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtmancc.Text = reader["MANCC"].ToString();
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
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            #region Validate input

            if (string.IsNullOrEmpty(txtMasp.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTensp.Text.Trim()))
            {
                MessageBox.Show("Tên sản phẩm không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTensp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtGiaban.Text.Trim()))
            {
                MessageBox.Show("Giá bán không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaban.Focus();
                return;
            }

            decimal gia;
            if (!decimal.TryParse(txtGiaban.Text.Trim(), out gia))
            {
                MessageBox.Show("Giá bán không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaban.Focus();
                return;
            }

            if (cbbDanhmucSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbDanhmucSP.Focus();
                return;
            }

            if (cbbNcc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbNcc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDVtinh.Text.Trim()))
            {
                MessageBox.Show("Đơn vị tính không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDVtinh.Focus();
                return;
            }

            #endregion

            int madmuc = GetMadmuc();
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            string tensp = txtTensp.Text.Trim();
            string dvt = txtDVtinh.Text.Trim();
            int nhaccap = Convert.ToInt32(txtmancc.Text.Trim());
            try
            {
                SqlCommand cmd = new SqlCommand("EXEC ThemSanPham @MADMUC, @MASP, @TENSP, @DVT, @GIA, @MANHACCAP", conn);
                cmd.Parameters.AddWithValue("@MASP", masp);
                cmd.Parameters.AddWithValue("@MADMUC", madmuc);
                cmd.Parameters.AddWithValue("@TENSP", tensp);
                cmd.Parameters.AddWithValue("@DVT", dvt);
                cmd.Parameters.AddWithValue("@GIA", gia);
                cmd.Parameters.AddWithValue("@MANHACCAP", nhaccap);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvDSsanpham();
        }

        private void ClearForm()
        {
            txtMasp.Clear();
            txtTensp.Clear();
            txtGiaban.Clear();
            txtDVtinh.Clear();
            txtmancc.Clear();
            cbbDanhmucSP.ResetText();
            cbbNcc.ResetText();
        }

        public int GetMadmuc()
        {
            string tendmuc = cbbDanhmucSP.Text;
            string query = "SELECT MADMUC FROM DANHMUCSP WHERE TENDMUC = @tenDmuc";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@tenDmuc", tendmuc);
            SqlDataAdapter da = new SqlDataAdapter(com);
            // Tạo StringBuilder để gộp dữ liệu
            StringBuilder maDmuc = new StringBuilder();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                maDmuc.Append(row["MADMUC"].ToString());
                maDmuc.Append(", ");
            }

            if (maDmuc.Length > 0)
            {
                maDmuc.Remove(maDmuc.Length - 2, 2);
            }
            int madmuc = Convert.ToInt32(maDmuc.ToString());
            return madmuc;
        }

        private void dgvDSsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            txtMasp.Text = dgvDSsanpham.Rows[dong].Cells["MASP"].Value.ToString();
            txtTensp.Text = dgvDSsanpham.Rows[dong].Cells["TENSP"].Value.ToString();
            txtGiaban.Text = dgvDSsanpham.Rows[dong].Cells["GIA"].Value.ToString();
            txtDVtinh.Text = dgvDSsanpham.Rows[dong].Cells["DVT"].Value.ToString();
            txtmancc.Text = dgvDSsanpham.Rows[dong].Cells["MANHACC"].Value.ToString();

            // Lấy mã danh mục từ datagridview
            string madmuc = dgvDSsanpham.Rows[dong].Cells["MADMUC"].Value.ToString();
            string query = "SELECT TENDMUC FROM DANHMUCSP WHERE MADMUC = @maDmuc";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@maDmuc", madmuc);
            SqlDataAdapter da = new SqlDataAdapter(com);
            // Tạo StringBuilder để gộp dữ liệu
            StringBuilder tendmuc = new StringBuilder();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                tendmuc.Append(row["TENDMUC"].ToString());
                tendmuc.Append(", ");
            }

            if (tendmuc.Length > 0)
            {
                tendmuc.Remove(tendmuc.Length - 2, 2);
            }
            string x = tendmuc.ToString();
            int index = cbbDanhmucSP.FindString(x);
            if (index != -1)
            {
                cbbDanhmucSP.SelectedIndex = index;
            }

            // Lấy mã nhà cung cấp từ datagridview
            string mancc = txtmancc.Text;
            string queryz = "SELECT TEN FROM NHACUNGCAP WHERE MANCC = @maNhacc";
            SqlCommand comz = new SqlCommand(queryz, conn);
            comz.CommandType = CommandType.Text;
            comz.Parameters.AddWithValue("@maNhacc", mancc);
            SqlDataAdapter daz = new SqlDataAdapter(comz);
            // Tạo StringBuilder để gộp dữ liệu
            StringBuilder TenNcc = new StringBuilder();
            DataTable dtz = new DataTable();
            daz.Fill(dtz);
            foreach (DataRow row in dtz.Rows)
            {
                TenNcc.Append(row["TEN"].ToString());
                TenNcc.Append(", ");
            }

            if (TenNcc.Length > 0)
            {
                TenNcc.Remove(TenNcc.Length - 2, 2);
            }
            string y = TenNcc.ToString();
            int indexz = cbbNcc.FindString(y);
            if (indexz != -1)
            {
                cbbNcc.SelectedIndex = indexz;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int masp = Convert.ToInt32(txtMasp.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand("XoaSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MASP", masp);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvDSsanpham();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int madmuc = GetMadmuc();
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            string tensp = txtTensp.Text.Trim();
            string dvt = txtDVtinh.Text.Trim(); ;
            int gia = Convert.ToInt32(txtGiaban.Text.Trim());
            int sltonkho;
            int manhaccap = Convert.ToInt32(txtmancc.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand("CapNhatSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MADMUC", madmuc);
                cmd.Parameters.AddWithValue("@MASP", masp);
                cmd.Parameters.AddWithValue("@TENSP", tensp);
                cmd.Parameters.AddWithValue("@DVT", dvt);
                cmd.Parameters.AddWithValue("@GIA", gia);
                cmd.Parameters.AddWithValue("@SLTONKHO", DBNull.Value);
                cmd.Parameters.AddWithValue("@MANHACCAP", manhaccap);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvDSsanpham();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 50001:
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Frm_Sanpham_Load(object sender, EventArgs e)
        {
            LoadccbDanhmucSP();
            LoadccbNcc();
            LoaddgvDSsanpham();
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width),
            Convert.ToInt32(0.5 * workingRectangle.Height));         
            this.Location = new System.Drawing.Point(10, 10);
            cbbDanhmucSP.SelectedIndex = -1;
            cbbNcc.SelectedIndex = -1;
        }
    }
}
