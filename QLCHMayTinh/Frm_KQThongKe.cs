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
    public partial class Frm_KQThongKe : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_KQThongKe()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Frm_KQThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                // Câu truy vấn SQL
                string query = @"
                        SELECT 
                            CTPX.MASP AS MASP,
                            SP.TENSP AS TENSP,
                            SUM(CTPX.SL) AS SLBAN,
                            CTPN.GIANHAP,
                            CTPX.GIABAN,
                            SUM(CTPX.SL * SP.GIA - CTPN.GIANHAP * CTPX.SL) AS LOINHUANTRENSOSPBANRA
                        FROM SANPHAM SP
                        INNER JOIN CTPHIEUNHAP CTPN ON CTPN.MASP = SP.MASP
                        INNER JOIN CTPHIEUXUAT CTPX ON CTPX.MASP = SP.MASP
                        GROUP BY CTPX.MASP, SP.TENSP, CTPN.GIANHAP, CTPX.GIABAN";

                // Tạo SqlCommand và SqlDataAdapter
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Tạo DataTable để lưu trữ kết quả
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu lên DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
