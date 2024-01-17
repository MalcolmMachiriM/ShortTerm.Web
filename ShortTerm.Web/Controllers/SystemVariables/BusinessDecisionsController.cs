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
    public class BusinessDecisionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusinessDecisionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BusinessDecisions
        public async Task<IActionResult> Index()
        {
            return _context.BusinessDecisions != null ?
                        View(await _context.BusinessDecisions.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.BusinessDecisions'  is null.");
        }

        // GET: BusinessDecisions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BusinessDecisions == null)
            {
                return NotFound();
            }

            var businessDecisions = await _context.BusinessDecisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessDecisions == null)
            {
                return NotFound();
            }

            return View(businessDecisions);
        }

        // GET: BusinessDecisions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BusinessDecisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Description,Id,DateCreated,DateModified")] BusinessDecisions businessDecisions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessDecisions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(businessDecisions);
        }

        // GET: BusinessDecisions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BusinessDecisions == null)
            {
                return NotFound();
            }

            var businessDecisions = await _context.BusinessDecisions.FindAsync(id);
            if (businessDecisions == null)
            {
                return NotFound();
            }
            return View(businessDecisions);
        }

        // POST: BusinessDecisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,Description,Id,DateCreated,DateModified")] BusinessDecisions businessDecisions)
        {
            if (id != businessDecisions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(businessDecisions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessDecisionsExists(businessDecisions.Id))
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
            return View(businessDecisions);
        }

        // GET: BusinessDecisions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BusinessDecisions == null)
            {
                return NotFound();
            }

            var businessDecisions = await _context.BusinessDecisions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessDecisions == null)
            {
                return NotFound();
            }

            return View(businessDecisions);
        }

        // POST: BusinessDecisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BusinessDecisions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BusinessDecisions'  is null.");
            }
            var businessDecisions = await _context.BusinessDecisions.FindAsync(id);
            if (businessDecisions != null)
            {
                _context.BusinessDecisions.Remove(businessDecisions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessDecisionsExists(int id)
        {
            return (_context.BusinessDecisions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
