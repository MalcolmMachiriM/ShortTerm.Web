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
    public class HumanDemographicGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HumanDemographicGroupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HumanDemographicGroups
        public async Task<IActionResult> Index()
        {
            return _context.HumanDemographicGroups != null ?
                        View(await _context.HumanDemographicGroups.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.HumanDemographicGroups'  is null.");
        }

        // GET: HumanDemographicGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.HumanDemographicGroups == null)
            {
                return NotFound();
            }

            var humanDemographicGroups = await _context.HumanDemographicGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (humanDemographicGroups == null)
            {
                return NotFound();
            }

            return View(humanDemographicGroups);
        }

        // GET: HumanDemographicGroups/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HumanDemographicGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] HumanDemographicGroups humanDemographicGroups)
        {
            if (ModelState.IsValid)
            {
                _context.Add(humanDemographicGroups);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(humanDemographicGroups);
        }

        // GET: HumanDemographicGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.HumanDemographicGroups == null)
            {
                return NotFound();
            }

            var humanDemographicGroups = await _context.HumanDemographicGroups.FindAsync(id);
            if (humanDemographicGroups == null)
            {
                return NotFound();
            }
            return View(humanDemographicGroups);
        }

        // POST: HumanDemographicGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] HumanDemographicGroups humanDemographicGroups)
        {
            if (id != humanDemographicGroups.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(humanDemographicGroups);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HumanDemographicGroupsExists(humanDemographicGroups.Id))
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
            return View(humanDemographicGroups);
        }

        // GET: HumanDemographicGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.HumanDemographicGroups == null)
            {
                return NotFound();
            }

            var humanDemographicGroups = await _context.HumanDemographicGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (humanDemographicGroups == null)
            {
                return NotFound();
            }

            return View(humanDemographicGroups);
        }

        // POST: HumanDemographicGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.HumanDemographicGroups == null)
            {
                return Problem("Entity set 'ApplicationDbContext.HumanDemographicGroups'  is null.");
            }
            var humanDemographicGroups = await _context.HumanDemographicGroups.FindAsync(id);
            if (humanDemographicGroups != null)
            {
                _context.HumanDemographicGroups.Remove(humanDemographicGroups);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HumanDemographicGroupsExists(int id)
        {
            return (_context.HumanDemographicGroups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
