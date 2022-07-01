﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Invoice
    {
        [Key]
        [Display(Name = "Mã hóa đơn")]
        public Guid InvoiceID { get; set; }
        [Display(Name = "Mã chủ phòng")]
        public Guid OwnerID { get; set; }
        [Display(Name = "Mã khách thuê")]
        public Guid CustomerID { get; set; }
        [Display(Name = "Mã phòng thuê")]
        public Guid RoomID { get; set; }
        [Display(Name = "Mã hình thức thuê")]
        public Guid RentalTypeID { get; set; }
        [Display(Name = "Ngày nhận phòng")]
        public DateTime CheckInDate { get; set; }
        [Display(Name = "Ngày trả phòng")]
        public DateTime CheckOutDate { get; set; }
        [Display(Name = "Số ngày ở")]
        public int Count { get; set; }
        [Display(Name = "Số lượng người thuê")]
        public int AmountPeople { get; set; }
        [Display(Name = "Ngày lập hóa đơn")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày sửa hóa đơn")]
        public DateTime ModifiedOn { get; set; }
    }
}
