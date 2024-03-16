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
    public partial class Frm_Nhacungcap : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");

        public Frm_Nhacungcap()
        {
            InitializeComponent();
            conn.Open();
        }

        void LoaddgvDSNhacc()
        {
            string query = "SELECT * FROM NHACUNGCAP";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDSNhacc.DataSource = dt;
        }

        private void btnResetNcc_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            TxtManhacc.Clear();
            TxtTenncc.Clear();
            txtemail.Clear();
            txtdchincc.Clear();
            txtSdt.Clear();
        }

        private void btnThemNcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtManhacc.Text.Trim()))
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtManhacc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(TxtTenncc.Text.Trim()))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtTenncc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtdchincc.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ nhà cung cấp không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdchincc.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                MessageBox.Show("Email không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }

            int mancc = Convert.ToInt32(TxtManhacc.Text.Trim());
            string tenncc = TxtTenncc.Text.Trim();
            string sodt = txtSdt.Text.Trim();
            string diachi = txtdchincc.Text.Trim();
            string email = txtemail.Text.Trim();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NHACUNGCAP VALUES (@maNcc, @tenNcc, @soDt, @diaChi, @eMail)", conn);
                cmd.Parameters.AddWithValue("@maNcc", mancc);
                cmd.Parameters.AddWithValue("@tenNcc", tenncc);
                cmd.Parameters.AddWithValue("@soDt", sodt);
                cmd.Parameters.AddWithValue("@diaChi", diachi);
                cmd.Parameters.AddWithValue("@eMail", email);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvDSNhacc();
            ClearForm();
        }

        private void btnXoaNcc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtManhacc.Text.Trim(), out int mancc))
            {
                MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM NHACUNGCAP WHERE MANCC = @maNcc", conn))
                {
                    cmd.Parameters.AddWithValue("@maNcc", mancc);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddgvDSNhacc();
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 547:
                        MessageBox.Show("Nhà cung cấp này đang được sử dụng bởi các sản phẩm khác. Vui lòng xóa các sản phẩm liên quan trước khi xóa nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            LoaddgvDSNhacc();
            ClearForm();
        }


        private void dgvDSNhacc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            TxtManhacc.Text = dgvDSNhacc.Rows[dong].Cells["MANCC"].Value.ToString();
            TxtTenncc.Text = dgvDSNhacc.Rows[dong].Cells["TEN"].Value.ToString();
            txtSdt.Text = dgvDSNhacc.Rows[dong].Cells["SODT"].Value.ToString();
            txtdchincc.Text = dgvDSNhacc.Rows[dong].Cells["DCHI"].Value.ToString();
            txtemail.Text = dgvDSNhacc.Rows[dong].Cells["EMAIL"].Value.ToString();
        }

        private void btnSuaNcc_Click(object sender, EventArgs e)
        {
            int mancc = Convert.ToInt32(TxtManhacc.Text.Trim()); ;
            string tenncc = TxtTenncc.Text.Trim();
            string sdt = txtSdt.Text.Trim(); ;
            string diachi = txtdchincc.Text.Trim(); ;
            string email = txtemail.Text.Trim(); ;

            string sql = $"UPDATE NHACUNGCAP SET MANCC = {mancc}, TEN = N'{tenncc}', SODT = '{sdt}', DCHI = N'{diachi}', EMAIL = N'{email}' WHERE MANCC = {mancc}";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvDSNhacc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Nhacungcap_Load(object sender, EventArgs e)
        {
            LoaddgvDSNhacc();
        }
    }
}
