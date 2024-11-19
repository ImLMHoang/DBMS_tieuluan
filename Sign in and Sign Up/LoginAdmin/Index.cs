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
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form2 và hiển thị nó
            fTicket formTicket = new fTicket(); // Khởi tạo đối tượng cục bộ cho fCalender
            formTicket.Show(); // Hiển thị Form2
            this.Hide();  // Ẩn Form1 nếu cần
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Khởi tạo Form2 và hiển thị nó
            fCalender formCalender = new fCalender(); // Khởi tạo đối tượng cục bộ cho fCalender
            formCalender.Show(); // Hiển thị Form2
            this.Hide();  // Ẩn Form1 nếu cần
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
                // Hiển thị Form đăng nhập
                Dangnhapadmin dangnhapadmin_Load = new Dangnhapadmin();
                dangnhapadmin_Load.Show();

                // Đóng Form chính
                this.Close();
        }
    }
}
