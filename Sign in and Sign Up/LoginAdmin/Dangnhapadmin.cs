using Microsoft.Data.SqlClient;
using Sign_in_and_Sign_Up.LoginAdmin;
using System;
using System.Windows.Forms;

namespace Sign_in_and_Sign_Up
{
    public partial class Dangnhapadmin : Form
    {
        private string connectionString = "Server=DESKTOP-IFJSRH7\\KNGA;Database=MovieTicket;Trusted_Connection=True;TrustServerCertificate=True;";

        public Dangnhapadmin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string adminName = txtAdminName.Text;
            string password = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Admin WHERE NameAdmin = @NameAdmin AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NameAdmin", adminName);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        fIndex mainForm = new fIndex(); // Khởi tạo fIndex
                        mainForm.Show(); // Mở fIndex
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + "\nStack Trace: " + ex.StackTrace, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
