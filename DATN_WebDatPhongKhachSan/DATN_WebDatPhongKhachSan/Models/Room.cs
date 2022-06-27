using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Models
{
    public class Room
    {
        [Key]
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public Guid RoomTypeID { get; set; }
        public Guid RentalTypeID { get; set; }
        public Guid UtilitiesID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
