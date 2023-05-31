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
    public class PromotionController : Controller
    {
        private readonly RestaurantManagementContext _context;

        public PromotionController(RestaurantManagementContext context)
        {
            _context = context;
        }

        // GET: Promotion
        public async Task<IActionResult> Index()
        {
              return _context.Promotion != null ? 
                          View(await _context.Promotion.ToListAsync()) :
                          Problem("Entity set 'RestaurantManagementContext.Promotion'  is null.");
        }

        // GET: Promotion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Promotion == null)
            {
                return NotFound();
            }

            var promotion = await _context.Promotion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promotion == null)
            {
                return NotFound();
            }

            return View(promotion);
        }

        // GET: Promotion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Promotion/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,DiscountPercentage,StartDate,EndDate")] Promotion promotion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(promotion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(promotion);
        }

        // GET: Promotion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Promotion == null)
            {
                return NotFound();
            }

            var promotion = await _context.Promotion.FindAsync(id);
            if (promotion == null)
            {
                return NotFound();
            }
            return View(promotion);
        }

        // POST: Promotion/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,DiscountPercentage,StartDate,EndDate")] Promotion promotion)
        {
            if (id != promotion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(promotion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromotionExists(promotion.Id))
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
            return View(promotion);
        }

        // GET: Promotion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Promotion == null)
            {
                return NotFound();
            }

            var promotion = await _context.Promotion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (promotion == null)
            {
                return NotFound();
            }

            return View(promotion);
        }

        // POST: Promotion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Promotion == null)
            {
                return Problem("Entity set 'RestaurantManagementContext.Promotion'  is null.");
            }
            var promotion = await _context.Promotion.FindAsync(id);
            if (promotion != null)
            {
                _context.Promotion.Remove(promotion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PromotionExists(int id)
        {
          return (_context.Promotion?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
