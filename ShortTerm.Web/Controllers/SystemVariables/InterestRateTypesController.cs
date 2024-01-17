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
    public class InterestRateTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InterestRateTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InterestRateTypes
        public async Task<IActionResult> Index()
        {
            return _context.InterestRateTypes != null ?
                        View(await _context.InterestRateTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.InterestRateTypes'  is null.");
        }

        // GET: InterestRateTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InterestRateTypes == null)
            {
                return NotFound();
            }

            var interestRateTypes = await _context.InterestRateTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interestRateTypes == null)
            {
                return NotFound();
            }

            return View(interestRateTypes);
        }

        // GET: InterestRateTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InterestRateTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] InterestRateTypes interestRateTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interestRateTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(interestRateTypes);
        }

        // GET: InterestRateTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InterestRateTypes == null)
            {
                return NotFound();
            }

            var interestRateTypes = await _context.InterestRateTypes.FindAsync(id);
            if (interestRateTypes == null)
            {
                return NotFound();
            }
            return View(interestRateTypes);
        }

        // POST: InterestRateTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] InterestRateTypes interestRateTypes)
        {
            if (id != interestRateTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interestRateTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InterestRateTypesExists(interestRateTypes.Id))
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
            return View(interestRateTypes);
        }

        // GET: InterestRateTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InterestRateTypes == null)
            {
                return NotFound();
            }

            var interestRateTypes = await _context.InterestRateTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (interestRateTypes == null)
            {
                return NotFound();
            }

            return View(interestRateTypes);
        }

        // POST: InterestRateTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InterestRateTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.InterestRateTypes'  is null.");
            }
            var interestRateTypes = await _context.InterestRateTypes.FindAsync(id);
            if (interestRateTypes != null)
            {
                _context.InterestRateTypes.Remove(interestRateTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InterestRateTypesExists(int id)
        {
            return (_context.InterestRateTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
