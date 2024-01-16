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
    public class AddressTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddressTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AddressTypes
        public async Task<IActionResult> Index()
        {
            return _context.AddressTypes != null ?
                        View(await _context.AddressTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.AddressTypes'  is null.");
        }

        // GET: AddressTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AddressTypes == null)
            {
                return NotFound();
            }

            var addressTypes = await _context.AddressTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressTypes == null)
            {
                return NotFound();
            }

            return View(addressTypes);
        }

        // GET: AddressTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddressTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Id,DateCreated,DateModified")] AddressTypes addressTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressTypes);
        }

        // GET: AddressTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AddressTypes == null)
            {
                return NotFound();
            }

            var addressTypes = await _context.AddressTypes.FindAsync(id);
            if (addressTypes == null)
            {
                return NotFound();
            }
            return View(addressTypes);
        }

        // POST: AddressTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Type,Id,DateCreated,DateModified")] AddressTypes addressTypes)
        {
            if (id != addressTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressTypesExists(addressTypes.Id))
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
            return View(addressTypes);
        }

        // GET: AddressTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AddressTypes == null)
            {
                return NotFound();
            }

            var addressTypes = await _context.AddressTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressTypes == null)
            {
                return NotFound();
            }

            return View(addressTypes);
        }

        // POST: AddressTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AddressTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AddressTypes'  is null.");
            }
            var addressTypes = await _context.AddressTypes.FindAsync(id);
            if (addressTypes != null)
            {
                _context.AddressTypes.Remove(addressTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressTypesExists(int id)
        {
            return (_context.AddressTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
