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

namespace QLCHMayTinh
{
    public partial class Frm_Khohang : Form
    {
        public event EventHandler KhoHangClosed;
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_Khohang()
        {
            InitializeComponent();
            conn.Open();
            LoaddgvKhohang();
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
            pnPhieunhap.Controls.Add(Childform);
            pnPhieunhap.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
        }
        public void LoadcbbHangsx()
        {
            if (pnTimkiem.Visible != false)
            {
                var ncc = new SqlCommand("select * from NHACUNGCAP", conn);
                var dr = ncc.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dr.Dispose();
                cbbHangsx.DisplayMember = "TEN";
                cbbHangsx.DataSource = dt;
                cbbHangsx.SelectedIndex = -1;
            }
        }

        public void LoadcbbDanhmucsp()
        {
            if (pnTimkiem.Visible != false)
            {
                var ncc = new SqlCommand("select * from DANHMUCSP", conn);
                var dr = ncc.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dr.Dispose();
                cbbDanhmucsp.DisplayMember = "TENDMUC";
                cbbDanhmucsp.DataSource = dt;
                cbbDanhmucsp.SelectedIndex = -1;
            }
        }

        void LoaddgvKhohang()
        {
            string query = "SELECT * FROM SANPHAM";
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhohang.DataSource = dt;
        }

        private void Frm_Khohang_Load(object sender, EventArgs e)
        {
            LoaddgvKhohang();
        }

        public void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (KhoHangClosed != null)
            {
                KhoHangClosed(this, EventArgs.Empty);
            }
        }

        string getmancc()
        {
            string query = "SELECT MANCC FROM NHACUNGCAP WHERE TEN = @TEN";
            string mancc = null;

            try
            {
                using (var conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True"))
                {
                    conn.Open();

                    if (cbbHangsx.SelectedIndex != -1)
                    {
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@TEN", cbbHangsx.Text);
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    mancc = reader["MANCC"].ToString();
                                    return mancc;
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy nhà cung cấp");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message);
            }
            return mancc;
        }

        string getmadmuc()
        {
            string query = "SELECT MADMUC FROM DANHMUCSP WHERE TENDMUC = @TEN";
            string madmuc = null;

            try
            {
                if (cbbDanhmucsp.SelectedIndex != -1)
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TEN", cbbDanhmucsp.Text);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                madmuc = reader["MADMUC"].ToString();
                                return madmuc;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy danh mục sp");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn dữ liệu: " + ex.Message);
            }
            return madmuc;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            
            string mancc = getmancc();
            string madmuc = getmadmuc();

            int? giaMin = null;
            int? giaMax = null;
            int? manhacc = null;
            int? madm = null;
            if (!string.IsNullOrEmpty(txtGiamin.Text))
            {
                giaMin = Convert.ToInt32(txtGiamin.Text);
            }

            if (!string.IsNullOrEmpty(txtGiamax.Text))
            {
                giaMax = Convert.ToInt32(txtGiamax.Text);
            }

            if (!string.IsNullOrEmpty(mancc))
            {
                manhacc = Convert.ToInt32(mancc);
            }

            if (!string.IsNullOrEmpty(madmuc))
            {
                madm = Convert.ToInt32(madmuc);
            }

            string command = $"SELECT * FROM TimKiemSanPham({(manhacc.HasValue ? manhacc.ToString() : "NULL")}, {(madm.HasValue ? madm.ToString() : "NULL")}, {(giaMin.HasValue ? giaMin.ToString() : "NULL")}, {(giaMax.HasValue ? giaMax.ToString() : "NULL")}, '{txtTenSP.Text}')";
            SqlDataAdapter adapter = new SqlDataAdapter(command, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvKhohang.DataSource = dataTable;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbDanhmucsp.SelectedIndex = -1;
            cbbHangsx.SelectedIndex = -1;
            txtGiamin.Clear();
            txtGiamax.Clear();
            txtTenSP.Clear();
            LoaddgvKhohang();
        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            pnPhieunhap.Visible = true;
            Frm_HDnhap hdnhap = new Frm_HDnhap();
            OpenChildFrm(hdnhap);
            hdnhap.HDNhapClosed += HDNhapClosedHandler;
        }

        private void Frm_Khohang_Load_1(object sender, EventArgs e)
        {

        }

        private void HDNhapClosedHandler(object sender, EventArgs e)
        {
            pnPhieunhap.Visible = false;
        }
    }
}
