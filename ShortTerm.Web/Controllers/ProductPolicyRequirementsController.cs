using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class ProductPolicyRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductPolicyRequirementRepository productPolicyRequirementRepository;
        private readonly IMapper mapper;

        public ProductPolicyRequirementsController(ApplicationDbContext context, IProductPolicyRequirementRepository productPolicyRequirementRepository, IMapper mapper)
        {
            _context = context;
            this.productPolicyRequirementRepository = productPolicyRequirementRepository;
            this.mapper = mapper;
        }

        // GET: ProductPolicyRequirements
        public async Task<IActionResult> Index(int Id = 0)
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
        public IActionResult Create(int Id)
        {
            var model = new ProductPolicyRequirementCreateVM
            {
                IndividualProduct = new SelectList(_context.IndividualProducts.Where(q => q.Id == Id), "Id", "Name"),
                Requirements = new SelectList(_context.Requirements, "Id", "Description")
            };
            return View(model);
        }

        // POST: ProductPolicyRequirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductPolicyRequirementCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var rule = mapper.Map<ProductPolicyRequirement>(model);
                await productPolicyRequirementRepository.AddAsync(rule);
                return RedirectToAction(nameof(Index));
            }
            model.IndividualProduct = new SelectList(_context.IndividualProducts, "Id", "Id", model.IndividualProductID);
            model.Requirements = new SelectList(_context.Requirements, "Id", "Id", model.RequirementID);
            return View(model);
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
        public async Task<IActionResult> Edit(int id, ProductPolicyRequirementEditVM model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var rule = mapper.Map<ProductPolicyRequirement>(model);
                    await productPolicyRequirementRepository.UpdateAsync(rule);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPolicyRequirementExists(model.Id))
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
            model.IndividualProduct = new SelectList(_context.IndividualProducts, "Id", "Id", model.IndividualProductID);
            model.Requirements = new SelectList(_context.Requirements, "Id", "Id", model.RequirementID);
            return View(model);
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
