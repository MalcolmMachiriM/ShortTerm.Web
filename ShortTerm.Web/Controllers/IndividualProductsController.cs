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
    public class IndividualProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IIndividualProductsRepository individualProductsRepository;

        public IndividualProductsController(ApplicationDbContext context,IMapper mapper, IIndividualProductsRepository individualProductsRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.individualProductsRepository = individualProductsRepository;
        }

        // GET: IndividualProducts
        public async Task<IActionResult> Index()
        {
            var products = await individualProductsRepository.GetAllAsync();
            var model = mapper.Map<List<IndividualProductVM>>(products);
            return products !=null ? View(model) : Problem("No Products Found");
        }

        // GET: IndividualProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IndividualProducts == null)
            {
                return NotFound();
            }

            var individualProduct = await _context.IndividualProducts
                .Include(i => i.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (individualProduct == null)
            {
                return NotFound();
            }

            return View(individualProduct);
        }

        // GET: IndividualProducts/Create
        public IActionResult Create()
        {
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id");
            return View();
        }

        // POST: IndividualProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( IndividualProductCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var products = mapper.Map<IndividualProduct>(model);
                await individualProductsRepository.AddAsync(products);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Name", model.ProductGroupId);
            return View(model);
        }

        // GET: IndividualProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IndividualProducts == null)
            {
                return NotFound();
            }

            var individualProduct = await _context.IndividualProducts.FindAsync(id);
            if (individualProduct == null)
            {
                return NotFound();
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", individualProduct.ProductGroupId);
            return View(individualProduct);
        }

        // POST: IndividualProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductGroupId,Name,ProcessTime,Retention,SumAssuredBasis,CanBeCeded,EffectiveDate,Description,MaxPremiumTerm,MinPremiumTerm,MinSumAssured,MaxSumAssured,Id,DateCreated,DateModified")] IndividualProduct individualProduct)
        {
            if (id != individualProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(individualProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndividualProductExists(individualProduct.Id))
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
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", individualProduct.ProductGroupId);
            return View(individualProduct);
        }

        // GET: IndividualProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IndividualProducts == null)
            {
                return NotFound();
            }

            var individualProduct = await _context.IndividualProducts
                .Include(i => i.ProductGroup)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (individualProduct == null)
            {
                return NotFound();
            }

            return View(individualProduct);
        }

        // POST: IndividualProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IndividualProducts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IndividualProducts'  is null.");
            }
            var individualProduct = await _context.IndividualProducts.FindAsync(id);
            if (individualProduct != null)
            {
                _context.IndividualProducts.Remove(individualProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndividualProductExists(int id)
        {
          return (_context.IndividualProducts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
