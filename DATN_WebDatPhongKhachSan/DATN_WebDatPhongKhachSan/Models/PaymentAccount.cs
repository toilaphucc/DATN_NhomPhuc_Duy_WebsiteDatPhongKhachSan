using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class PaymentAccount
    {
        [Key]
        public Guid PaymentAccountID { get; set; }
        public Guid UserID { get; set; }
        public string AccountNumber { get; set; }
        public string FullName { get; set; }
        public string BankID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
