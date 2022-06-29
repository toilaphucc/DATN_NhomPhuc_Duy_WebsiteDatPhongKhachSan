using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Tag
    {
        [Key]
        public Guid UtilitiesID { get; set; }
        public string UtilitiesName { get; set; }
        public string Detail { get; set; }
        public string Icon { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
