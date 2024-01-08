using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using ShortTerm.Web.Repositories;

namespace ShortTerm.Web.Controllers
{
    public class SchemesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly ISchemeRepository schemeRepository;

        public SchemesController(ApplicationDbContext context,IMapper mapper, ISchemeRepository schemeRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.schemeRepository = schemeRepository;
        }

        // GET: Schemes
        public async Task<IActionResult> Index()
        {
            var clients = await schemeRepository.GetAllAsync();
            var model = mapper.Map<List<SchemeVM>>(clients);
            return await schemeRepository.GetAllAsync() != null ?
                View(model) : Problem("No Schemea Found");
        }

        // GET: Schemes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheme == null)
            {
                return NotFound();
            }

            return View(scheme);
        }

        // GET: Schemes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schemes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SchemeVM model)
        {
            if (ModelState.IsValid)
            {
                var scheme = mapper.Map<Scheme>(model);
                await schemeRepository.AddAsync(scheme);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Schemes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes.FindAsync(id);
            if (scheme == null)
            {
                return NotFound();
            }
            return View(scheme);
        }

        // POST: Schemes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegNo,RegName,Taxno,ReassuranceNo,CommencementDate,ConversionDate,RulesAmmendment,RetentionLimit,InstitutionalClientsName,Id,DateCreated,DateModified")] Scheme scheme)
        {
            if (id != scheme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scheme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchemeExists(scheme.Id))
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
            return View(scheme);
        }

        // GET: Schemes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schemes == null)
            {
                return NotFound();
            }

            var scheme = await _context.Schemes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scheme == null)
            {
                return NotFound();
            }

            return View(scheme);
        }

        // POST: Schemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schemes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schemes'  is null.");
            }
            var scheme = await _context.Schemes.FindAsync(id);
            if (scheme != null)
            {
                _context.Schemes.Remove(scheme);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchemeExists(int id)
        {
          return (_context.Schemes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
