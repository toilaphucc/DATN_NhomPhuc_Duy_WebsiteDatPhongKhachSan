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
        public Guid RentalTypeID { get; set; }
        public string RentalTypeName { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
