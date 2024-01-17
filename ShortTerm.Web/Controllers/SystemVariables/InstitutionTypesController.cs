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
    public class InstitutionTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InstitutionTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InstitutionTypes
        public async Task<IActionResult> Index()
        {
            return _context.InstitutionTypes != null ?
                        View(await _context.InstitutionTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.InstitutionTypes'  is null.");
        }

        // GET: InstitutionTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InstitutionTypes == null)
            {
                return NotFound();
            }

            var institutionTypes = await _context.InstitutionTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institutionTypes == null)
            {
                return NotFound();
            }

            return View(institutionTypes);
        }

        // GET: InstitutionTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InstitutionTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] InstitutionTypes institutionTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(institutionTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(institutionTypes);
        }

        // GET: InstitutionTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InstitutionTypes == null)
            {
                return NotFound();
            }

            var institutionTypes = await _context.InstitutionTypes.FindAsync(id);
            if (institutionTypes == null)
            {
                return NotFound();
            }
            return View(institutionTypes);
        }

        // POST: InstitutionTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] InstitutionTypes institutionTypes)
        {
            if (id != institutionTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institutionTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitutionTypesExists(institutionTypes.Id))
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
            return View(institutionTypes);
        }

        // GET: InstitutionTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InstitutionTypes == null)
            {
                return NotFound();
            }

            var institutionTypes = await _context.InstitutionTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (institutionTypes == null)
            {
                return NotFound();
            }

            return View(institutionTypes);
        }

        // POST: InstitutionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InstitutionTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.InstitutionTypes'  is null.");
            }
            var institutionTypes = await _context.InstitutionTypes.FindAsync(id);
            if (institutionTypes != null)
            {
                _context.InstitutionTypes.Remove(institutionTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitutionTypesExists(int id)
        {
            return (_context.InstitutionTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
