using Sign_in_and_Sign_Up.Forms;
using Sign_in_and_Sign_Up.Sign_Up;

namespace Sign_in_and_Sign_Up
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lkSignUp_Click(object sender, EventArgs e)
        {
            fSignUp f = new fSignUp();
            f.MdiParent = this.MdiParent;
            f.Show();
            this.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //// Lấy thông tin từ giao diện người dùng (UI)
            //string username = txtUsername.Text;
            //if (string.IsNullOrEmpty(username))
            //{
            //    MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ!");
            //    return;
            //}

            //string password = txtPassword.Text;
            //if (string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Mật khẩu không được để trống!");
            //    return;
            //}

            //// Sử dụng EFDbContext để kiểm tra thông tin đăng nhập
            //using (var context = new EFDbContext())
            //{
            //    // Tìm tài khoản khớp với tên đăng nhập và mật khẩu
            //    var account = context.Customers.FirstOrDefault(t => t.Username == username && t.Password == password);

            //    if (account != null)
            //    {
            //        MessageBox.Show("Đăng nhập thành công!");

            //        int customerId = account.CustomerID;

            //        // THÊM CODE Ở ĐÂY //
            //        string movieTitle = "Tên phim mặc định hoặc lựa chọn"; 
            //        // THÊM CODE Ở ĐÂY //

            //        // Chuyển hướng vào FormMain
            //        fMain mainForm = new fMain(customerId, movieTitle); // THÊM movieTitle ở đây //
            //        mainForm.Show();

            //        // Ẩn form đăng nhập
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            //    }
            //}

            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập hợp lệ!");
                return;
            }

            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            using (var context = new EFDbContext())
            {
                var account = context.Customers.FirstOrDefault(t => t.Username == username && t.Password == password);

                if (account != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");

                    int customerId = account.CustomerID;

                    //Mở fMovieSelection sau khi đăng nhập
                    fMovieSelection movieSelectionForm = new fMovieSelection(customerId);
                    movieSelectionForm.Show();

                    //Ẩn form đăng nhập
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                }
            }
        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ckShow.Checked;
        }
    }
}
