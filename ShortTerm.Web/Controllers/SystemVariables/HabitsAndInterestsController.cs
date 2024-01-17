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
    public class HabitsAndInterestsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HabitsAndInterestsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HabitsAndInterests
        public async Task<IActionResult> Index()
        {
            return _context.HabitsAndInterests != null ?
                        View(await _context.HabitsAndInterests.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.HabitsAndInterests'  is null.");
        }

        // GET: HabitsAndInterests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HabitsAndInterests == null)
            {
                return NotFound();
            }

            var habitsAndInterests = await _context.HabitsAndInterests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habitsAndInterests == null)
            {
                return NotFound();
            }

            return View(habitsAndInterests);
        }

        // GET: HabitsAndInterests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HabitsAndInterests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HabitOrInterest,Id,DateCreated,DateModified")] HabitsAndInterests habitsAndInterests)
        {
            if (ModelState.IsValid)
            {
                _context.Add(habitsAndInterests);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(habitsAndInterests);
        }

        // GET: HabitsAndInterests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HabitsAndInterests == null)
            {
                return NotFound();
            }

            var habitsAndInterests = await _context.HabitsAndInterests.FindAsync(id);
            if (habitsAndInterests == null)
            {
                return NotFound();
            }
            return View(habitsAndInterests);
        }

        // POST: HabitsAndInterests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HabitOrInterest,Id,DateCreated,DateModified")] HabitsAndInterests habitsAndInterests)
        {
            if (id != habitsAndInterests.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(habitsAndInterests);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HabitsAndInterestsExists(habitsAndInterests.Id))
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
            return View(habitsAndInterests);
        }

        // GET: HabitsAndInterests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HabitsAndInterests == null)
            {
                return NotFound();
            }

            var habitsAndInterests = await _context.HabitsAndInterests
                .FirstOrDefaultAsync(m => m.Id == id);
            if (habitsAndInterests == null)
            {
                return NotFound();
            }

            return View(habitsAndInterests);
        }

        // POST: HabitsAndInterests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HabitsAndInterests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HabitsAndInterests'  is null.");
            }
            var habitsAndInterests = await _context.HabitsAndInterests.FindAsync(id);
            if (habitsAndInterests != null)
            {
                _context.HabitsAndInterests.Remove(habitsAndInterests);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HabitsAndInterestsExists(int id)
        {
            return (_context.HabitsAndInterests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
