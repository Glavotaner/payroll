using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.EmploymentData.Contract.Models;
using Payroll.Data;

namespace Payroll.Areas.EmploymentData.Contract
{
    [Area("EmploymentData")]
    public class ContractController : Controller
    {
        private readonly PayrollContext _context;

        public ContractController(PayrollContext context)
        {
            _context = context;
        }

        // GET: EmploymentData/Contract
        public async Task<IActionResult> Index()
        {
            var payrollContext = _context.Contract.Include(c => c.ContractType).Include(c => c.Workplace);
            return View(await payrollContext.ToListAsync());
        }

        // GET: EmploymentData/Contract/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.ContractType)
                .Include(c => c.Workplace)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // GET: EmploymentData/Contract/Create
        public IActionResult Create()
        {
            ViewData["ContractTypeId"] = new SelectList(_context.ContractType, "Id", "Id");
            ViewData["WorkplaceId"] = new SelectList(_context.Workplace, "Id", "Id");
            return View();
        }

        // POST: EmploymentData/Contract/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Coefficient,Start,End,ContractTypeId,WorkplaceId")] Models.Contract contract)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contract);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContractTypeId"] = new SelectList(_context.ContractType, "Id", "Id", contract.ContractTypeId);
            ViewData["WorkplaceId"] = new SelectList(_context.Workplace, "Id", "Id", contract.WorkplaceId);
            return View(contract);
        }

        // GET: EmploymentData/Contract/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract.FindAsync(id);
            if (contract == null)
            {
                return NotFound();
            }
            ViewData["ContractTypeId"] = new SelectList(_context.ContractType, "Id", "Id", contract.ContractTypeId);
            ViewData["WorkplaceId"] = new SelectList(_context.Workplace, "Id", "Id", contract.WorkplaceId);
            return View(contract);
        }

        // POST: EmploymentData/Contract/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Coefficient,Start,End,ContractTypeId,WorkplaceId")] Models.Contract contract)
        {
            if (id != contract.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contract);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractExists(contract.Id))
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
            ViewData["ContractTypeId"] = new SelectList(_context.ContractType, "Id", "Id", contract.ContractTypeId);
            ViewData["WorkplaceId"] = new SelectList(_context.Workplace, "Id", "Id", contract.WorkplaceId);
            return View(contract);
        }

        // GET: EmploymentData/Contract/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contract == null)
            {
                return NotFound();
            }

            var contract = await _context.Contract
                .Include(c => c.ContractType)
                .Include(c => c.Workplace)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contract == null)
            {
                return NotFound();
            }

            return View(contract);
        }

        // POST: EmploymentData/Contract/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contract == null)
            {
                return Problem("Entity set 'PayrollContext.Contract'  is null.");
            }
            var contract = await _context.Contract.FindAsync(id);
            if (contract != null)
            {
                _context.Contract.Remove(contract);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractExists(int id)
        {
          return (_context.Contract?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
