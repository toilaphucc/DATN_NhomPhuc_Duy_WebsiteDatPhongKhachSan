using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DATN_WebDatPhongKhachSan.Data;
using DATN_WebDatPhongKhachSan.Models;

namespace DATN_WebDatPhongKhachSan.Controllers
{
    public class RoomsController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public RoomsController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> HomeIndex()
        {
            var datPhongKhachSanContext = _context.Rooms.Include(r => r.Owner).Include(r => r.RoomType);
            return View(await datPhongKhachSanContext.ToListAsync());

        }
        public async Task<IActionResult> Index()
        {
            var datPhongKhachSanContext = _context.Rooms.Include(r => r.Owner.User).Include(r => r.RoomType);
            return View(await datPhongKhachSanContext.ToListAsync());
        }
        public async Task<IActionResult> HomeDetail(Guid ? RoomID)
        {
            var ID = RouteData.Values["id"];           
            if (ID == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.Owner)
                .FirstOrDefaultAsync(m => m.RoomID.ToString() == ID);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .Include(r => r.Owner.User)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            ViewData["OwnerID"] = new SelectList(_context.Owners, "OwnerID", "OwnerID");
            ViewData["RoomTypeID"] = new SelectList(_context.RoomTypes, "RoomTypeID", "RoomTypeName");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomID,OwnerID,RoomCode,Price,Detail,Image,AmountRoom,IsActive,RoomTypeID,TagID,Name,CreatedOn,ModifiedOn")] Room room)
        {
            if (ModelState.IsValid)
            {
                room.RoomID = Guid.NewGuid();
                room.CreatedOn = DateTime.Now;
                room.ModifiedOn = DateTime.Now;
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.Owners, "OwnerID", "OwnerID", room.OwnerID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomTypes, "RoomTypeID", "RoomTypeID", room.RoomTypeID);
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["OwnerID"] = new SelectList(_context.Owners, "OwnerID", "OwnerID", room.OwnerID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomTypes, "RoomTypeID", "RoomTypeName", room.RoomTypeID);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RoomID,OwnerID,RoomCode,Price,Detail,Image,AmountRoom,IsActive,RoomTypeID,TagID,Name,CreatedOn,ModifiedOn")] Room room)
        {
            if (id != room.RoomID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    room.ModifiedOn = DateTime.Now;
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.RoomID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["OwnerID"] = new SelectList(_context.Owners, "OwnerID", "OwnerID", room.OwnerID);
            ViewData["RoomTypeID"] = new SelectList(_context.RoomTypes, "RoomTypeID", "RoomTypeID", room.RoomTypeID);
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .Include(r => r.Owner.User)
                .Include(r => r.RoomType)
                .FirstOrDefaultAsync(m => m.RoomID == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var room = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(Guid id)
        {
            return _context.Rooms.Any(e => e.RoomID == id);
        }
    }
}
