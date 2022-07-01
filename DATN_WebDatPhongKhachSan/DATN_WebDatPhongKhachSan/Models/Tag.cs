using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Tag
    {
        [Key]
        [Display(Name = "Mã tiện ích")]
        public Guid TagID { get; set; }
        [Display(Name = "Tên tiện ích")]
        public string TagName { get; set; }
        [Display(Name = "Mô tả")]
        public string Detail { get; set; }
        [Display(Name = "Biểu tượng")]
        public string Icon { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }
        //public List<Room> Rooms { get; set; }
    }
}
