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
    public partial class Frm_Khachhang : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_Khachhang()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ClearForm()
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtngaysinh.ResetText();
            txtdchi.Clear();
            txtSdt.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmakh.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakh.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txttenkh.Text.Trim()))
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkh.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtdchi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtngaysinh.Text.Trim()))
            {
                MessageBox.Show("Ngày sinh không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngaysinh.Focus();
                return;
            }


            int makh = Convert.ToInt32(txtmakh.Text.Trim());
            string hoten = txttenkh.Text.Trim();
            string sodt = txtSdt.Text.Trim();
            string diachi = txtdchi.Text.Trim();
            DateTime nsinh = DateTime.Parse(txtngaysinh.Text);
            try
            {
                SqlCommand cmd = new SqlCommand($"EXEC ThemKhachHang {makh}, N'{hoten}', N'{diachi}', '{sodt}','{nsinh}'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvKhachhang();
        }

        void LoaddgvKhachhang()
        {
            string query = "SELECT * FROM KHACHHANG";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachhang.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Frm_Khachhang_Load(object sender, EventArgs e)
        {
            LoaddgvKhachhang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmakh.Text.Trim(), out int makh))
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("EXEC XoaKhachHang @maKh", conn))
                {
                    cmd.Parameters.AddWithValue("@maKh", makh);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvKhachhang();
            ClearForm();
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            txtmakh.Text = dgvKhachhang.Rows[dong].Cells["MAKH"].Value.ToString();
            txttenkh.Text = dgvKhachhang.Rows[dong].Cells["HOTEN"].Value.ToString();
            txtdchi.Text = dgvKhachhang.Rows[dong].Cells["DCHI"].Value.ToString();
            txtSdt.Text = dgvKhachhang.Rows[dong].Cells["SODT"].Value.ToString();
            txtngaysinh.Text = dgvKhachhang.Rows[dong].Cells["NSINH"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int makh = Convert.ToInt32(txtmakh.Text.Trim());
            string hoten = txttenkh.Text.Trim();
            string sodt = txtSdt.Text.Trim();
            string diachi = txtdchi.Text.Trim();
            DateTime nsinh = DateTime.Parse(txtngaysinh.Text);

            string sql = $"EXEC CapNhatKhachHang {makh}, N'{hoten}', '{nsinh}', N'{diachi}', N'{sodt}'";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvKhachhang();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
