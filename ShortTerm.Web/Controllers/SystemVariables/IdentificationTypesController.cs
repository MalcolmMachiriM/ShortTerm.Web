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
    public class IdentificationTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IdentificationTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IdentificationTypes
        public async Task<IActionResult> Index()
        {
            return _context.IdentificationTypes != null ?
                        View(await _context.IdentificationTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.IdentificationTypes'  is null.");
        }

        // GET: IdentificationTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationTypes = await _context.IdentificationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (identificationTypes == null)
            {
                return NotFound();
            }

            return View(identificationTypes);
        }

        // GET: IdentificationTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IdentificationTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdentificationTypeName,Format,MinimunRequiredLength,MaximumRequiredLength,Id,DateCreated,DateModified")] IdentificationTypes identificationTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(identificationTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(identificationTypes);
        }

        // GET: IdentificationTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationTypes = await _context.IdentificationTypes.FindAsync(id);
            if (identificationTypes == null)
            {
                return NotFound();
            }
            return View(identificationTypes);
        }

        // POST: IdentificationTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdentificationTypeName,Format,MinimunRequiredLength,MaximumRequiredLength,Id,DateCreated,DateModified")] IdentificationTypes identificationTypes)
        {
            if (id != identificationTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(identificationTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdentificationTypesExists(identificationTypes.Id))
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
            return View(identificationTypes);
        }

        // GET: IdentificationTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationTypes = await _context.IdentificationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (identificationTypes == null)
            {
                return NotFound();
            }

            return View(identificationTypes);
        }

        // POST: IdentificationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IdentificationTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IdentificationTypes'  is null.");
            }
            var identificationTypes = await _context.IdentificationTypes.FindAsync(id);
            if (identificationTypes != null)
            {
                _context.IdentificationTypes.Remove(identificationTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdentificationTypesExists(int id)
        {
            return (_context.IdentificationTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
