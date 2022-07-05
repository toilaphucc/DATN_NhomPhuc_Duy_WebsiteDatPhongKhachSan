using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DATN_WebDatPhongKhachSan.Data;
using DATN_WebDatPhongKhachSan.Models;
using Microsoft.AspNetCore.Http;

namespace DATN_WebDatPhongKhachSan.Controllers
{
    public class UsersController : Controller
    {
        private readonly DatPhongKhachSanContext _context;

        public UsersController(DatPhongKhachSanContext context)
        {
            _context = context;
        }

        public IActionResult Login(string username, string password)
        {
            ViewBag.isLogin = true;
            User user = _context.Users.Where(i => i.UserName == username && i.Password == password).FirstOrDefault();
            if (user != null)
            {
                //HttpContext.Session.SetString("UserID", user.UserID.ToString());
                //HttpContext.Session.SetString("UserPhone", user.Phone);
                ViewBag.success_Login_Message = "Đăng nhập thành công";
                if (user.IsAdmin == true)
                {
                    return RedirectToAction("Index", "Users");
                }
                else
                    return RedirectToAction("HomeIndex", "Rooms");
            }
            else
            {
                ViewBag.failed_Login_Message = "Đăng nhập thất bại";
                return View();
            }
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View( _context.Users.OrderByDescending(r => r.ModifiedOn).ToList());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserID,UserName,Password,LastName,FirstName,FullName,Email,Phone,IsAdmin,IsActive,CreatedOn,ModifiedOn")] User user)
        {
            if (ModelState.IsValid)
            {
                user.UserID = Guid.NewGuid();
                user.FullName = user.LastName.ToString().Trim() + " "+user.FirstName.ToString().Trim();
                user.CreatedOn = DateTime.Now;
                user.ModifiedOn = DateTime.Now;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("UserID,UserName,Password,LastName,FirstName,FullName,Email,Phone,IsAdmin,IsActive,CreatedOn,ModifiedOn")] User user)
        {
            if (id != user.UserID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    user.FullName = user.LastName.ToString().Trim() + " " + user.FirstName.ToString().Trim();
                    user.ModifiedOn = DateTime.Now;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserID))
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
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserID == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            var owner = await _context.Owners.FirstOrDefaultAsync(o => o.UserID == id);
            var customer = await _context.Custommers.FirstOrDefaultAsync(c => c.UserID == id);
            _context.Users.Remove(user);
            if(owner != null)
            {
                _context.Owners.Remove(owner);
            }      
            if(customer != null)
            {
                _context.Custommers.Remove(customer);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.UserID == id);
        }
    }
}
