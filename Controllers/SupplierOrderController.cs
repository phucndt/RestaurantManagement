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
    public class SupplierOrderController : Controller
    {
        private readonly RestaurantManagementContext _context;

        public SupplierOrderController(RestaurantManagementContext context)
        {
            _context = context;
        }

        // GET: SupplierOrder
        public async Task<IActionResult> Index()
        {
            var restaurantManagementContext = _context.SupplierOrder.Include(s => s.Supplier);
            return View(await restaurantManagementContext.ToListAsync());
        }

        // GET: SupplierOrder/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SupplierOrder == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }

        // GET: SupplierOrder/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "SupplierName");
            return View();
        }

        // POST: SupplierOrder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SupplierId,IngredientName,OrderDate,Quantity")] SupplierOrder supplierOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "SupplierName", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // GET: SupplierOrder/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SupplierOrder == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            if (supplierOrder == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "SupplierName", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // POST: SupplierOrder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SupplierId,IngredientName,OrderDate,Quantity")] SupplierOrder supplierOrder)
        {
            if (id != supplierOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierOrderExists(supplierOrder.Id))
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
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "SupplierName", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // GET: SupplierOrder/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SupplierOrder == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }

        // POST: SupplierOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SupplierOrder == null)
            {
                return Problem("Entity set 'RestaurantManagementContext.SupplierOrder'  is null.");
            }
            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            if (supplierOrder != null)
            {
                _context.SupplierOrder.Remove(supplierOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierOrderExists(int id)
        {
          return (_context.SupplierOrder?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
