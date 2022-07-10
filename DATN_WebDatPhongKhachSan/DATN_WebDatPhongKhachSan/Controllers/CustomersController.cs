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
    public class CustomersController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public CustomersController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var datPhongKhachSanContext = _context.Custommers.Include(c => c.User);
            return View(await datPhongKhachSanContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Custommers
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,UserID,Date,Month,Year,DoB,CreatedOn,ModifiedOn")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.CustomerID = Guid.NewGuid();
                customer.Date = customer.DoB.ToString().Substring(0, 2);
                customer.Month = customer.DoB.ToString().Substring(3, 2);
                customer.Year = customer.DoB.ToString().Substring(4, 4);
                customer.CreatedOn = DateTime.Now;
                customer.ModifiedOn = DateTime.Now;
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", customer.UserID);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Custommers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserName", customer.UserID);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CustomerID,UserID,Date,Month,Year,DoB,CreatedOn,ModifiedOn")] Customer customer)
        {
            if (id != customer.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    customer.Date = customer.DoB.ToString().Substring(0, 2);
                    customer.Month = customer.DoB.ToString().Substring(3, 2);
                    customer.Year = customer.DoB.ToString().Substring(4, 4);
                    customer.ModifiedOn = DateTime.Now;
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerID))
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
            ViewData["UserID"] = new SelectList(_context.Users, "UserID", "UserID", customer.UserID);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Custommers
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var customer = await _context.Custommers.FindAsync(id);
            _context.Custommers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(Guid id)
        {
            return _context.Custommers.Any(e => e.CustomerID == id);
        }
    }
}
