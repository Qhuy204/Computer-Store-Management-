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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLCHMayTinh
{
    public partial class Frm_Nhanvien : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_Nhanvien()
        {
            InitializeComponent();
            conn.Open();
        }

        private void ClearForm()
        {
            txtmanv.Clear();
            txtten.Clear();
            txtNgayblam.ResetText();
            txtngaysinh.ResetText();
            txtdiachi.Clear();
            txtdt.Clear();
            cbbChucvu.SelectedIndex = -1;
            cbbgt.SelectedIndex = -1;
        }

        void LoadcbbChucvu()
        {
            var cvu = new SqlCommand("select * from CHUCVU", conn);
            var dr = cvu.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbChucvu.DisplayMember = "TENCVU";
            cbbChucvu.DataSource = dt;
        }

        void LoaddgvNhanvien()
        {
            string query = "SELECT * FROM NHANVIEN";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDSNV.DataSource = dt;
        }

        private void Frm_Nhanvien_Load(object sender, EventArgs e)
        {
            LoadcbbChucvu();
            LoaddgvNhanvien();
            cbbChucvu.SelectedIndex = -1;
            cbbgt.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmanv.Text.Trim()))
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtten.Text.Trim()))
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtten.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdt.Focus();
                return;
            }

            if (cbbgt.SelectedIndex == -1)
            {
                MessageBox.Show("Giới tính không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbgt.Focus();
                return;
            }

            if (cbbChucvu.SelectedIndex == -1)
            {
                MessageBox.Show("Chức vụ không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbChucvu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtdiachi.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtngaysinh.Text.Trim()))
            {
                MessageBox.Show("Ngày sinh không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNgayblam.Text.Trim()))
            {
                MessageBox.Show("Ngày bắt đầu làm không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgayblam.Focus();
                return;
            }


            int manv = Convert.ToInt32(txtmanv.Text.Trim());
            string hoten= txtten.Text.Trim();
            string sodt = txtdt.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string chucvu = cbbChucvu.Text.Trim();
            string gtinh = cbbgt.Text.Trim();
            DateTime nsinh = DateTime.Parse(txtngaysinh.Text);
            DateTime nbdlam = DateTime.Parse(txtNgayblam.Text);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIEN VALUES (@maNV, @tenNV, @nSinh, @gTinh, @soDT, @dChi, @cVu, @ngayBDlam)", conn);
                cmd.Parameters.AddWithValue("@maNV", manv);
                cmd.Parameters.AddWithValue("@tenNV", hoten);
                cmd.Parameters.AddWithValue("@nSinh", nsinh);
                cmd.Parameters.AddWithValue("@gTinh", gtinh);
                cmd.Parameters.AddWithValue("@soDT", sodt);
                cmd.Parameters.AddWithValue("@dChi", diachi);
                cmd.Parameters.AddWithValue("@cVu", chucvu);
                cmd.Parameters.AddWithValue("@ngayBDlam", nbdlam);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvNhanvien();
            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int manv = Convert.ToInt32(txtmanv.Text.Trim());
            string hoten = txtten.Text.Trim();
            string sodt = txtdt.Text.Trim();
            string diachi = txtdiachi.Text.Trim();
            string chucvu = cbbChucvu.Text.Trim();
            string gtinh = cbbgt.Text.Trim();
            DateTime nsinh = DateTime.Parse(txtngaysinh.Text);
            DateTime nbdlam = DateTime.Parse(txtNgayblam.Text);

            string sql = $"UPDATE NHANVIEN SET MANV = {manv}, HOTEN = N'{hoten}', NSINH = '{nsinh}', GTINH = N'{gtinh}', SODT = N'{sodt}', DCHI = N'{diachi}', CHUCVU = N'{chucvu}', NGAYBDLAM = N'{nbdlam}' WHERE MANV = {manv}";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvNhanvien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmanv.Text.Trim(), out int manv))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV = @maNv", conn))
                {
                    cmd.Parameters.AddWithValue("@maNv", manv);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvNhanvien();
            ClearForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            txtmanv.Text = dgvDSNV.Rows[dong].Cells["MANV"].Value.ToString();
            txtten.Text = dgvDSNV.Rows[dong].Cells["HOTEN"].Value.ToString();
            txtngaysinh.Text = dgvDSNV.Rows[dong].Cells["NSINH"].Value.ToString();
            txtdt.Text = dgvDSNV.Rows[dong].Cells["SODT"].Value.ToString();
            txtdiachi.Text = dgvDSNV.Rows[dong].Cells["DCHI"].Value.ToString();
            txtNgayblam.Text = dgvDSNV.Rows[dong].Cells["NGAYBDLAM"].Value.ToString();
            string gtinh = dgvDSNV.Rows[dong].Cells["GTINH"].Value.ToString();
            int index1 = cbbgt.FindString(gtinh);
            if (index1 != -1)
            {
                cbbgt.SelectedIndex = index1;
            }
            string chucvu = dgvDSNV.Rows[dong].Cells["CHUCVU"].Value.ToString();
            int index2 = cbbChucvu.FindString(chucvu);
            if (index2 != -1)
            {
                cbbChucvu.SelectedIndex = index2;
            }
        }
    }
}
