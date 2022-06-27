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
        public Guid UserID { get; set; }
        public string Date { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public DateTime DoB { get; set; }
        public DateTime CreatedOn { get ; set ; } 
        public DateTime ModifiedOn { get; set; }
        
    }
}
