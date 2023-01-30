using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll.Areas.ThirdParties.Models;
using Payroll.Data;

namespace Payroll.Areas.ThirdParties.Controllers
{
    [Area("ThirdParties")]
    public class BankController : Controller
    {
        private readonly PayrollContext _context;

        public BankController(PayrollContext context)
        {
            _context = context;
        }

        // GET: ThirdParties/Bank
        public async Task<IActionResult> Index()
        {
            var payrollContext = _context.Bank.Include(b => b.Address);
            return View(await payrollContext.ToListAsync());
        }

        // GET: ThirdParties/Bank/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bank == null)
            {
                return NotFound();
            }

            var bank = await _context.Bank
                .Include(b => b.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // GET: ThirdParties/Bank/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id");
            return View();
        }

        // POST: ThirdParties/Bank/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PID,Name,IBAN,AddressId")] Bank bank)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bank);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", bank.AddressId);
            return View(bank);
        }

        // GET: ThirdParties/Bank/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bank == null)
            {
                return NotFound();
            }

            var bank = await _context.Bank.FindAsync(id);
            if (bank == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", bank.AddressId);
            return View(bank);
        }

        // POST: ThirdParties/Bank/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PID,Name,IBAN,AddressId")] Bank bank)
        {
            if (id != bank.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bank);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankExists(bank.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", bank.AddressId);
            return View(bank);
        }

        // GET: ThirdParties/Bank/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bank == null)
            {
                return NotFound();
            }

            var bank = await _context.Bank
                .Include(b => b.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }

        // POST: ThirdParties/Bank/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bank == null)
            {
                return Problem("Entity set 'PayrollContext.Bank'  is null.");
            }
            var bank = await _context.Bank.FindAsync(id);
            if (bank != null)
            {
                _context.Bank.Remove(bank);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankExists(int id)
        {
          return (_context.Bank?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
