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
    public class RentalTypesController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public RentalTypesController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        // GET: RentalTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.RentalTypes.ToListAsync());
        }

        // GET: RentalTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalType = await _context.RentalTypes
                .FirstOrDefaultAsync(m => m.RentalTypeID == id);
            if (rentalType == null)
            {
                return NotFound();
            }

            return View(rentalType);
        }

        // GET: RentalTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RentalTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalTypeID,RentalTypeName,Detail,CreatedOn,ModifiedOn")] RentalType rentalType)
        {
            if (ModelState.IsValid)
            {
                rentalType.RentalTypeID = Guid.NewGuid();
                _context.Add(rentalType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rentalType);
        }

        // GET: RentalTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalType = await _context.RentalTypes.FindAsync(id);
            if (rentalType == null)
            {
                return NotFound();
            }
            return View(rentalType);
        }

        // POST: RentalTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("RentalTypeID,RentalTypeName,Detail,CreatedOn,ModifiedOn")] RentalType rentalType)
        {
            if (id != rentalType.RentalTypeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalTypeExists(rentalType.RentalTypeID))
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
            return View(rentalType);
        }

        // GET: RentalTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalType = await _context.RentalTypes
                .FirstOrDefaultAsync(m => m.RentalTypeID == id);
            if (rentalType == null)
            {
                return NotFound();
            }

            return View(rentalType);
        }

        // POST: RentalTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var rentalType = await _context.RentalTypes.FindAsync(id);
            _context.RentalTypes.Remove(rentalType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalTypeExists(Guid id)
        {
            return _context.RentalTypes.Any(e => e.RentalTypeID == id);
        }
    }
}
