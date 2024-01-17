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
    public class RequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Requirements
        public async Task<IActionResult> Index()
        {
            return _context.Requirements_1 != null ?
                        View(await _context.Requirements_1.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Requirements_1'  is null.");
        }

        // GET: Requirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Requirements_1 == null)
            {
                return NotFound();
            }

            var requirements = await _context.Requirements_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requirements == null)
            {
                return NotFound();
            }

            return View(requirements);
        }

        // GET: Requirements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] Requirements requirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requirements);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requirements);
        }

        // GET: Requirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Requirements_1 == null)
            {
                return NotFound();
            }

            var requirements = await _context.Requirements_1.FindAsync(id);
            if (requirements == null)
            {
                return NotFound();
            }
            return View(requirements);
        }

        // POST: Requirements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] Requirements requirements)
        {
            if (id != requirements.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requirements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequirementsExists(requirements.Id))
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
            return View(requirements);
        }

        // GET: Requirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Requirements_1 == null)
            {
                return NotFound();
            }

            var requirements = await _context.Requirements_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requirements == null)
            {
                return NotFound();
            }

            return View(requirements);
        }

        // POST: Requirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Requirements_1 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Requirements_1'  is null.");
            }
            var requirements = await _context.Requirements_1.FindAsync(id);
            if (requirements != null)
            {
                _context.Requirements_1.Remove(requirements);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequirementsExists(int id)
        {
            return (_context.Requirements_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
