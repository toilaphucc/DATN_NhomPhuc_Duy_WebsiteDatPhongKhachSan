using DATN_WebDatPhongKhachSan.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DATN_WebDatPhongKhachSan.Data
{
    public class DatPhongKhachSanContext : DbContext
    {
        public DatPhongKhachSanContext(DbContextOptions<DatPhongKhachSanContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Custommers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RentalType> RentalTypes { get; set; }
        public DbSet<Tag> Utilitiess { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<PaymentAccount> PaymentAccounts { get; set; }

    }
}

