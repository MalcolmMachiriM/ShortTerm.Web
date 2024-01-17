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
    public class AccountTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AccountTypes
        public async Task<IActionResult> Index()
        {
            return _context.AccountTypes != null ?
                        View(await _context.AccountTypes.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.AccountTypes'  is null.");
        }

        // GET: AccountTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AccountTypes == null)
            {
                return NotFound();
            }

            var accountTypes = await _context.AccountTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountTypes == null)
            {
                return NotFound();
            }

            return View(accountTypes);
        }

        // GET: AccountTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Type,Id,DateCreated,DateModified")] AccountTypes accountTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountTypes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accountTypes);
        }

        // GET: AccountTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AccountTypes == null)
            {
                return NotFound();
            }

            var accountTypes = await _context.AccountTypes.FindAsync(id);
            if (accountTypes == null)
            {
                return NotFound();
            }
            return View(accountTypes);
        }

        // POST: AccountTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Type,Id,DateCreated,DateModified")] AccountTypes accountTypes)
        {
            if (id != accountTypes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountTypes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountTypesExists(accountTypes.Id))
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
            return View(accountTypes);
        }

        // GET: AccountTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AccountTypes == null)
            {
                return NotFound();
            }

            var accountTypes = await _context.AccountTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountTypes == null)
            {
                return NotFound();
            }

            return View(accountTypes);
        }

        // POST: AccountTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AccountTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AccountTypes'  is null.");
            }
            var accountTypes = await _context.AccountTypes.FindAsync(id);
            if (accountTypes != null)
            {
                _context.AccountTypes.Remove(accountTypes);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountTypesExists(int id)
        {
            return (_context.AccountTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
