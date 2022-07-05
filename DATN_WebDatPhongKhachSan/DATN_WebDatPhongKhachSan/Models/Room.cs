using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Mã phòng")]
        public Guid RoomID { get; set; }
        [Display(Name = "Mã tài khoản chủ phòng")]
        public Guid OwnerID { get; set; }
        public Owner Owner { get; set; }
        [Display(Name = "Mã định danh phòng")]
        public string RoomCode { get; set; }
        [Display(Name = "Giá")]
        public float Price { get; set; }
        [Display(Name = "Chi tiết")]
        public string Detail { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Display(Name = "Số lượng phòng trống")]
        public int AmountRoom { get; set; }
        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; }
        [Display(Name = "Mã loại phòng")]
        public Guid RoomTypeID { get; set; }
        public RoomType RoomType { get; set; }
        [Display(Name = "Mã tiện ích phòng")]
        public Guid TagID { get; set; }
        [Display(Name = "Tên phòng")]
        public string Name { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }

        //public RoomType RoomType { get; set; }
        //public Guid RentalTypeID { get; set; }
        //[Display(Name = "Mã tiện ích phòng")]
        //public Guid TagID { get; set; }
        //public List<Tag> Tags { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
