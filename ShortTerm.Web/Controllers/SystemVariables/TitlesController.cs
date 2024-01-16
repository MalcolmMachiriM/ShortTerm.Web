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
    public class TitlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TitlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Titles
        public async Task<IActionResult> Index()
        {
            return _context.Titles_1 != null ?
                        View(await _context.Titles_1.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Titles_1'  is null.");
        }

        // GET: Titles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Titles_1 == null)
            {
                return NotFound();
            }

            var titles = await _context.Titles_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titles == null)
            {
                return NotFound();
            }

            return View(titles);
        }

        // GET: Titles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Titles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] Titles titles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(titles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(titles);
        }

        // GET: Titles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Titles_1 == null)
            {
                return NotFound();
            }

            var titles = await _context.Titles_1.FindAsync(id);
            if (titles == null)
            {
                return NotFound();
            }
            return View(titles);
        }

        // POST: Titles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] Titles titles)
        {
            if (id != titles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(titles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TitlesExists(titles.Id))
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
            return View(titles);
        }

        // GET: Titles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Titles_1 == null)
            {
                return NotFound();
            }

            var titles = await _context.Titles_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (titles == null)
            {
                return NotFound();
            }

            return View(titles);
        }

        // POST: Titles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Titles_1 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Titles_1'  is null.");
            }
            var titles = await _context.Titles_1.FindAsync(id);
            if (titles != null)
            {
                _context.Titles_1.Remove(titles);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TitlesExists(int id)
        {
            return (_context.Titles_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
