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
    public class OwnersController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public OwnersController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        // GET: Owners
        public async Task<IActionResult> Index()
        {
            var datPhongKhachSanContext = _context.Owners.Include(o => o.User);
            return View(await datPhongKhachSanContext.ToListAsync());
        }

        // GET: Owners/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }

        // GET: Owners/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName");
            return View();
        }

        // POST: Owners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OwnerID,UserID,Address,Ward,District,City,IsHotel,HotelName,CreatedOn,ModifiedOn")] Owner owner)
        {
            if (ModelState.IsValid)
            {
                owner.OwnerID = Guid.NewGuid();
                owner.CreatedOn = DateTime.Now;
                owner.ModifiedOn = DateTime.Now;
                _context.Add(owner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", owner.UserID);
            return View(owner);
        }

        // GET: Owners/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners.FindAsync(id);
            if (owner == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName", owner.UserID);
            return View(owner);
        }

        // POST: Owners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("OwnerID,Address,Ward,District,City,IsHotel,HotelName,CreatedOn,ModifiedOn")] Owner owner)
        {
            if (id != owner.OwnerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    owner.ModifiedOn = DateTime.Now;
                    _context.Update(owner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OwnerExists(owner.OwnerID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", owner.UserID);
            return View(owner);
        }

        // GET: Owners/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var owner = await _context.Owners
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }

        // POST: Owners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var owner = await _context.Owners.FindAsync(id);
            var room = await _context.Rooms.FirstOrDefaultAsync(r => r.RoomID == id);
            _context.Rooms.Remove(room);
            _context.Owners.Remove(owner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OwnerExists(Guid id)
        {
            return _context.Owners.Any(e => e.OwnerID == id);
        }
    }
}
