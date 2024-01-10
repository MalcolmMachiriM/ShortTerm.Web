using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    [Authorize]
    public class ProductGroupsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IProductGroupRepository productGroupRepository;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;

        public ProductGroupsController(ApplicationDbContext context, IMapper mapper, IProductGroupRepository productGroupRepository,AutoMapper.IConfigurationProvider configurationProvider)
        {
            _context = context;
            this.mapper = mapper;
            this.productGroupRepository = productGroupRepository;
            this.configurationProvider = configurationProvider;
        }

        // GET: ProductGroups
        public async Task<IActionResult> Index(int Id=0)
        {
            if (Id==0)
            {
                var clients = await productGroupRepository.GetAll();
               
                return clients != null ? View(clients) : NotFound("No Product Groups Found");
            }
            else
            {
                var products = await productGroupRepository.GetAllGroups(Id);
                return products != null ? View(products) : NotFound("No Product Groups Found");
            }

            
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
            var model = new ProductGroupCreateVM
            {
                Schemes = new SelectList(_context.Schemes, "Id", "RegName")
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
            try
            {
                if (ModelState.IsValid)
                {
                    await productGroupRepository.CreateGroup(model);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error occured: {ex.Message}");
                
            }
            
            model.Schemes = new SelectList(_context.Schemes, "Id", "RegName", model.SchemeId);
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
