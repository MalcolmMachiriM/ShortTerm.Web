using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
    public class PoliciesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IPolicyRepository policyRepository;

        public PoliciesController(ApplicationDbContext context, IMapper mapper, IPolicyRepository policyRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.policyRepository = policyRepository;
        }

        // GET: Policies
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = mapper.Map<List<PolicyListVM>>(await _context.Policies.Include(p => p.ProductGroup).ToListAsync());
            return View( applicationDbContext);
        }

        // GET: Policies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Policies == null)
            {
                return NotFound();
            }

            var policy = await _context.Policies
                .Include(p => p.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // GET: Policies/Create
        public IActionResult Create()
        {
            var model = new PolicyCreateVM
            {
                Groups= new SelectList(_context.ProductGroups,"Id", "Name"),
                Products = new SelectList(_context.IndividualProducts,"Id", "Name"),
                Clients = new SelectList(_context.Clients,"Id", "FirstName"),
                PaymentMethod = new SelectList(_context.PaymentMethods, "Id", "Method"),
                PaymentFrequency = new SelectList(_context.PaymentFrequencies, "Id", "Frequency")

            };
            return View(model);
        }

        // POST: Policies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PolicyCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var policy = mapper.Map<Policy>(model);
                await policyRepository.AddAsync(policy);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", model.ProductGroupId);
            return View(model);
        }

        // GET: Policies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Policies == null)
            {
                return NotFound();
            }

            var policy = await _context.Policies.FindAsync(id);
            if (policy == null)
            {
                return NotFound();
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", policy.ProductGroupId);
            return View(policy);
        }

        // POST: Policies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationDate,ProductGroupId,Product,ClientId,FirstName,Surname,NationalID,DateOfBirth,Age,AnnualSalary,PremiumTerm,SumAssured,Premium,PremiumPaymentMethod,PremiumPaymentFrequency,Id,DateCreated,DateModified")] Policy policy)
        {
            if (id != policy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyExists(policy.Id))
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
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", policy.ProductGroupId);
            return View(policy);
        }

        // GET: Policies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Policies == null)
            {
                return NotFound();
            }

            var policy = await _context.Policies
                .Include(p => p.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policy == null)
            {
                return NotFound();
            }

            return View(policy);
        }

        // POST: Policies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Policies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Policies'  is null.");
            }
            var policy = await _context.Policies.FindAsync(id);
            if (policy != null)
            {
                _context.Policies.Remove(policy);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyExists(int id)
        {
          return (_context.Policies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public IActionResult GetClientData(int clientId)
        {
            var client = _context.Clients.Find(clientId);
            return Json(client);
        }
    }
}
