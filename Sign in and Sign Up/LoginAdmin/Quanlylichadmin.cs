using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_in_and_Sign_Up.LoginAdmin
{
    public partial class fCalender : Form
    {
        public fCalender()
        {
            InitializeComponent();
        }

        private void Quanlylichadmin_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IFJSRH7\\KNGA;Database=MovieTicket;Trusted_Connection=True;TrustServerCertificate=True;";
            // Câu truy vấn SQL để lấy dữ liệu cho các cột cụ thể
            string query = "SELECT * FROM Showtime";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu cho DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btReturn1_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form2 và hiển thị nó
            fIndex formMain = new fIndex(); // Khởi tạo đối tượng cục bộ cho fCalender
            formMain.Show(); // Hiển thị Form2
            this.Hide();  // Ẩn Form1 nếu cần
        }
    }
}
