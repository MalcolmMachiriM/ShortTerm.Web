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
    public class InterestRateFrequenciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InterestRateFrequenciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InterestRateFrequencies
        public async Task<IActionResult> Index()
        {
            return _context.InterestRateFrequencies != null ?
                        View(await _context.InterestRateFrequencies.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.InterestRateFrequencies'  is null.");
        }

        // GET: InterestRateFrequencies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InterestRateFrequencies == null)
            {
                return NotFound();
            }

            var interestRateFrequencies = await _context.InterestRateFrequencies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interestRateFrequencies == null)
            {
                return NotFound();
            }

            return View(interestRateFrequencies);
        }

        // GET: InterestRateFrequencies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InterestRateFrequencies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] InterestRateFrequencies interestRateFrequencies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interestRateFrequencies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interestRateFrequencies);
        }

        // GET: InterestRateFrequencies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InterestRateFrequencies == null)
            {
                return NotFound();
            }

            var interestRateFrequencies = await _context.InterestRateFrequencies.FindAsync(id);
            if (interestRateFrequencies == null)
            {
                return NotFound();
            }
            return View(interestRateFrequencies);
        }

        // POST: InterestRateFrequencies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] InterestRateFrequencies interestRateFrequencies)
        {
            if (id != interestRateFrequencies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interestRateFrequencies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterestRateFrequenciesExists(interestRateFrequencies.Id))
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
            return View(interestRateFrequencies);
        }

        // GET: InterestRateFrequencies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InterestRateFrequencies == null)
            {
                return NotFound();
            }

            var interestRateFrequencies = await _context.InterestRateFrequencies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interestRateFrequencies == null)
            {
                return NotFound();
            }

            return View(interestRateFrequencies);
        }

        // POST: InterestRateFrequencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InterestRateFrequencies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.InterestRateFrequencies'  is null.");
            }
            var interestRateFrequencies = await _context.InterestRateFrequencies.FindAsync(id);
            if (interestRateFrequencies != null)
            {
                _context.InterestRateFrequencies.Remove(interestRateFrequencies);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterestRateFrequenciesExists(int id)
        {
            return (_context.InterestRateFrequencies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
