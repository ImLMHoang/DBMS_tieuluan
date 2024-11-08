using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_in_and_Sign_Up.Model
{
    public class Showtime
    {
        [Key]
        public int ShowtimeID { get; set; } // Mã suất chiếu (Khóa chính)

        [StringLength(100)]
        public string MovieTitle { get; set; } // Tên phim

        public DateTime StartTime { get; set; } // Thời gian bắt đầu chiếu

        public DateTime? EndTime { get; set; } // Thời gian kết thúc dự kiến
    }
}
