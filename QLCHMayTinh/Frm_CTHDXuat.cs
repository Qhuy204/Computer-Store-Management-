using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMayTinh
{
    public partial class Frm_CTHDXuat : Form
    {
        public event EventHandler CTHDXuatClosed;
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_CTHDXuat()
        {
            InitializeComponent();
            conn.Open();
            LoaddgvCTPX();
            ClearForm();
        }

        void ClearForm()
        {
            cbbMapx.SelectedIndex = -1;
            txtmactpx.Clear();
            cbbTensp.SelectedIndex = -1;
            txtMasp.Clear();
            txtSoluong.Clear();
            txtgiaban.Clear();
        }

        private void Frm_CTHDXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet5.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLCT_MAYTINHDataSet5.SANPHAM);
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet4.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.pHIEUXUATTableAdapter.Fill(this.qLCT_MAYTINHDataSet4.PHIEUXUAT);
            LoadMaCTPX();
            ClearForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CTHDXuatClosed != null)
            {
                CTHDXuatClosed(this, EventArgs.Empty);
            }
        }

        void LoaddgvCTPX()
        {
            string query = "SELECT * FROM CTPHIEUXUAT";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCthdx.DataSource = dt;
        }

        void LoadMaCTPX()
        {
            var nv = new SqlCommand("SELECT * FROM PHIEUXUAT", conn);
            var dr = nv.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMapx.DisplayMember = "MAPX";
            cbbMapx.DataSource = dt;
            cbbMapx.SelectedIndex = -1;
        }

        private void cbbTensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SANPHAM WHERE TENSP = @TEN";

            if (cbbTensp.SelectedIndex != -1)
            {
                try
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN", cbbTensp.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtMasp.Text = reader["MASP"].ToString();
                                txtgiaban.Text = reader["GIA"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy SP");
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
            if (cbbMapx.SelectedIndex == -1)
            {
                MessageBox.Show("Mã phiếu xuất không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMapx.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtmactpx.Text.Trim()))
            {
                MessageBox.Show("Mã CTPX không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmactpx.Focus();
                return;
            }

            if (cbbTensp.SelectedIndex == -1)
            {
                MessageBox.Show("Sản phẩm không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbTensp.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSoluong.Text.Trim()))
            {
                MessageBox.Show("Số lượng không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtgiaban.Text.Trim()))
            {
                MessageBox.Show("Giá bán không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbTensp.Focus();
                return;
            }


            int mapx = Convert.ToInt32(cbbMapx.Text.Trim());
            int mactpx = Convert.ToInt32(txtmactpx.Text.Trim());
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            int soluong = Convert.ToInt32(txtSoluong.Text.Trim());
            int giaban = Convert.ToInt32(txtgiaban.Text.Trim());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CTPHIEUXUAT VALUES (@mactPX, @maPX, @maSP, @sl, @giaBan)", conn);
                cmd.Parameters.AddWithValue("@mactPX", mactpx);
                cmd.Parameters.AddWithValue("@maPX", mapx);
                cmd.Parameters.AddWithValue("@maSP", masp);
                cmd.Parameters.AddWithValue("@sl", soluong);
                cmd.Parameters.AddWithValue("@giaBan", giaban);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn bán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvCTPX();
            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mactpx = Convert.ToInt32(txtmactpx.Text.Trim());
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            int soluong = Convert.ToInt32(txtSoluong.Text.Trim());
            int giaban = Convert.ToInt32(txtgiaban.Text.Trim());

            string sql = $"UPDATE CTPHIEUXUAT SET MASP = {masp}, SOLUONG = {soluong}, GIABAN = {giaban} WHERE MACTPX = {mactpx}";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvCTPX();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mactpx = Convert.ToInt32(txtmactpx.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM CTPHIEUXUAT WHERE MACTPX = {mactpx}", conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa CT phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvCTPX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
