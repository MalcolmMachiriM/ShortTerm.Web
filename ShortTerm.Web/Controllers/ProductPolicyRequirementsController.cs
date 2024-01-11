using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Controllers
{
    public class ProductPolicyRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductPolicyRequirementRepository productPolicyRequirementRepository;

        public ProductPolicyRequirementsController(ApplicationDbContext context, IProductPolicyRequirementRepository productPolicyRequirementRepository)
        {
            _context = context;
            this.productPolicyRequirementRepository = productPolicyRequirementRepository;
        }

        // GET: ProductPolicyRequirements
        public async Task<IActionResult> Index(int Id)
        {
            var Requirements = await productPolicyRequirementRepository.GetAllPolicyRules(Id);
            return View(Requirements);
        }

        // GET: ProductPolicyRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductPolicyRequirements == null)
            {
                return NotFound();
            }

            var productPolicyRequirement = await _context.ProductPolicyRequirements
                .Include(p => p.IndividualProduct)
                .Include(p => p.Requirement)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productPolicyRequirement == null)
            {
                return NotFound();
            }

            return View(productPolicyRequirement);
        }

        // GET: ProductPolicyRequirements/Create
        public IActionResult Create()
        {
            ViewData["IndividualProductID"] = new SelectList(_context.IndividualProducts, "Id", "Name");
            ViewData["RequirementID"] = new SelectList(_context.Requirements.Include(q => q.RequirementType), "Id", /*"Requirement.RequirementType"*/ "Id");
            return View();
        }

        // POST: ProductPolicyRequirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegNo,IndividualProductID,DependentTypeID,RequirementID,IsMandatory,Description,AddedBy,ModifiedBy,Id,DateCreated,DateModified")] ProductPolicyRequirement productPolicyRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productPolicyRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IndividualProductID"] = new SelectList(_context.IndividualProducts, "Id", "Id", productPolicyRequirement.IndividualProductID);
            ViewData["RequirementID"] = new SelectList(_context.Requirements, "Id", "Id", productPolicyRequirement.RequirementID);
            return View(productPolicyRequirement);
        }

        // GET: ProductPolicyRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductPolicyRequirements == null)
            {
                return NotFound();
            }

            var productPolicyRequirement = await _context.ProductPolicyRequirements.FindAsync(id);
            if (productPolicyRequirement == null)
            {
                return NotFound();
            }
            ViewData["IndividualProductID"] = new SelectList(_context.IndividualProducts, "Id", "Id", productPolicyRequirement.IndividualProductID);
            ViewData["RequirementID"] = new SelectList(_context.Requirements, "Id", "Id", productPolicyRequirement.RequirementID);
            return View(productPolicyRequirement);
        }

        // POST: ProductPolicyRequirements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegNo,IndividualProductID,DependentTypeID,RequirementID,IsMandatory,Description,AddedBy,ModifiedBy,Id,DateCreated,DateModified")] ProductPolicyRequirement productPolicyRequirement)
        {
            if (id != productPolicyRequirement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productPolicyRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPolicyRequirementExists(productPolicyRequirement.Id))
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
            ViewData["IndividualProductID"] = new SelectList(_context.IndividualProducts, "Id", "Id", productPolicyRequirement.IndividualProductID);
            ViewData["RequirementID"] = new SelectList(_context.Requirements, "Id", "Id", productPolicyRequirement.RequirementID);
            return View(productPolicyRequirement);
        }

        // GET: ProductPolicyRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductPolicyRequirements == null)
            {
                return NotFound();
            }

            var productPolicyRequirement = await _context.ProductPolicyRequirements
                .Include(p => p.IndividualProduct)
                .Include(p => p.Requirement)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productPolicyRequirement == null)
            {
                return NotFound();
            }

            return View(productPolicyRequirement);
        }

        // POST: ProductPolicyRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductPolicyRequirements == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProductPolicyRequirements'  is null.");
            }
            var productPolicyRequirement = await _context.ProductPolicyRequirements.FindAsync(id);
            if (productPolicyRequirement != null)
            {
                _context.ProductPolicyRequirements.Remove(productPolicyRequirement);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductPolicyRequirementExists(int id)
        {
          return (_context.ProductPolicyRequirements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
