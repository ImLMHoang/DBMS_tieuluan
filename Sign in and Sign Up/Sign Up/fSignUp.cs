using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sign_in_and_Sign_Up.Model;

namespace Sign_in_and_Sign_Up.Sign_Up
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            string phoneNumberText = txtPhoneNumber.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng hợp lệ!");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (string.IsNullOrEmpty(phoneNumberText))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                return;
            }

            // Chuyển đổi phoneNumber từ string sang long
            if (!long.TryParse(phoneNumberText, out long phoneNumber))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ!");
                return;
            }

            using (var context = new EFDbContext())
            {
                // Kiểm tra xem Username có tồn tại trong cơ sở dữ liệu không
                var existingAccount = context.Customers.FirstOrDefault(value => value.Username == username);
                if (existingAccount != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác!");
                    return;
                }

                // Tạo đối tượng Customer mới với PhoneNumber là kiểu long
                Customer newAccount = new Customer
                {
                    Username = username,
                    Password = password,
                    FullName = fullName,
                    PhoneNumber = phoneNumber 
                };

                context.Customers.Add(newAccount);
                context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }

            MessageBox.Show("Đăng ký thành công!");
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckShow.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
