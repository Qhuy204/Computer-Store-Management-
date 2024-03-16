using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMayTinh
{
    public partial class Frm_Thongke : Form
    {
        public Frm_Thongke()
        {
            InitializeComponent();
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

        private void btnTongSLDaban_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OpenChildFrm(new Frm_KQThongKe());
        }

        private void btnSLHang_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OpenChildFrm(new Frm_ThongkeSLHang());
        }

        private void btnDoanhsoNV_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OpenChildFrm(new Frm_ThongkedoanhsoNV());
        }

        private void btnPhantramDSSP_Click(object sender, EventArgs e)
        {
            panel1.Visible= true;
            OpenChildFrm(new Frm_ThongkeDSSP());
        }

        private void PhanTramdoanhsoKH_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            OpenChildFrm(new Frm_ThongkePTDSKHTheoTinh());
        }
    }
}
