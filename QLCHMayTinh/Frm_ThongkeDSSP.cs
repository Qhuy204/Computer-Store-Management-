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
    public partial class Frm_ThongkeDSSP : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_ThongkeDSSP()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Frm_ThongkeDSSP_Load(object sender, EventArgs e)
        {
            try
            {
                // Câu truy vấn SQL
                string query = @"
                        SELECT SP.MASP, SP.TENSP, SP.DVT, SP.GIA, SP.SLTONKHO,
                               ROUND((SUM(CTPX.SL) * 100.0) / SUM(SUM(CTPX.SL)) OVER (), 2) AS PHAN_TRAM_BAN_RA,
                               ROUND((SUM(CTPX.SL * SP.GIA) * 100.0) / SUM(SUM(CTPX.SL * SP.GIA)) OVER (), 2) AS PHAN_TRAM_DOANH_THU
                        FROM SANPHAM SP
                        LEFT JOIN CTPHIEUXUAT CTPX ON SP.MASP = CTPX.MASP
                        GROUP BY SP.MASP, SP.TENSP, SP.DVT, SP.GIA, SP.SLTONKHO";

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
