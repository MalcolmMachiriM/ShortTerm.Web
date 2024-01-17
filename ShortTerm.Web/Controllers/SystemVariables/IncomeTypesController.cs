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
    public class IncomeTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IncomeTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IncomeTypes
        public async Task<IActionResult> Index()
        {
            return _context.IncomeTypes != null ?
                        View(await _context.IncomeTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.IncomeTypes'  is null.");
        }

        // GET: IncomeTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IncomeTypes == null)
            {
                return NotFound();
            }

            var incomeTypes = await _context.IncomeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incomeTypes == null)
            {
                return NotFound();
            }

            return View(incomeTypes);
        }

        // GET: IncomeTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IncomeTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncomeType,Id,DateCreated,DateModified")] IncomeTypes incomeTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(incomeTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(incomeTypes);
        }

        // GET: IncomeTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IncomeTypes == null)
            {
                return NotFound();
            }

            var incomeTypes = await _context.IncomeTypes.FindAsync(id);
            if (incomeTypes == null)
            {
                return NotFound();
            }
            return View(incomeTypes);
        }

        // POST: IncomeTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncomeType,Id,DateCreated,DateModified")] IncomeTypes incomeTypes)
        {
            if (id != incomeTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(incomeTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeTypesExists(incomeTypes.Id))
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
            return View(incomeTypes);
        }

        // GET: IncomeTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IncomeTypes == null)
            {
                return NotFound();
            }

            var incomeTypes = await _context.IncomeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (incomeTypes == null)
            {
                return NotFound();
            }

            return View(incomeTypes);
        }

        // POST: IncomeTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IncomeTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IncomeTypes'  is null.");
            }
            var incomeTypes = await _context.IncomeTypes.FindAsync(id);
            if (incomeTypes != null)
            {
                _context.IncomeTypes.Remove(incomeTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeTypesExists(int id)
        {
            return (_context.IncomeTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
