﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class PaymentAccount
    {
        [Key]
        [Display(Name = "Mã tài khoản thanh toán")]
        public Guid PaymentAccountID { get; set; }
        [Display(Name = "Mã tài khoản sở hữu")]
        public Guid UserID { get; set; }
        [Display(Name = "Số tài khoản")]
        public string AccountNumber { get; set; }
        [Display(Name = "Tên đầy đủ")]
        public string FullName { get; set; }
        [Display(Name = "Mã ngân hàng")]
        public string BankID { get; set; }
        [Display(Name = "Ngày thêm")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày chỉnh sửa")]
        public DateTime ModifiedOn { get; set; }
    }
}
