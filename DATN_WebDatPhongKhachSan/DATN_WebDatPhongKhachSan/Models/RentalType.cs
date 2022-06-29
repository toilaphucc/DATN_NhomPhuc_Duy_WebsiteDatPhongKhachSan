using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class RentalType
    {
        [Key]
        [Display(Name = "Mã hình thức thuê")]
        public Guid RentalTypeID { get; set; }
        [Display(Name = "Hình thức thuê")]
        public string RentalTypeName { get; set; }
        [Display(Name = "Chi tiết")]
        public string Detail { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }
    }
}
