using System;
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
        public Owner Owner { get; set; }
        [Display(Name = "Mã khách")]
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        [Display(Name = "Mã phòng thuê")]
        public Guid RoomID { get; set; }
        public Room Room { get; set; }
        [Display(Name = "Mã hình thức thuê")]
        public Guid RentalTypeID { get; set; }
        public RentalType RentalType { get; set; }
        [Display(Name = "Ngày nhận phòng")]
        public DateTime CheckInDate { get; set; }
        [Display(Name = "Ngày trả phòng")]
        public DateTime CheckOutDate { get; set; }
        [Display(Name = "Số ngày ở")]
        public int Count { get; set; }
        [Display(Name = "Mã tài khoản thanh toán")]
        public Guid PaymentAccountID { get; set; }
        public PaymentAccount PaymentAccount { get; set; }
        [Display(Name = "Số lượng người thuê")]
        public int AmountPeople { get; set; }
        [Display(Name = "Ngày lập hóa đơn")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Ngày sửa hóa đơn")]
        public DateTime ModifiedOn { get; set; }
    }
}
