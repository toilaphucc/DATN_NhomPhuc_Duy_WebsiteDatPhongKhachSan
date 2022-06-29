using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class RoomType
    {
        [Key]
        [Display(Name = "Mã loại phòng")]
        public Guid RoomTypeID { get; set; }
        [Display(Name = "Tên loại phòng")]
        public string RoomTypeName { get; set; }
        [Display(Name = "Chi tiết")]
        public string Detail { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
