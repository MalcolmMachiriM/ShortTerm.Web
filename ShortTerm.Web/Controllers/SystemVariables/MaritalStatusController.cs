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
    public class MaritalStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaritalStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MaritalStatus
        public async Task<IActionResult> Index()
        {
            return _context.MaritalStatuses != null ?
                        View(await _context.MaritalStatuses.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.MaritalStatuses'  is null.");
        }

        // GET: MaritalStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MaritalStatuses == null)
            {
                return NotFound();
            }

            var maritalStatus = await _context.MaritalStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maritalStatus == null)
            {
                return NotFound();
            }

            return View(maritalStatus);
        }

        // GET: MaritalStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MaritalStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Status")] MaritalStatus maritalStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maritalStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maritalStatus);
        }

        // GET: MaritalStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MaritalStatuses == null)
            {
                return NotFound();
            }

            var maritalStatus = await _context.MaritalStatuses.FindAsync(id);
            if (maritalStatus == null)
            {
                return NotFound();
            }
            return View(maritalStatus);
        }

        // POST: MaritalStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Status")] MaritalStatus maritalStatus)
        {
            if (id != maritalStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maritalStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaritalStatusExists(maritalStatus.Id))
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
            return View(maritalStatus);
        }

        // GET: MaritalStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MaritalStatuses == null)
            {
                return NotFound();
            }

            var maritalStatus = await _context.MaritalStatuses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maritalStatus == null)
            {
                return NotFound();
            }

            return View(maritalStatus);
        }

        // POST: MaritalStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MaritalStatuses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MaritalStatuses'  is null.");
            }
            var maritalStatus = await _context.MaritalStatuses.FindAsync(id);
            if (maritalStatus != null)
            {
                _context.MaritalStatuses.Remove(maritalStatus);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaritalStatusExists(int id)
        {
            return (_context.MaritalStatuses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
