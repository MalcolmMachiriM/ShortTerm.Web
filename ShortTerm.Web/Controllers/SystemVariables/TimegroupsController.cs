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
    public class TimegroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TimegroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Timegroups
        public async Task<IActionResult> Index()
        {
            return _context.Timegroups != null ?
                        View(await _context.Timegroups.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Timegroups'  is null.");
        }

        // GET: Timegroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Timegroups == null)
            {
                return NotFound();
            }

            var timegroups = await _context.Timegroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timegroups == null)
            {
                return NotFound();
            }

            return View(timegroups);
        }

        // GET: Timegroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Timegroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] Timegroups timegroups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(timegroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timegroups);
        }

        // GET: Timegroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Timegroups == null)
            {
                return NotFound();
            }

            var timegroups = await _context.Timegroups.FindAsync(id);
            if (timegroups == null)
            {
                return NotFound();
            }
            return View(timegroups);
        }

        // POST: Timegroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] Timegroups timegroups)
        {
            if (id != timegroups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(timegroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimegroupsExists(timegroups.Id))
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
            return View(timegroups);
        }

        // GET: Timegroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Timegroups == null)
            {
                return NotFound();
            }

            var timegroups = await _context.Timegroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (timegroups == null)
            {
                return NotFound();
            }

            return View(timegroups);
        }

        // POST: Timegroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Timegroups == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Timegroups'  is null.");
            }
            var timegroups = await _context.Timegroups.FindAsync(id);
            if (timegroups != null)
            {
                _context.Timegroups.Remove(timegroups);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimegroupsExists(int id)
        {
            return (_context.Timegroups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
