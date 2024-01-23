using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class ReassurersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IReasurerRepository reasurerRepository;
        private readonly IMapper mapper;

        public ReassurersController(ApplicationDbContext context, IReasurerRepository reasurerRepository, IMapper mapper)
        {
            _context = context;
            this.reasurerRepository = reasurerRepository;
            this.mapper = mapper;
        }

        // GET: Reassurers
        public async Task<IActionResult> Index()
        {
            var reassurers = mapper.Map<List<ReasurerListVM>>(await reasurerRepository.GetAllAsync());
            return reassurers !=null?  View(reassurers): Problem("Entity set 'ApplicationDbContext.Reassurers'  is null.");
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
            var model = new ReasurerCreateVM();
            return View(model);
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
                await reasurerRepository.AddAsync(mapper.Map<Reassurer>(model));
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

            var reassurer = await reasurerRepository.GetAsync(id);
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
        public async Task<IActionResult> Edit(int id, ReasurerListVM model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await reasurerRepository.UpdateAsync(mapper.Map<Reassurer>(model));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReassurerExists(model.Id))
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
            return View(model);
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
