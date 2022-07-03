using DATN_WebDatPhongKhachSan.Models;
using DATN_WebDatPhongKhachSan.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DATN_WebDatPhongKhachSan.Data;
namespace DATN_WebDatPhongKhachSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatPhongKhachSanContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DanhSachPhongHome()
        {
            //var viewroom = _context.Rooms;
            //var lstroom = from room in _context.Rooms
            //              join roomtype in _context.RoomTypes on
            //                room.RoomTypeID equals roomtype.RoomTypeID
            //              join owner in _context.Owners on
            //              room.OwnerID equals owner.OwnerID
            //              select new
            //              {
            //                  Name = room.Name,
            //                  Detail = room.Detail,
            //                  Price = room.Price,
            //                  Image = room.Image,
            //                  Address = owner.Address,
            //                  Amount = room.AmountRoom,
            //                  RoomType = roomtype.RoomTypeName
            //              };
            var viewroom = _context.Rooms.OrderByDescending(p => p.RoomID).Take(6).ToList();

            return View(viewroom);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
