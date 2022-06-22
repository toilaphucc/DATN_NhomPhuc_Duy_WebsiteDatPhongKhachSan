using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class RoomType
    {
        [Key]
        public Guid RoomTypeID { get; set; }
        public string RoomTypeName { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
