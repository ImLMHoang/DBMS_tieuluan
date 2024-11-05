using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_in_and_Sign_Up.Model
{
    internal class Customer
    {
        [Key]
        public int CustomerID { get; set; } // Mã khách hàng (Khóa chính)

        [StringLength(100)]
        public string FullName { get; set; } // Tên khách hàng

        [StringLength(20)]
        public long PhoneNumber { get; set; } // Số điện thoại

        [StringLength(100)]
        public string Username { get; set; } // Tên đăng nhập (có thể null)

        [StringLength(100)]
        public string Password { get; set; } // Mật khẩu (có thể null, giới hạn 100 ký tự)
    }
}
