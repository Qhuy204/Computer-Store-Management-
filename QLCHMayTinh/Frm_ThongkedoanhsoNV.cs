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
    public partial class Frm_ThongkedoanhsoNV : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");
        public Frm_ThongkedoanhsoNV()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Frm_ThongkedoanhsoNV_Load(object sender, EventArgs e)
        {
            try
            {
                // Câu truy vấn SQL
                string query = @"
                        SELECT
                            NV.MANV,
                            NV.HOTEN,
                            COUNT(PX.MAPX) AS SoDonHang,
                            SUM(PX.TRIGIA) AS TongTien,
                            SUM(PX.TRIGIA) * 0.03 AS ThuongDoanhSo
                        FROM NHANVIEN NV
                        LEFT JOIN PHIEUXUAT PX ON NV.MANV = PX.MANV
                        GROUP BY NV.MANV, NV.HOTEN
                        ORDER BY SoDonHang DESC";

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
