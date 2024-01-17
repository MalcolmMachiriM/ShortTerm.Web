using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class ReassurersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public ReassurersController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: Reassurers
        public async Task<IActionResult> Index()
        {
              return _context.Reassurers != null ? 
                          View(await _context.Reassurers.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Reassurers'  is null.");
        }

        // GET: Reassurers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Reassurers == null)
            {
                return NotFound();
            }

            var reassurer = await _context.Reassurers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reassurer == null)
            {
                return NotFound();
            }

            return View(reassurer);
        }

        // GET: Reassurers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reassurers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReasurerCreateVM model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Reassurers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Reassurers == null)
            {
                return NotFound();
            }

            var reassurer = await _context.Reassurers.FindAsync(id);
            if (reassurer == null)
            {
                return NotFound();
            }
            return View(reassurer);
        }

        // POST: Reassurers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientFullname,Code,Manager,ContractType,ContractStartDate,ContractEndDate,Id,DateCreated,DateModified")] Reassurer reassurer)
        {
            if (id != reassurer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reassurer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReassurerExists(reassurer.Id))
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
            return View(reassurer);
        }

        // GET: Reassurers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Reassurers == null)
            {
                return NotFound();
            }

            var reassurer = await _context.Reassurers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reassurer == null)
            {
                return NotFound();
            }

            return View(reassurer);
        }

        // POST: Reassurers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Reassurers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reassurers'  is null.");
            }
            var reassurer = await _context.Reassurers.FindAsync(id);
            if (reassurer != null)
            {
                _context.Reassurers.Remove(reassurer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReassurerExists(int id)
        {
          return (_context.Reassurers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
