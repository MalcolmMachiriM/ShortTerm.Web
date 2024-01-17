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
    public class StateOfPropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StateOfPropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StateOfProperties
        public async Task<IActionResult> Index()
        {
              return _context.StateOfProperty != null ? 
                          View(await _context.StateOfProperty.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.StateOfProperty'  is null.");
        }

        // GET: StateOfProperties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StateOfProperty == null)
            {
                return NotFound();
            }

            var stateOfProperty = await _context.StateOfProperty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stateOfProperty == null)
            {
                return NotFound();
            }

            return View(stateOfProperty);
        }

        // GET: StateOfProperties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StateOfProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] StateOfProperty stateOfProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stateOfProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stateOfProperty);
        }

        // GET: StateOfProperties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StateOfProperty == null)
            {
                return NotFound();
            }

            var stateOfProperty = await _context.StateOfProperty.FindAsync(id);
            if (stateOfProperty == null)
            {
                return NotFound();
            }
            return View(stateOfProperty);
        }

        // POST: StateOfProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] StateOfProperty stateOfProperty)
        {
            if (id != stateOfProperty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stateOfProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StateOfPropertyExists(stateOfProperty.Id))
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
            return View(stateOfProperty);
        }

        // GET: StateOfProperties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StateOfProperty == null)
            {
                return NotFound();
            }

            var stateOfProperty = await _context.StateOfProperty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stateOfProperty == null)
            {
                return NotFound();
            }

            return View(stateOfProperty);
        }

        // POST: StateOfProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StateOfProperty == null)
            {
                return Problem("Entity set 'ApplicationDbContext.StateOfProperty'  is null.");
            }
            var stateOfProperty = await _context.StateOfProperty.FindAsync(id);
            if (stateOfProperty != null)
            {
                _context.StateOfProperty.Remove(stateOfProperty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StateOfPropertyExists(int id)
        {
          return (_context.StateOfProperty?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
