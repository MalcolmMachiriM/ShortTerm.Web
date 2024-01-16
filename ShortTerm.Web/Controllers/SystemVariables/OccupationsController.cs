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
    public class OccupationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OccupationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Occupations
        public async Task<IActionResult> Index()
        {
            return _context.Occupations != null ?
                        View(await _context.Occupations.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Occupations'  is null.");
        }

        // GET: Occupations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Occupations == null)
            {
                return NotFound();
            }

            var occupations = await _context.Occupations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (occupations == null)
            {
                return NotFound();
            }

            return View(occupations);
        }

        // GET: Occupations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Occupations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] Occupations occupations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(occupations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(occupations);
        }

        // GET: Occupations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Occupations == null)
            {
                return NotFound();
            }

            var occupations = await _context.Occupations.FindAsync(id);
            if (occupations == null)
            {
                return NotFound();
            }
            return View(occupations);
        }

        // POST: Occupations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] Occupations occupations)
        {
            if (id != occupations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(occupations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OccupationsExists(occupations.Id))
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
            return View(occupations);
        }

        // GET: Occupations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Occupations == null)
            {
                return NotFound();
            }

            var occupations = await _context.Occupations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (occupations == null)
            {
                return NotFound();
            }

            return View(occupations);
        }

        // POST: Occupations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Occupations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Occupations'  is null.");
            }
            var occupations = await _context.Occupations.FindAsync(id);
            if (occupations != null)
            {
                _context.Occupations.Remove(occupations);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OccupationsExists(int id)
        {
            return (_context.Occupations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
