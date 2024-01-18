using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;
using ShortTerm.Web.Data.SystemVariables;

namespace ShortTerm.Web.Controllers.SystemVariables
{
    public class PrimaryUseOfPropertyScoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrimaryUseOfPropertyScoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PrimaryUseOfPropertyScores
        public async Task<IActionResult> Index()
        {
              return _context.PrimaryUseOfPropertyScore != null ? 
                          View(await _context.PrimaryUseOfPropertyScore.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PrimaryUseOfPropertyScore'  is null.");
        }

        // GET: PrimaryUseOfPropertyScores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PrimaryUseOfPropertyScore == null)
            {
                return NotFound();
            }

            var primaryUseOfPropertyScore = await _context.PrimaryUseOfPropertyScore
                .FirstOrDefaultAsync(m => m.Id == id);
            if (primaryUseOfPropertyScore == null)
            {
                return NotFound();
            }

            return View(primaryUseOfPropertyScore);
        }

        // GET: PrimaryUseOfPropertyScores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PrimaryUseOfPropertyScores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] PrimaryUseOfPropertyScore primaryUseOfPropertyScore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(primaryUseOfPropertyScore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(primaryUseOfPropertyScore);
        }

        // GET: PrimaryUseOfPropertyScores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PrimaryUseOfPropertyScore == null)
            {
                return NotFound();
            }

            var primaryUseOfPropertyScore = await _context.PrimaryUseOfPropertyScore.FindAsync(id);
            if (primaryUseOfPropertyScore == null)
            {
                return NotFound();
            }
            return View(primaryUseOfPropertyScore);
        }

        // POST: PrimaryUseOfPropertyScores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] PrimaryUseOfPropertyScore primaryUseOfPropertyScore)
        {
            if (id != primaryUseOfPropertyScore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(primaryUseOfPropertyScore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrimaryUseOfPropertyScoreExists(primaryUseOfPropertyScore.Id))
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
            return View(primaryUseOfPropertyScore);
        }

        // GET: PrimaryUseOfPropertyScores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PrimaryUseOfPropertyScore == null)
            {
                return NotFound();
            }

            var primaryUseOfPropertyScore = await _context.PrimaryUseOfPropertyScore
                .FirstOrDefaultAsync(m => m.Id == id);
            if (primaryUseOfPropertyScore == null)
            {
                return NotFound();
            }

            return View(primaryUseOfPropertyScore);
        }

        // POST: PrimaryUseOfPropertyScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PrimaryUseOfPropertyScore == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PrimaryUseOfPropertyScore'  is null.");
            }
            var primaryUseOfPropertyScore = await _context.PrimaryUseOfPropertyScore.FindAsync(id);
            if (primaryUseOfPropertyScore != null)
            {
                _context.PrimaryUseOfPropertyScore.Remove(primaryUseOfPropertyScore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrimaryUseOfPropertyScoreExists(int id)
        {
          return (_context.PrimaryUseOfPropertyScore?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
