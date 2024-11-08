using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_in_and_Sign_Up.Model
{
    public class ShowtimeSeat
    {
        [Key]
        public int SeatID { get; set; }          // Khóa chính, là một IDENTITY cột

        public int ShowtimeID { get; set; }      // Mã suất chiếu
        public int SeatNumber { get; set; }      // Số ghế
        public string Status { get; set; }       // Trạng thái ghế ("Trống" hoặc "Đã đặt")

        public int? CustomerID { get; set; }     // CustomerID không phải là khóa chính và không phải IDENTITY

        // Navigation property tới bảng Showtime (nếu có quan hệ)
        public Showtime Showtime { get; set; }
    }
}
