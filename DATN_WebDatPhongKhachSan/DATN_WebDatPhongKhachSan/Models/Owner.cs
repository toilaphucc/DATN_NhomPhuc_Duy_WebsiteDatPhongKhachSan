using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Owner
    {
        [Key]
        [Display(Name = "Mã chủ phòng")]
        public Guid OwnerID { get; set; }
        [Display(Name = "Mã tài khoản")]
        public Guid UserID { get; set; }
        public User User { get; set; }
        [Display(Name = "Số nhà, đường")]
        public string Address { get; set; }
        [Display(Name = "Xã/Phường")]
        public string Ward { get; set; }
        [Display(Name = "Quận/Huyện")]
        public string District { get; set; }
        [Display(Name = "Tỉnh/Thành")]
        public string City { get; set; }
        [Display(Name = "Là khách sạn")]
        public bool IsHotel { get; set; }
        [Display(Name = "Tên khách sạn")]
        public string HotelName { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }
    }
}
