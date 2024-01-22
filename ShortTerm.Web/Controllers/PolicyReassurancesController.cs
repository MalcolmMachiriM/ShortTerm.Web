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

namespace ShortTerm.Web.Controllers
{
    public class PolicyReassurancesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IPolicyReassurancesRepository policyReassurancesRepository;
        private readonly IMapper mapper;

        public PolicyReassurancesController(ApplicationDbContext context, IPolicyReassurancesRepository policyReassurancesRepository,IMapper mapper)
        {
            _context = context;
            this.policyReassurancesRepository = policyReassurancesRepository;
            this.mapper = mapper;
        }

        // GET: PolicyReassurances
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PolicyReassurances.Include(p => p.ReassuranceType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PolicyReassurances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PolicyReassurances == null)
            {
                return NotFound();
            }

            var policyReassurance = await _context.PolicyReassurances
                .Include(p => p.ReassuranceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policyReassurance == null)
            {
                return NotFound();
            }

            return View(policyReassurance);
        }

        // GET: PolicyReassurances/Create
        public IActionResult Create(int Id=0)
        {
            var model = new PolicyReassurancesCreateVM
            {
                Reassurer = new SelectList(_context.Reassurers, "Id", "Name"),
                ReassuranceType = new SelectList(_context.ReassuranceTypes, "Id", "Descriptiom"),
                SumAssured = _context.Policies.Where(p=>p.Id == Id).Select(q=>q.SumAssured).FirstOrDefault(),
                PolicyID = Id,
                Policy = _context.Policies.Include(p => p.IndividualProduct).Where(p=>p.Id == Id).FirstOrDefault()
                
            };

            return View(model);
        }

        // POST: PolicyReassurances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PolicyReassurancesCreateVM model, int Id)
        {
            if (ModelState.IsValid)
            {
                model.SumAssured = _context.Policies.Where(p => p.Id == Id).Select(q => q.SumAssured).FirstOrDefault();
                model.PolicyID = Id;
                await policyReassurancesRepository.AddAsync(mapper.Map<PolicyReassurance>(model));
                return RedirectToAction(nameof(Index));
            }
            model.ReassuranceType = new SelectList(_context.ReassuranceTypes, "Id", "Id", model.ReassuranceTypeId);
            model.Reassurer = new SelectList(_context.Reassurers, "Id", "Name");
            model.SumAssured = _context.Policies.Where(p => p.Id == Id).Select(q => q.SumAssured).FirstOrDefault();
            model.PolicyID = Id;
            model.Policy = _context.Policies.Include(p => p.IndividualProduct).Where(p => p.Id == Id).FirstOrDefault();
            return View(model);
        }

        // GET: PolicyReassurances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PolicyReassurances == null)
            {
                return NotFound();
            }

            var policyReassurance = await _context.PolicyReassurances.FindAsync(id);
            if (policyReassurance == null)
            {
                return NotFound();
            }
            ViewData["ReassuranceTypeId"] = new SelectList(_context.ReassuranceTypes, "Id", "Id", policyReassurance.ReassuranceTypeId);
            return View(policyReassurance);
        }

        // POST: PolicyReassurances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PolicyId,SumAssured,ReasurerId,ReassuranceTypeId,Id,DateCreated,DateModified")] PolicyReassurance policyReassurance)
        {
            if (id != policyReassurance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policyReassurance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyReassuranceExists(policyReassurance.Id))
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
            ViewData["ReassuranceTypeId"] = new SelectList(_context.ReassuranceTypes, "Id", "Id", policyReassurance.ReassuranceTypeId);
            return View(policyReassurance);
        }

        // GET: PolicyReassurances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PolicyReassurances == null)
            {
                return NotFound();
            }

            var policyReassurance = await _context.PolicyReassurances
                .Include(p => p.ReassuranceType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policyReassurance == null)
            {
                return NotFound();
            }

            return View(policyReassurance);
        }

        // POST: PolicyReassurances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PolicyReassurances == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PolicyReassurances'  is null.");
            }
            var policyReassurance = await _context.PolicyReassurances.FindAsync(id);
            if (policyReassurance != null)
            {
                _context.PolicyReassurances.Remove(policyReassurance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyReassuranceExists(int id)
        {
          return (_context.PolicyReassurances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
