using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sign_in_and_Sign_Up.Model
{
    internal class SeatBooking
    {
        [Key]
        public int BookingID { get; set; } // Mã đặt ghế (Khóa chính)

        public int SeatNumber { get; set; } // Số ghế

        public int ShowtimeID { get; set; } // Mã suất chiếu (Khóa ngoại đến Showtime)
        [ForeignKey("ShowtimeID")]
        public Showtime Showtime { get; set; }

        public int CustomerID { get; set; } // Mã khách hàng (Khóa ngoại đến Customer)
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [StringLength(20)]
        public string Status { get; set; } // Trạng thái ghế (Đang giữ chỗ, Đã đặt, Hủy)

        public DateTime BookingTime { get; set; } = DateTime.Now; // Thời gian đặt ghế
    }
}
