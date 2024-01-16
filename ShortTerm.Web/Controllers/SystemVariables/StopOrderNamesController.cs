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
    public class StopOrderNamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StopOrderNamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StopOrderNames
        public async Task<IActionResult> Index()
        {
            return _context.StopOrderName != null ?
                        View(await _context.StopOrderName.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.StopOrderName'  is null.");
        }

        // GET: StopOrderNames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StopOrderName == null)
            {
                return NotFound();
            }

            var stopOrderName = await _context.StopOrderName
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stopOrderName == null)
            {
                return NotFound();
            }

            return View(stopOrderName);
        }

        // GET: StopOrderNames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StopOrderNames/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,EmployerName,EmployeeNum,Id,DateCreated,DateModified")] StopOrderName stopOrderName)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stopOrderName);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stopOrderName);
        }

        // GET: StopOrderNames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StopOrderName == null)
            {
                return NotFound();
            }

            var stopOrderName = await _context.StopOrderName.FindAsync(id);
            if (stopOrderName == null)
            {
                return NotFound();
            }
            return View(stopOrderName);
        }

        // POST: StopOrderNames/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,EmployerName,EmployeeNum,Id,DateCreated,DateModified")] StopOrderName stopOrderName)
        {
            if (id != stopOrderName.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stopOrderName);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StopOrderNameExists(stopOrderName.Id))
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
            return View(stopOrderName);
        }

        // GET: StopOrderNames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StopOrderName == null)
            {
                return NotFound();
            }

            var stopOrderName = await _context.StopOrderName
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stopOrderName == null)
            {
                return NotFound();
            }

            return View(stopOrderName);
        }

        // POST: StopOrderNames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StopOrderName == null)
            {
                return Problem("Entity set 'ApplicationDbContext.StopOrderName'  is null.");
            }
            var stopOrderName = await _context.StopOrderName.FindAsync(id);
            if (stopOrderName != null)
            {
                _context.StopOrderName.Remove(stopOrderName);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StopOrderNameExists(int id)
        {
            return (_context.StopOrderName?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
