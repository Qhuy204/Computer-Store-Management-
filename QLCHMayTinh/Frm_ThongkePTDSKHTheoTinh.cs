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
    public partial class Frm_ThongkePTDSKHTheoTinh : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=QHUY\\SQLEXPRESS;Initial Catalog=QLCT_MAYTINH;Integrated Security=True");

        public Frm_ThongkePTDSKHTheoTinh()
        {
            InitializeComponent();
            conn.Open();
        }

        private void Frm_ThongkePTDSKHTheoTinh_Load(object sender, EventArgs e)
        {
            try
            {
                // Câu truy vấn SQL
                string query = @"
                        WITH T_DoanhSo AS 
                        (
                            SELECT
                                SUBSTRING(DCHI, CHARINDEX(' - ', DCHI) + 3, LEN(DCHI)) AS TEN_TINH,
                                PX.TRIGIA AS DOANHSO
                            FROM KHACHHANG KH
                            JOIN PHIEUXUAT PX ON KH.MAKH = PX.MAKH
                        )
                        , TongDoanhSoTinh AS (
                            SELECT
                                TEN_TINH,
                                SUM(DOANHSO) AS TONG_DOANHSO_TINH
                            FROM T_DoanhSo
                            GROUP BY TEN_TINH
                        )
                        SELECT
                            TDT.TEN_TINH,
                            ROUND((TDT.TONG_DOANHSO_TINH * 100.0) / SUM(TDT.TONG_DOANHSO_TINH) OVER (), 2) AS PHAN_TRAM_DOANHSO
                        FROM TongDoanhSoTinh TDT
                        ";

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
