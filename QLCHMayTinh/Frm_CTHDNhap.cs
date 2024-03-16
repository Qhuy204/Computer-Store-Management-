using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLCHMayTinh
{
    public partial class Frm_CTHDNhap : Form
    {
        public event EventHandler CTHDNhapClosed;
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_CTHDNhap()
        {
            InitializeComponent();
            conn.Open();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CTHDNhapClosed != null)
            {
                CTHDNhapClosed(this, EventArgs.Empty);
            }
        }

        private void ClearForm()
        {
            cbbMapn.SelectedIndex = -1;
            txtmactpn.Clear();
            cbbTensp.SelectedIndex = -1;
            txtMasp.Clear();
            txtSoluong.Clear();
            txtGianhap.Clear();
        }

        void LoadMaPN()
        {
            var nv = new SqlCommand("SELECT * FROM PHIEUNHAP", conn);
            var dr = nv.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbMapn.DisplayMember = "MAPN";
            cbbMapn.DataSource = dt;
            cbbMapn.SelectedIndex = -1;
        }

        void LoaddgvCthdn()
        {
            string query = "SELECT * FROM CTPHIEUNHAP";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCthdn.DataSource = dt;
        }

        private void Frm_CTHDNhap_Load(object sender, EventArgs e)
        {
            LoadMaPN();
            LoaddgvCthdn();
            txtMasp.Clear();
        }

        private void cbbMapn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mancc = 0;
            int? mapn = null;
            if (!string.IsNullOrEmpty(cbbMapn.Text))
            {
                mapn = Convert.ToInt32(cbbMapn.Text);
            }
            string query = $"SELECT * FROM PHIEUNHAP WHERE MAPN = @Mapn";

            if (cbbMapn.SelectedIndex != -1)
            {
                try
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mapn", mapn);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                mancc = Convert.ToInt32(reader["NHACUNGCAP"]);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            var nv = new SqlCommand($"SELECT * FROM SANPHAM WHERE MANHACC = {mancc}", conn);
            var dr = nv.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbTensp.DisplayMember = "TENSP";
            cbbTensp.DataSource = dt;
            cbbTensp.SelectedIndex = -1;
            txtMasp.Clear();
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
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy mã SP");
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

        private void dgvCthdn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            cbbMapn.Text = dgvCthdn.Rows[dong].Cells["MAPN"].Value.ToString();
            txtmactpn.Text = dgvCthdn.Rows[dong].Cells["MACTPN"].Value.ToString();
            txtSoluong.Text = dgvCthdn.Rows[dong].Cells["SOLUONG"].Value.ToString();
            txtGianhap.Text = dgvCthdn.Rows[dong].Cells["GIANHAP"].Value.ToString();
            txtMasp.Text = dgvCthdn.Rows[dong].Cells["MASP"].Value.ToString();

            // Lấy Tên SP
            string masp = dgvCthdn.Rows[dong].Cells["MASP"].Value.ToString();
            string query = "SELECT TENSP FROM SANPHAM WHERE MASP = @maSP";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@maSP", masp);
            SqlDataAdapter da = new SqlDataAdapter(com);
            StringBuilder tensp = new StringBuilder();
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                tensp.Append(row["TENSP"].ToString());
                tensp.Append(", ");
            }

            if (tensp.Length > 0)
            {
                tensp.Remove(tensp.Length - 2, 2);
            }
            string x = tensp.ToString();
            int index = cbbTensp.FindString(x);
            if (index != -1)
            {
                cbbTensp.SelectedIndex = index;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbMapn.SelectedIndex == -1)
            {
                MessageBox.Show("Mã phiếu nhập không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbMapn.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtmactpn.Text.Trim()))
            {
                MessageBox.Show("Mã CTPN không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmactpn.Focus();
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

            if (string.IsNullOrEmpty(txtGianhap.Text.Trim()))
            {
                MessageBox.Show("Giá nhập không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGianhap.Focus();
                return;
            }


            int mapn = Convert.ToInt32(cbbMapn.Text.Trim()); 
            int mactpn = Convert.ToInt32(txtmactpn.Text.Trim());
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            int soluong = Convert.ToInt32(txtSoluong.Text.Trim());
            int gianhap = Convert.ToInt32(txtGianhap.Text.Trim());
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CTPHIEUNHAP VALUES (@mactPN, @maPN, @maSP, @sl, @giaNhap)", conn);
                cmd.Parameters.AddWithValue("@mactPN", mactpn);
                cmd.Parameters.AddWithValue("@maPN", mapn);
                cmd.Parameters.AddWithValue("@maSP", masp);
                cmd.Parameters.AddWithValue("@sl", soluong);
                cmd.Parameters.AddWithValue("@giaNhap", gianhap);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvCthdn();
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mactpn = Convert.ToInt32(txtmactpn.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM CTPHIEUNHAP WHERE MACTPN = {mactpn}", conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa CT phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvCthdn();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mactpn = Convert.ToInt32(txtmactpn.Text.Trim());
            int masp = Convert.ToInt32(txtMasp.Text.Trim());
            int soluong = Convert.ToInt32(txtSoluong.Text.Trim());
            int gianhap = Convert.ToInt32(txtGianhap.Text.Trim());

            string sql = $"UPDATE CTPHIEUNHAP SET MASP = {masp}, SOLUONG = {soluong}, GIANHAP = {gianhap} WHERE MACTPN = {mactpn}";
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvCthdn();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
