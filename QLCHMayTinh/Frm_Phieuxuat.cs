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
    public partial class Frm_Phieuxuat : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_Phieuxuat()
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
            pnCTHDX.Controls.Add(Childform);
            pnCTHDX.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }

        private void Frm_Phieuxuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLCT_MAYTINHDataSet2.NHANVIEN);
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qLCT_MAYTINHDataSet1.KHACHHANG);
            // TODO: This line of code loads data into the 'qLCT_MAYTINH_DTS_ForPTTT.PTTHANHTOAN' table. You can move, or remove it, as needed.
            this.pTTHANHTOANTableAdapter.Fill(this.qLCT_MAYTINH_DTS_ForPTTT.PTTHANHTOAN);
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet_forPTMuahang.PTMUAHANG' table. You can move, or remove it, as needed.
            this.pTMUAHANGTableAdapter1.Fill(this.qLCT_MAYTINHDataSet_forPTMuahang.PTMUAHANG);
            // TODO: This line of code loads data into the 'qLCT_MAYTINHDataSet.PTMUAHANG' table. You can move, or remove it, as needed.
            this.pTMUAHANGTableAdapter.Fill(this.qLCT_MAYTINHDataSet.PTMUAHANG);
            LoaddgvPhieuxuat();
            LoadcbbNV();
            ClearForm();
        }

        void ClearForm()
        {
            txtmapx.Clear();
            txtngayban.ResetText();
            cbbkhachhang.SelectedIndex = -1;
            cbbmanv.SelectedIndex = -1;
            cbbPTmuahang.SelectedIndex = -1;
            cbbPTTT.SelectedIndex = -1;
            txtTrangthai.Clear();
        }

        void LoaddgvPhieuxuat()
        {
            string query = "SELECT * FROM PHIEUXUAT";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPhieuxuat.DataSource = dt;
        }

        void LoadcbbNV()
        {
            var nv = new SqlCommand("SELECT MANV, HOTEN FROM dbo.NHANVIEN WHERE CHUCVU NOT IN (N'Bảo vệ', N'Nhân viên kho')", conn);
            var dr = nv.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbbmanv.DisplayMember = "MANV";
            cbbmanv.DataSource = dt;
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmapx.Text.Trim()))
            {
                MessageBox.Show("Mã phiếu xuất không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmapx.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtngayban.Text.Trim()))
            {
                MessageBox.Show("Ngày bán không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtngayban.Focus();
                return;
            }

            if (cbbkhachhang.SelectedIndex == -1)
            {
                MessageBox.Show("Khách hàng không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbkhachhang.Focus();
                return;
            }

            if (cbbmanv.SelectedIndex == -1)
            {
                MessageBox.Show("Mã NV không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbmanv.Focus();
                return;
            }

            if (cbbPTmuahang.SelectedIndex == -1)
            {
                MessageBox.Show("PT mua hàng không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPTmuahang.Focus();
                return;
            }

            if (cbbPTTT.SelectedIndex == -1)
            {
                MessageBox.Show("PT thanh toán không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPTTT.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTrangthai.Text.Trim()))
            {
                MessageBox.Show("Trạng thái không được để trống", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrangthai.Focus();
                return;
            }


            int mapx = Convert.ToInt32(txtmapx.Text.Trim());
            int makh = Convert.ToInt32(cbbkhachhang.Text.Trim());
            int manv = Convert.ToInt32(cbbmanv.Text.Trim());
            int mapttt = Convert.ToInt32(cbbPTTT.Text.Trim());
            int maptmh = Convert.ToInt32(cbbPTmuahang.Text.Trim());
            DateTime ngayban = DateTime.Parse(txtngayban.Text);
            string trangthai = txtTrangthai.Text.Trim();
            try
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO PHIEUXUAT VALUES ({mapx}, '{ngayban}', {makh}, {manv}, 0, {maptmh}, {mapttt}, N'{trangthai}')", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn bán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoaddgvPhieuxuat();
            ClearForm();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            pnCTHDX.Visible = true;
            Frm_CTHDXuat cthdx = new Frm_CTHDXuat();
            OpenChildFrm(cthdx);
            cthdx.CTHDXuatClosed += CTHDXuatClosedHandler;

        }

        private void CTHDXuatClosedHandler(object sender, EventArgs e)
        {
            pnCTHDX.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mapx = Convert.ToInt32(txtmapx.Text.Trim());

            try
            {
                SqlCommand cmd = new SqlCommand($"DELETE FROM PHIEUXUAT WHERE MAPX = {mapx}", conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvPhieuxuat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();
        }

        private void dgvPhieuxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
