using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Controllers
{
    public class SchemesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchemesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schemes
        public async Task<IActionResult> Index()
        {
              return _context.Schemes != null ? 
                          View(await _context.Schemes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Schemes'  is null.");
        }

        // GET: Schemes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheme == null)
            {
                return NotFound();
            }

            return View(scheme);
        }

        // GET: Schemes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schemes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegNo,RegName,Taxno,ReassuranceNo,CommencementDate,ConversionDate,RulesAmmendment,RetentionLimit,InstitutionalClientsName,Id,DateCreated,DateModified")] Scheme scheme)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scheme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(scheme);
        }

        // GET: Schemes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes.FindAsync(id);
            if (scheme == null)
            {
                return NotFound();
            }
            return View(scheme);
        }

        // POST: Schemes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegNo,RegName,Taxno,ReassuranceNo,CommencementDate,ConversionDate,RulesAmmendment,RetentionLimit,InstitutionalClientsName,Id,DateCreated,DateModified")] Scheme scheme)
        {
            if (id != scheme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchemeExists(scheme.Id))
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
            return View(scheme);
        }

        // GET: Schemes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheme == null)
            {
                return NotFound();
            }

            return View(scheme);
        }

        // POST: Schemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schemes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schemes'  is null.");
            }
            var scheme = await _context.Schemes.FindAsync(id);
            if (scheme != null)
            {
                _context.Schemes.Remove(scheme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchemeExists(int id)
        {
          return (_context.Schemes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
