using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMayTinh
{
    public partial class Frm_Main : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_Main()
        {
            InitializeComponent();
            conn.Open();
            pnHome.Visible = false;
        }

        private Form curFormChild;
        private void OpenChildFrm(Form Childform)
        {
            panel1.AutoSize = true;
            if (curFormChild != null)
            {
                curFormChild.Close();
            }
            curFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(Childform);
            panel1.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
            
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
            
        }
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnHome.Visible = false;
            label2.Text = btnHome.Text;
            whenPressButton();
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            label2.Text = btnSanpham.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Sanpham());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            label2.Text = btnNCC.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Nhacungcap());
        }

        private void btnDonhang_Click(object sender, EventArgs e)
        {
            label2.Text = btnDonhang.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Phieuxuat());
        }

        private void btnKhohang_Click(object sender, EventArgs e)
        {
            label2.Text = btnKhohang.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Khohang());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            label2.Text = btnNhanvien.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Nhanvien());
        }

        void whenPressButton()
        {
            if (curFormChild != null)
            {
                curFormChild.Close();
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            label2.Text = btnThongke.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Thongke());
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            label2.Text = btnTimkiem.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Timkiem());
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            conn.Close();
            Frm_login frmlogin = new Frm_login();
            this.Hide();
            frmlogin.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = btnKhachhang.Text;
            whenPressButton();
            OpenChildFrm(new Frm_Khachhang());
        }
    }
}
