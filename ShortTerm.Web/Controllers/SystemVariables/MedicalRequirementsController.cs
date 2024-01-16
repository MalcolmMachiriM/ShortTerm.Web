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
    public class MedicalRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalRequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalRequirements
        public async Task<IActionResult> Index()
        {
            return _context.MedicalRequirements != null ?
                        View(await _context.MedicalRequirements.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.MedicalRequirements'  is null.");
        }

        // GET: MedicalRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MedicalRequirements == null)
            {
                return NotFound();
            }

            var medicalRequirements = await _context.MedicalRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalRequirements == null)
            {
                return NotFound();
            }

            return View(medicalRequirements);
        }

        // GET: MedicalRequirements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicalRequirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Code,Description,Tariff,Id,DateCreated,DateModified")] MedicalRequirements medicalRequirements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalRequirements);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicalRequirements);
        }

        // GET: MedicalRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MedicalRequirements == null)
            {
                return NotFound();
            }

            var medicalRequirements = await _context.MedicalRequirements.FindAsync(id);
            if (medicalRequirements == null)
            {
                return NotFound();
            }
            return View(medicalRequirements);
        }

        // POST: MedicalRequirements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Code,Description,Tariff,Id,DateCreated,DateModified")] MedicalRequirements medicalRequirements)
        {
            if (id != medicalRequirements.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalRequirements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalRequirementsExists(medicalRequirements.Id))
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
            return View(medicalRequirements);
        }

        // GET: MedicalRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MedicalRequirements == null)
            {
                return NotFound();
            }

            var medicalRequirements = await _context.MedicalRequirements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicalRequirements == null)
            {
                return NotFound();
            }

            return View(medicalRequirements);
        }

        // POST: MedicalRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MedicalRequirements == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MedicalRequirements'  is null.");
            }
            var medicalRequirements = await _context.MedicalRequirements.FindAsync(id);
            if (medicalRequirements != null)
            {
                _context.MedicalRequirements.Remove(medicalRequirements);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalRequirementsExists(int id)
        {
            return (_context.MedicalRequirements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
