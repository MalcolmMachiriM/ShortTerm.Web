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
    public class LocationOfPropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationOfPropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LocationOfProperties
        public async Task<IActionResult> Index()
        {
              return _context.LocationOfProperty != null ? 
                          View(await _context.LocationOfProperty.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.LocationOfProperty'  is null.");
        }

        // GET: LocationOfProperties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LocationOfProperty == null)
            {
                return NotFound();
            }

            var locationOfProperty = await _context.LocationOfProperty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationOfProperty == null)
            {
                return NotFound();
            }

            return View(locationOfProperty);
        }

        // GET: LocationOfProperties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocationOfProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] LocationOfProperty locationOfProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationOfProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationOfProperty);
        }

        // GET: LocationOfProperties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LocationOfProperty == null)
            {
                return NotFound();
            }

            var locationOfProperty = await _context.LocationOfProperty.FindAsync(id);
            if (locationOfProperty == null)
            {
                return NotFound();
            }
            return View(locationOfProperty);
        }

        // POST: LocationOfProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] LocationOfProperty locationOfProperty)
        {
            if (id != locationOfProperty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationOfProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationOfPropertyExists(locationOfProperty.Id))
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
            return View(locationOfProperty);
        }

        // GET: LocationOfProperties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LocationOfProperty == null)
            {
                return NotFound();
            }

            var locationOfProperty = await _context.LocationOfProperty
                .FirstOrDefaultAsync(m => m.Id == id);
            if (locationOfProperty == null)
            {
                return NotFound();
            }

            return View(locationOfProperty);
        }

        // POST: LocationOfProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LocationOfProperty == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LocationOfProperty'  is null.");
            }
            var locationOfProperty = await _context.LocationOfProperty.FindAsync(id);
            if (locationOfProperty != null)
            {
                _context.LocationOfProperty.Remove(locationOfProperty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationOfPropertyExists(int id)
        {
          return (_context.LocationOfProperty?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
