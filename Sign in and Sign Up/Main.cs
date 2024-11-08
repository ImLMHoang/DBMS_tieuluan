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
using System.Configuration;
using Sign_in_and_Sign_Up.Model;
using Microsoft.EntityFrameworkCore;
using Sign_in_and_Sign_Up.Forms;

namespace Sign_in_and_Sign_Up
{

    public partial class fMain : Form
    {
        private string connectionString;
        private int selectedSeatNumber = -1;
        private string selectedMovieTitle;
        private int currentCustomerId;

        public fMain(int customerId, string movieTitle)
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            currentCustomerId = customerId;
            selectedMovieTitle = movieTitle;
            txtMovieTitle.Text = movieTitle;

            LoadShowtimeOptions(movieTitle);
        }

        private void BtnGhe_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //Lấy số ghế từ nút đã chọn
                int seatNumber = int.Parse(clickedButton.Text);

                //Kiểm tra trạng thái của ghế và thay đổi màu sắc tương ứng
                if (clickedButton.BackColor == Color.White) 
                {
                    clickedButton.BackColor = Color.Blue; 
                    selectedSeatNumber = seatNumber;
                    textBoxSeatNumber.Text = seatNumber.ToString();
                }
                else if (clickedButton.BackColor == Color.Blue) 
                {
                    clickedButton.BackColor = Color.White; 
                    selectedSeatNumber = -1; //Reset lại biến selectedSeatNumber
                    textBoxSeatNumber.Clear(); //Xóa nội dung hiển thị số ghế đã chọn
                }
            }
        }
        private void LoadSeatsForShowtime(int showtimeId)
        {
            pnlHangGhe.Controls.Clear(); //Xóa ghế cũ

            int x, y = 20, khoangCach = 100, dem = 1;
            for (int i = 0; i < 5; i++) //5 hàng ghế
            {
                x = 3;
                for (int j = 0; j < 7; j++)//7 cột ghế
                {
                    Button btnGhe = new Button();
                    btnGhe.Location = new Point(x, y);
                    btnGhe.Size = new Size(90, 60);
                    btnGhe.Text = dem++.ToString();
                    btnGhe.BackColor = Color.White;
                    btnGhe.Click += BtnGhe_Click;

                    int seatNumber = int.Parse(btnGhe.Text);

                    
                    using (var context = new EFDbContext())
                    {
                        var seatBooking = context.SeatBookings
                            .FirstOrDefault(s => s.ShowtimeID == showtimeId && s.SeatNumber == seatNumber);

                        if (seatBooking != null)
                        {
                            if (seatBooking.CustomerID == currentCustomerId)
                            {
                                //Ghế đặt bởi người dùng hiện tại
                                btnGhe.BackColor = Color.Yellow; //Màu vàng
                            }
                            else
                            {
                                //Ghế đặt bởi người dùng khác
                                btnGhe.BackColor = Color.Red; // Màu đỏ
                                //btnGhe.Enabled = false; //Không cho current-cus-id chọn ghế này
                            }
                        }
                    }

                    pnlHangGhe.Controls.Add(btnGhe);
                    x += khoangCach;
                }
                y += khoangCach;
            }
        }

        private void BookSeat(int showtimeId, int seatNumber, int customerId)
        {
            using (var context = new EFDbContext())
            {
                try
                {
                    var result = context.Database.ExecuteSqlRaw(
                        "EXEC sp_BookSeat @SeatNumber = {0}, @ShowtimeID = {1}, @CustomerID = {2}",
                        seatNumber, showtimeId, customerId);

                    MessageBox.Show("Đặt ghế thành công!");

                    //Cập nhật trạng thái ghế sau khi đặt
                    LoadSeatsForShowtime(showtimeId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đặt ghế: " + ex.Message);
                }
            }
        }

        private class ShowtimeItem
        {
            public int ShowtimeID { get; set; }
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void LoadShowtimeOptions(string movieTitle) 
        {
            comboBoxShowtime.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ShowtimeID, StartTime FROM Showtimes WHERE MovieTitle = @MovieTitle";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MovieTitle", movieTitle);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int showtimeId = reader.GetInt32(0);
                        DateTime startTime = reader.GetDateTime(1);

                        //ShowtimeItem lưu trữ ShowtimeID và DisplayText
                        comboBoxShowtime.Items.Add(new ShowtimeItem
                        {
                            ShowtimeID = showtimeId,
                            DisplayText = startTime.ToString("yyyy-MM-dd HH:mm")
                        });
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách giờ chiếu: " + ex.Message);
                }
            }

            //Đặt mục đầu tiên trong comboBoxShowtime nếu có dữ liệu
            if (comboBoxShowtime.Items.Count > 0)
            {
                comboBoxShowtime.SelectedIndex = 0;
            }

            comboBoxShowtime.DisplayMember = "DisplayText"; //Hiển thị DisplayText của ShowtimeItem trong ComboBox
        }


        private void comboBoxShowtime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShowtime.SelectedItem != null)
            {
                var selectedShowtime = comboBoxShowtime.SelectedItem as ShowtimeItem;
                if (selectedShowtime != null)
                {
                    int showtimeId = selectedShowtime.ShowtimeID;
                    LoadSeatsForShowtime(showtimeId); //Tải và hiển thị ghế cho suất chiếu đã chọn
                }
            }
        }


        //
        //relatedtofBookingOverview
        //
        private void BtnViewBookingDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Khởi tạo và mở form fBookingOverview
            fBookingOverview bookingOverviewForm = new fBookingOverview(currentCustomerId);

            bookingOverviewForm.ShowDialog();

            //Hiện form chính khi fBookingOverview đóng
            this.Show();
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (selectedSeatNumber == -1)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi lưu!");
                return;
            }

            //Lấy ShowtimeID từ comboBoxShowtime 
            var selectedShowtime = (dynamic)comboBoxShowtime.SelectedItem;
            int showtimeId = selectedShowtime.ShowtimeID;

            try
            {
                //Gọi hàm BookSeat để thực hiện đặt ghế với stored procedure
                BookSeat(showtimeId, selectedSeatNumber, currentCustomerId);

                // Cập nhật trạng thái ghế để hiển thị trên giao diện
                LoadSeatsForShowtime(showtimeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi đặt ghế: " + ex.Message);
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadShowtimeOptions(selectedMovieTitle);
            comboBoxShowtime.SelectedIndexChanged += comboBoxShowtime_SelectedIndexChanged;

            //Kiểm tra và thiết lập mục đầu tiên nếu có
            if (comboBoxShowtime.Items.Count > 0)
            {
                comboBoxShowtime.SelectedIndex = 0; //Chọn mục đầu tiên

                //Lấy đối tượng SelectedItem và chuyển thành kiểu dynamic để lấy ShowtimeID
                var selectedShowtime = (dynamic)comboBoxShowtime.SelectedItem;

                if (selectedShowtime != null)
                {
                    int showtimeId = selectedShowtime.ShowtimeID;
                    LoadSeatsForShowtime(showtimeId); //Gọi hàm với tham số showtimeId hợp lệ
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            fMovieSelection movieSelectionForm = new fMovieSelection(currentCustomerId);
            movieSelectionForm.Show();

            //Ẩn fMain để về màn hình chọn phim
            this.Hide();
        }

    }
}
