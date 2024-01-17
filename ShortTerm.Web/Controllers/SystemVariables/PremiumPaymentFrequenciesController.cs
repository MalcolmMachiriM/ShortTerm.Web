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
    public class PremiumPaymentFrequenciesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PremiumPaymentFrequenciesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PremiumPaymentFrequencies
        public async Task<IActionResult> Index()
        {
            return _context.PremiumPaymentFrequencies != null ?
                        View(await _context.PremiumPaymentFrequencies.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.PremiumPaymentFrequencies'  is null.");
        }

        // GET: PremiumPaymentFrequencies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PremiumPaymentFrequencies == null)
            {
                return NotFound();
            }

            var premiumPaymentFrequencies = await _context.PremiumPaymentFrequencies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (premiumPaymentFrequencies == null)
            {
                return NotFound();
            }

            return View(premiumPaymentFrequencies);
        }

        // GET: PremiumPaymentFrequencies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PremiumPaymentFrequencies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] PremiumPaymentFrequencies premiumPaymentFrequencies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(premiumPaymentFrequencies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(premiumPaymentFrequencies);
        }

        // GET: PremiumPaymentFrequencies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PremiumPaymentFrequencies == null)
            {
                return NotFound();
            }

            var premiumPaymentFrequencies = await _context.PremiumPaymentFrequencies.FindAsync(id);
            if (premiumPaymentFrequencies == null)
            {
                return NotFound();
            }
            return View(premiumPaymentFrequencies);
        }

        // POST: PremiumPaymentFrequencies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] PremiumPaymentFrequencies premiumPaymentFrequencies)
        {
            if (id != premiumPaymentFrequencies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(premiumPaymentFrequencies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PremiumPaymentFrequenciesExists(premiumPaymentFrequencies.Id))
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
            return View(premiumPaymentFrequencies);
        }

        // GET: PremiumPaymentFrequencies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PremiumPaymentFrequencies == null)
            {
                return NotFound();
            }

            var premiumPaymentFrequencies = await _context.PremiumPaymentFrequencies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (premiumPaymentFrequencies == null)
            {
                return NotFound();
            }

            return View(premiumPaymentFrequencies);
        }

        // POST: PremiumPaymentFrequencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PremiumPaymentFrequencies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PremiumPaymentFrequencies'  is null.");
            }
            var premiumPaymentFrequencies = await _context.PremiumPaymentFrequencies.FindAsync(id);
            if (premiumPaymentFrequencies != null)
            {
                _context.PremiumPaymentFrequencies.Remove(premiumPaymentFrequencies);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PremiumPaymentFrequenciesExists(int id)
        {
            return (_context.PremiumPaymentFrequencies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
