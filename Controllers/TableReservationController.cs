using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantManagement.Models;

namespace RestaurantManagement.Controllers
{
    public class TableReservationController : Controller
    {
        private readonly RestaurantManagementContext _context;

        public TableReservationController(RestaurantManagementContext context)
        {
            _context = context;
        }

        // GET: TableReservation
        public async Task<IActionResult> Index()
        {
            var restaurantManagementContext = _context.TableReservation.Include(t => t.User);
            return View(await restaurantManagementContext.ToListAsync());
        }

        // GET: TableReservation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TableReservation == null)
            {
                return NotFound();
            }

            var tableReservation = await _context.TableReservation
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableReservation == null)
            {
                return NotFound();
            }

            return View(tableReservation);
        }

        // GET: TableReservation/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Password");
            return View();
        }

        // POST: TableReservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,TableNumber,ReservationDateTime")] TableReservation tableReservation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableReservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Password", tableReservation.UserId);
            return View(tableReservation);
        }

        // GET: TableReservation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TableReservation == null)
            {
                return NotFound();
            }

            var tableReservation = await _context.TableReservation.FindAsync(id);
            if (tableReservation == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Password", tableReservation.UserId);
            return View(tableReservation);
        }

        // POST: TableReservation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,TableNumber,ReservationDateTime")] TableReservation tableReservation)
        {
            if (id != tableReservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableReservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableReservationExists(tableReservation.Id))
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
            ViewData["UserId"] = new SelectList(_context.User, "Id", "Password", tableReservation.UserId);
            return View(tableReservation);
        }

        // GET: TableReservation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TableReservation == null)
            {
                return NotFound();
            }

            var tableReservation = await _context.TableReservation
                .Include(t => t.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableReservation == null)
            {
                return NotFound();
            }

            return View(tableReservation);
        }

        // POST: TableReservation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TableReservation == null)
            {
                return Problem("Entity set 'RestaurantManagementContext.TableReservation'  is null.");
            }
            var tableReservation = await _context.TableReservation.FindAsync(id);
            if (tableReservation != null)
            {
                _context.TableReservation.Remove(tableReservation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableReservationExists(int id)
        {
          return (_context.TableReservation?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
