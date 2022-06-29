using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "Mã khách hàng")]
        public Guid CustomerID { get; set; }
        [Display(Name = "Mã tài khoản")]
        public Guid UserID { get; set; }
        public User User { get; set; }
        [Display(Name = "Ngày sinh")]
        public string Date { get; set; }
        [Display(Name = "Tháng sinh")]
        public string Month { get; set; }
        [Display(Name = "Năm sinh")]
        public string Year { get; set; }
        [Display(Name = "Ngày/tháng/năm sinh")]
        public DateTime DoB { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedOn { get ; set ; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }

        
    }
}
