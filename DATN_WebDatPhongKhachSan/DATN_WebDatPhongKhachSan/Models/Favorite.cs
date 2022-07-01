using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Favorite
    {
        [Key]
        [Display(Name = "Mã yêu thích")]
        public Guid FavoriteID { get; set; }
        [Display(Name = "Mã phòng")]
        public Guid RoomID { get; set; }
        [Display(Name = "Mã tài khoản")]
        public Guid UserID { get; set; }
        [Display(Name = "Ngày thêm")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }
    }
}
