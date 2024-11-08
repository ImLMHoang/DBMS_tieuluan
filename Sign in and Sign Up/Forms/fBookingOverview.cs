using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sign_in_and_Sign_Up.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_in_and_Sign_Up.Forms
{
    public partial class fBookingOverview : Form
    {
        private int currentCustomerId;

        public fBookingOverview(int customerId)
        {
            InitializeComponent();
            currentCustomerId = customerId;
            LoadBookings();
        }

        //Tải danh sách đặt chỗ
        private void LoadBookings()
        {
            using (var context = new EFDbContext())
            {
                var bookingData = (from booking in context.SeatBookings
                                   join showtime in context.Showtimes
                                   on booking.ShowtimeID equals showtime.ShowtimeID
                                   where booking.CustomerID == currentCustomerId
                                   select new
                                   {
                                       BookingID = booking.BookingID,
                                       SeatNumber = booking.SeatNumber,
                                       ShowtimeID = booking.ShowtimeID,
                                       StartTime = showtime.StartTime, 
                                       Status = booking.Status,
                                       BookingTime = booking.BookingTime
                                   }).ToList();

                dataGridViewBookings.DataSource = bookingData;

                //Định dạng StartTime hiển thị theo ngày giờ
                dataGridViewBookings.Columns["StartTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";


                dataGridViewBookings.Columns["BookingID"].HeaderText = "Mã Đặt Vé";
                dataGridViewBookings.Columns["SeatNumber"].HeaderText = "Số Ghế";
                dataGridViewBookings.Columns["ShowtimeID"].HeaderText = "Mã Suất Chiếu";
                dataGridViewBookings.Columns["StartTime"].HeaderText = "Thời Gian Chiếu";
                dataGridViewBookings.Columns["Status"].HeaderText = "Trạng Thái";
                dataGridViewBookings.Columns["BookingTime"].HeaderText = "Thời Gian Đặt Vé";
            }
        }

        //Hủy đặt chỗ
        private void CancelBooking(int bookingId, int showtimeId, int seatNumber)
        {
            using (var context = new EFDbContext())
            {
                try
                {
                    //Gọi stored procedure để hủy đặt vé, sử dụng currentCustomerId
                    var result = context.Database.ExecuteSqlRaw(
                        "EXEC sp_CancelSeatBooking @SeatNumber = {0}, @ShowtimeID = {1}, @CustomerID = {2}",
                        seatNumber, showtimeId, currentCustomerId); //* currentCustomerId

                    MessageBox.Show("Hủy đặt ghế thành công!");
                    LoadBookings(); //Cập nhật bảng sau khi hủy thành công
                }
                catch (SqlException ex)
                {
                    //Bắt lỗi từ SQL Server và hiển thị thông báo chi tiết
                    MessageBox.Show("Có lỗi xảy ra khi hủy ghế: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không mong đợi: " + ex.Message);
                }
            }

        }




        //Sự kiện khi nhấn nút Hủy
        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                //Lấy thông tin từ hàng đã chọn
                int bookingId = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells["BookingID"].Value);
                int showtimeId = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells["ShowtimeID"].Value);
                int seatNumber = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells["SeatNumber"].Value);

                //Gọi hàm hủy đặt chỗ qua stored procedure
                CancelBooking(bookingId, showtimeId, seatNumber);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một vé để hủy.");
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //Đóng form `fBookingOverview`
        }


    }
}