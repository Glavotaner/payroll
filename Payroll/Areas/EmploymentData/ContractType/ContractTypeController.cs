using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.EmploymentData.ContractType.Models;
using Payroll.Data;

namespace Payroll.Areas.EmploymentData.ContractType
{
    [Area("EmploymentData")]
    public class ContractTypeController : Controller
    {
        private readonly PayrollContext _context;

        public ContractTypeController(PayrollContext context)
        {
            _context = context;
        }

        // GET: EmploymentData/ContractType
        public async Task<IActionResult> Index()
        {
              return _context.ContractType != null ? 
                          View(await _context.ContractType.ToListAsync()) :
                          Problem("Entity set 'PayrollContext.ContractType'  is null.");
        }

        // GET: EmploymentData/ContractType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ContractType == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractType == null)
            {
                return NotFound();
            }

            return View(contractType);
        }

        // GET: EmploymentData/ContractType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmploymentData/ContractType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Retired")] Models.ContractType contractType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contractType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contractType);
        }

        // GET: EmploymentData/ContractType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContractType == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractType.FindAsync(id);
            if (contractType == null)
            {
                return NotFound();
            }
            return View(contractType);
        }

        // POST: EmploymentData/ContractType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Retired")] Models.ContractType contractType)
        {
            if (id != contractType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contractType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractTypeExists(contractType.Id))
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
            return View(contractType);
        }

        // GET: EmploymentData/ContractType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContractType == null)
            {
                return NotFound();
            }

            var contractType = await _context.ContractType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractType == null)
            {
                return NotFound();
            }

            return View(contractType);
        }

        // POST: EmploymentData/ContractType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContractType == null)
            {
                return Problem("Entity set 'PayrollContext.ContractType'  is null.");
            }
            var contractType = await _context.ContractType.FindAsync(id);
            if (contractType != null)
            {
                _context.ContractType.Remove(contractType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractTypeExists(int id)
        {
          return (_context.ContractType?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
