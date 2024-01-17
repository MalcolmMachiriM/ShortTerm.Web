using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Controllers.SystemVariables
{
    public class BanksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BanksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Banks
        public async Task<IActionResult> Index()
        {
            return _context.Banks != null ?
                        View(await _context.Banks.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Banks'  is null.");
        }

        // GET: Banks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banks == null)
            {
                return NotFound();
            }

            return View(banks);
        }

        // GET: Banks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,BankName,NumberOfBranches,accountNumberLength,Id,DateCreated,DateModified")] Banks banks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(banks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(banks);
        }

        // GET: Banks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks.FindAsync(id);
            if (banks == null)
            {
                return NotFound();
            }
            return View(banks);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,BankName,NumberOfBranches,accountNumberLength,Id,DateCreated,DateModified")] Banks banks)
        {
            if (id != banks.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BanksExists(banks.Id))
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
            return View(banks);
        }

        // GET: Banks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Banks == null)
            {
                return NotFound();
            }

            var banks = await _context.Banks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (banks == null)
            {
                return NotFound();
            }

            return View(banks);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Banks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Banks'  is null.");
            }
            var banks = await _context.Banks.FindAsync(id);
            if (banks != null)
            {
                _context.Banks.Remove(banks);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BanksExists(int id)
        {
            return (_context.Banks?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
