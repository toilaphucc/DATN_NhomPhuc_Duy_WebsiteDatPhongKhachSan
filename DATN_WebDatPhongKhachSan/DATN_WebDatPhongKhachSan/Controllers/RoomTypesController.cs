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
    public class RoomTypesController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public RoomTypesController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        // GET: RoomTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomTypes.ToListAsync());
        }

        // GET: RoomTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomType = await _context.RoomTypes
                .FirstOrDefaultAsync(m => m.RoomTypeID == id);
            if (roomType == null)
            {
                return NotFound();
            }

            return View(roomType);
        }

        // GET: RoomTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomTypeID,RoomTypeName,Detail,CreatedOn,ModifiedOn")] RoomType roomType)
        {
            if (ModelState.IsValid)
            {
                roomType.RoomTypeID = Guid.NewGuid();
                roomType.CreatedOn = DateTime.Now;
                roomType.ModifiedOn = DateTime.Now;
                _context.Add(roomType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomType);
        }

        // GET: RoomTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomType = await _context.RoomTypes.FindAsync(id);
            if (roomType == null)
            {
                return NotFound();
            }
            return View(roomType);
        }

        // POST: RoomTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RoomTypeID,RoomTypeName,Detail,CreatedOn,ModifiedOn")] RoomType roomType)
        {
            if (id != roomType.RoomTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    roomType.ModifiedOn = DateTime.Now;
                    _context.Update(roomType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomTypeExists(roomType.RoomTypeID))
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
            return View(roomType);
        }

        // GET: RoomTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomType = await _context.RoomTypes
                .FirstOrDefaultAsync(m => m.RoomTypeID == id);
            if (roomType == null)
            {
                return NotFound();
            }

            return View(roomType);
        }

        // POST: RoomTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var roomType = await _context.RoomTypes.FindAsync(id);
            _context.RoomTypes.Remove(roomType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomTypeExists(Guid id)
        {
            return _context.RoomTypes.Any(e => e.RoomTypeID == id);
        }
    }
}
