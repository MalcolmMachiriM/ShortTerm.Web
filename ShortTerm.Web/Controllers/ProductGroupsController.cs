using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class ProductGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IProductGroupRepository productGroupRepository;

        public ProductGroupsController(ApplicationDbContext context, IMapper mapper, IProductGroupRepository productGroupRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.productGroupRepository = productGroupRepository;
        }

        // GET: ProductGroups
        public async Task<IActionResult> Index()
        {
            var clients = await productGroupRepository.GetAllAsync();
            var model = mapper.Map<List<ProductGroupVM>>(clients);
            return await productGroupRepository.GetAllAsync() != null ?
                View(model) : Problem("No Product Groups Found");
        }

        // GET: ProductGroups/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups
                .Include(p => p.Scheme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productGroup == null)
            {
                return NotFound();
            }

            return View(productGroup);
        }

        // GET: ProductGroups/Create
        public IActionResult Create()
        {
            ViewData["SchemeId"] = new SelectList(_context.Schemes, "Id", "Id");

            var model = new ProductGroupCreateVM
            {
                SchemeId = new SelectList(_context.Schemes, "Id", "RegName")
            };

            return View(model);
        }

        // POST: ProductGroups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ProductGroupCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var productGroup = mapper.Map<ProductGroup>(model);
                await productGroupRepository.AddAsync(productGroup);
                return RedirectToAction(nameof(Index));
            }
            model.SchemeId = new SelectList(_context.Schemes, "Id", "RegName", model.SchemeId);
            return View(model);
        }

        // GET: ProductGroups/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup == null)
            {
                return NotFound();
            }
            ViewData["SchemeId"] = new SelectList(_context.Schemes, "Id", "Id", productGroup.SchemeId);
            return View(productGroup);
        }

        // POST: ProductGroups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Code,Description,SchemeId,Id,DateCreated,DateModified")] ProductGroup productGroup)
        {
            if (id != productGroup.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductGroupExists(productGroup.Id))
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
            ViewData["SchemeId"] = new SelectList(_context.Schemes, "Id", "Id", productGroup.SchemeId);
            return View(productGroup);
        }

        // GET: ProductGroups/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductGroups == null)
            {
                return NotFound();
            }

            var productGroup = await _context.ProductGroups
                .Include(p => p.Scheme)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productGroup == null)
            {
                return NotFound();
            }

            return View(productGroup);
        }

        // POST: ProductGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductGroups == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProductGroups'  is null.");
            }
            var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup != null)
            {
                _context.ProductGroups.Remove(productGroup);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductGroupExists(int id)
        {
            return (_context.ProductGroups?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
