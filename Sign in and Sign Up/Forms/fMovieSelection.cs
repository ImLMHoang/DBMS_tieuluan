using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using Sign_in_and_Sign_Up.Model;

namespace Sign_in_and_Sign_Up.Forms
{
    public partial class fMovieSelection : Form
    {
        private int currentCustomerId;
        private string connectionString;
        private string[] movieTitles = { "Avengers", "Batman", "BlackPanther", "Frozen", "IronMan", "SpiderMan", "SuperMan", "Tangled", "Thor", "WonderWoman" };

        public fMovieSelection(int customerId)
        {
            InitializeComponent();
            currentCustomerId = customerId;
            connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            LoadMovies();
        }

        private void LoadMovies()
        {
            for (int i = 0; i < movieTitles.Length; i++)
            {
                string movieTitle = movieTitles[i];
                buttons[i].Text = movieTitle;

                try
                {
                    pictureBoxes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(movieTitle) ?? Properties.Resources.DefaultImage;
                }
                catch
                {
                    pictureBoxes[i].Image = Properties.Resources.DefaultImage;
                }

                buttons[i].Click += (s, e) => OpenMainForm(movieTitle);
            }
        }

        private void OpenMainForm(string movieTitle)
        {
            fMain mainForm = new fMain(currentCustomerId, movieTitle);
            mainForm.Show();
            this.Hide();
        }

        private void fMovieSelection_Load(object sender, EventArgs e)
        {
        }
    }
}
