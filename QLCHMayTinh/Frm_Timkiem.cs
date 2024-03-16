using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMayTinh
{
    public partial class Frm_Timkiem : Form
    {
        public Frm_Timkiem()
        {
            InitializeComponent();
        }

        private Form curFormChild;
        private void OpenChildFrm(Form Childform)
        {
            panelA.AutoSize = true;
            if (curFormChild != null)
            {
                curFormChild.Close();
            }
            curFormChild = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panelA.Controls.Add(Childform);
            panelA.Tag = Childform;
            Childform.BringToFront();
            Childform.Show();
            panelB.Visible = false;
        }

        private void btnSanpham_Click(object sender, EventArgs e)
        {
            panelB.Visible = false;
            Frm_Khohang khohang = new Frm_Khohang();
            OpenChildFrm(khohang);
            Panel pnTimkiem = (Panel)khohang.Controls["pnTimkiem"];
            Button btnBack = (Button)khohang.Controls["btnBack"];
            Button btnNhaphang = (Button)khohang.Controls["btnNhaphang"];
            pnTimkiem.Visible = true;
            btnBack.Visible = true;
            btnNhaphang.Visible = false;
            khohang.Show();
            khohang.KhoHangClosed += KhoHangClosedHandler;
            khohang.LoadcbbHangsx();
            khohang.LoadcbbDanhmucsp();
        }
        private void KhoHangClosedHandler(object sender, EventArgs e)
        {
            panelB.Visible = true;
        }

        private void Frm_Timkiem_Load(object sender, EventArgs e)
        {

        }

        private void btnHDnhap_Click(object sender, EventArgs e)
        {

        }
    }
}
