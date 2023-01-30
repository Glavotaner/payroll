using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.EmploymentData.Workplace.Models;
using Payroll.Data;

namespace Payroll.Areas.EmploymentData.Workplace
{
    [Area("EmploymentData")]
    public class WorkplaceController : Controller
    {
        private readonly PayrollContext _context;

        public WorkplaceController(PayrollContext context)
        {
            _context = context;
        }

        // GET: EmploymentData/Workplace
        public async Task<IActionResult> Index()
        {
              return _context.Workplace != null ? 
                          View(await _context.Workplace.ToListAsync()) :
                          Problem("Entity set 'PayrollContext.Workplace'  is null.");
        }

        // GET: EmploymentData/Workplace/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Workplace == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workplace == null)
            {
                return NotFound();
            }

            return View(workplace);
        }

        // GET: EmploymentData/Workplace/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmploymentData/Workplace/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Salary,Retired")] Models.Workplace workplace)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workplace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workplace);
        }

        // GET: EmploymentData/Workplace/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Workplace == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplace.FindAsync(id);
            if (workplace == null)
            {
                return NotFound();
            }
            return View(workplace);
        }

        // POST: EmploymentData/Workplace/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Salary,Retired")] Models.Workplace workplace)
        {
            if (id != workplace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workplace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkplaceExists(workplace.Id))
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
            return View(workplace);
        }

        // GET: EmploymentData/Workplace/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Workplace == null)
            {
                return NotFound();
            }

            var workplace = await _context.Workplace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workplace == null)
            {
                return NotFound();
            }

            return View(workplace);
        }

        // POST: EmploymentData/Workplace/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Workplace == null)
            {
                return Problem("Entity set 'PayrollContext.Workplace'  is null.");
            }
            var workplace = await _context.Workplace.FindAsync(id);
            if (workplace != null)
            {
                _context.Workplace.Remove(workplace);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkplaceExists(int id)
        {
          return (_context.Workplace?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
