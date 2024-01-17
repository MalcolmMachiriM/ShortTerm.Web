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
    public class SecurityOfPropertyScoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecurityOfPropertyScoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SecurityOfPropertyScores
        public async Task<IActionResult> Index()
        {
              return _context.SecurityOfPropertyScore != null ? 
                          View(await _context.SecurityOfPropertyScore.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.SecurityOfPropertyScore'  is null.");
        }

        // GET: SecurityOfPropertyScores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SecurityOfPropertyScore == null)
            {
                return NotFound();
            }

            var securityOfPropertyScore = await _context.SecurityOfPropertyScore
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityOfPropertyScore == null)
            {
                return NotFound();
            }

            return View(securityOfPropertyScore);
        }

        // GET: SecurityOfPropertyScores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SecurityOfPropertyScores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] SecurityOfPropertyScore securityOfPropertyScore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(securityOfPropertyScore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(securityOfPropertyScore);
        }

        // GET: SecurityOfPropertyScores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SecurityOfPropertyScore == null)
            {
                return NotFound();
            }

            var securityOfPropertyScore = await _context.SecurityOfPropertyScore.FindAsync(id);
            if (securityOfPropertyScore == null)
            {
                return NotFound();
            }
            return View(securityOfPropertyScore);
        }

        // POST: SecurityOfPropertyScores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] SecurityOfPropertyScore securityOfPropertyScore)
        {
            if (id != securityOfPropertyScore.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(securityOfPropertyScore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SecurityOfPropertyScoreExists(securityOfPropertyScore.Id))
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
            return View(securityOfPropertyScore);
        }

        // GET: SecurityOfPropertyScores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SecurityOfPropertyScore == null)
            {
                return NotFound();
            }

            var securityOfPropertyScore = await _context.SecurityOfPropertyScore
                .FirstOrDefaultAsync(m => m.Id == id);
            if (securityOfPropertyScore == null)
            {
                return NotFound();
            }

            return View(securityOfPropertyScore);
        }

        // POST: SecurityOfPropertyScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SecurityOfPropertyScore == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SecurityOfPropertyScore'  is null.");
            }
            var securityOfPropertyScore = await _context.SecurityOfPropertyScore.FindAsync(id);
            if (securityOfPropertyScore != null)
            {
                _context.SecurityOfPropertyScore.Remove(securityOfPropertyScore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SecurityOfPropertyScoreExists(int id)
        {
          return (_context.SecurityOfPropertyScore?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
