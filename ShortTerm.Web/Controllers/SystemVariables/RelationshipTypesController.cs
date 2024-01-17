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
    public class RelationshipTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelationshipTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RelationshipTypes
        public async Task<IActionResult> Index()
        {
            return _context.RelationshipTypes != null ?
                        View(await _context.RelationshipTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.RelationshipTypes'  is null.");
        }

        // GET: RelationshipTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RelationshipTypes == null)
            {
                return NotFound();
            }

            var relationshipTypes = await _context.RelationshipTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relationshipTypes == null)
            {
                return NotFound();
            }

            return View(relationshipTypes);
        }

        // GET: RelationshipTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RelationshipTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,DateCreated,DateModified")] RelationshipTypes relationshipTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(relationshipTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(relationshipTypes);
        }

        // GET: RelationshipTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RelationshipTypes == null)
            {
                return NotFound();
            }

            var relationshipTypes = await _context.RelationshipTypes.FindAsync(id);
            if (relationshipTypes == null)
            {
                return NotFound();
            }
            return View(relationshipTypes);
        }

        // POST: RelationshipTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Description,Id,DateCreated,DateModified")] RelationshipTypes relationshipTypes)
        {
            if (id != relationshipTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(relationshipTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RelationshipTypesExists(relationshipTypes.Id))
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
            return View(relationshipTypes);
        }

        // GET: RelationshipTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RelationshipTypes == null)
            {
                return NotFound();
            }

            var relationshipTypes = await _context.RelationshipTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (relationshipTypes == null)
            {
                return NotFound();
            }

            return View(relationshipTypes);
        }

        // POST: RelationshipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RelationshipTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RelationshipTypes'  is null.");
            }
            var relationshipTypes = await _context.RelationshipTypes.FindAsync(id);
            if (relationshipTypes != null)
            {
                _context.RelationshipTypes.Remove(relationshipTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RelationshipTypesExists(int id)
        {
            return (_context.RelationshipTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
