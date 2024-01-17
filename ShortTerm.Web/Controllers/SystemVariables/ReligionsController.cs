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
    public class ReligionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReligionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Religions
        public async Task<IActionResult> Index()
        {
            return _context.Religions_1 != null ?
                        View(await _context.Religions_1.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Religions_1'  is null.");
        }

        // GET: Religions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Religions_1 == null)
            {
                return NotFound();
            }

            var religions = await _context.Religions_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (religions == null)
            {
                return NotFound();
            }

            return View(religions);
        }

        // GET: Religions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Religions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Religion,Id,DateCreated,DateModified")] Religions religions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(religions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(religions);
        }

        // GET: Religions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Religions_1 == null)
            {
                return NotFound();
            }

            var religions = await _context.Religions_1.FindAsync(id);
            if (religions == null)
            {
                return NotFound();
            }
            return View(religions);
        }

        // POST: Religions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Religion,Id,DateCreated,DateModified")] Religions religions)
        {
            if (id != religions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(religions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReligionsExists(religions.Id))
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
            return View(religions);
        }

        // GET: Religions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Religions_1 == null)
            {
                return NotFound();
            }

            var religions = await _context.Religions_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (religions == null)
            {
                return NotFound();
            }

            return View(religions);
        }

        // POST: Religions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Religions_1 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Religions_1'  is null.");
            }
            var religions = await _context.Religions_1.FindAsync(id);
            if (religions != null)
            {
                _context.Religions_1.Remove(religions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReligionsExists(int id)
        {
            return (_context.Religions_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
