using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class UnderWritingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UnderWritingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UnderWritings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.UnderWritings.Include(u => u.Client).Include(u => u.Policy);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: UnderWritings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UnderWritings == null)
            {
                return NotFound();
            }

            var underWriting = await _context.UnderWritings
                .Include(u => u.Client)
                .Include(u => u.Policy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (underWriting == null)
            {
                return NotFound();
            }

            return View(underWriting);
        }

        // GET: UnderWritings/Create
        public IActionResult Create(int id=0)
        {
            var model = new UnderWritingVM
            {
                StateOfProps = new SelectList(_context.Clients, "Id", "FirstName"),
                LocationOfProps = new SelectList(_context.Clients, "Id", "FirstName"),
                SecurityOfProps = new SelectList(_context.Clients, "Id", "FirstName"),
                PrimaryUseOfProps = new SelectList(_context.Clients, "Id", "FirstName")
            };
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id");
            return View();
        }

        // POST: UnderWritings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientId,PolicyId,ClientProposedValueOfAsset,StateOfProperty,LocationOfProperty,SecurityOfPropertyScore,PrimaryUseOfPropertyScore,AdditionalNotes,Approved,Id,DateCreated,DateModified")] UnderWriting underWriting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(underWriting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", underWriting.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", underWriting.PolicyId);
            return View(underWriting);
        }

        // GET: UnderWritings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UnderWritings == null)
            {
                return NotFound();
            }

            var underWriting = await _context.UnderWritings.FindAsync(id);
            if (underWriting == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", underWriting.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", underWriting.PolicyId);
            return View(underWriting);
        }

        // POST: UnderWritings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,PolicyId,ClientProposedValueOfAsset,StateOfProperty,LocationOfProperty,SecurityOfPropertyScore,PrimaryUseOfPropertyScore,AdditionalNotes,Approved,Id,DateCreated,DateModified")] UnderWriting underWriting)
        {
            if (id != underWriting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(underWriting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnderWritingExists(underWriting.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", underWriting.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", underWriting.PolicyId);
            return View(underWriting);
        }

        // GET: UnderWritings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UnderWritings == null)
            {
                return NotFound();
            }

            var underWriting = await _context.UnderWritings
                .Include(u => u.Client)
                .Include(u => u.Policy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (underWriting == null)
            {
                return NotFound();
            }

            return View(underWriting);
        }

        // POST: UnderWritings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UnderWritings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UnderWritings'  is null.");
            }
            var underWriting = await _context.UnderWritings.FindAsync(id);
            if (underWriting != null)
            {
                _context.UnderWritings.Remove(underWriting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnderWritingExists(int id)
        {
          return (_context.UnderWritings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
