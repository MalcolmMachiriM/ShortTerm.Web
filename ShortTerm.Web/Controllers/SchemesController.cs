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

        public SchemesController(ApplicationDbContext context, IMapper mapper, ISchemeRepository schemeRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.schemeRepository = schemeRepository;
        }

        // GET: Schemes
        public async Task<IActionResult> Index()
        {
            //var model = await schemeRepository.GetAllSchemeDetails();
            var schemes = await _context.Schemes
                .Include(q => q.Clients)
                .ToListAsync();
            var model = mapper.Map<List<SchemeListVM>>(schemes);
            return model != null ? View(model) : Problem("No Schemea Found");
        }

        // GET: Schemes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var schemes = await schemeRepository.GetAllAsync();
            if (id == null || schemes == null)
            {
                return NotFound();
            }

            var scheme = await schemeRepository
                .GetAsync(id);
            if (scheme == null)
            {
                return NotFound();
            }

            var model = mapper.Map<SchemeCreateVM>(scheme);
            return View(model);
        }

        // GET: Schemes/Create
        public IActionResult Create()
        {
            var model = new SchemeCreateVM
            {
                InstitutionalClients = new SelectList(_context.Clients.Where(q => q.ClientTypeId == 2), "Id", "FirstName")
            };
            return View(model);
           
        }

        // POST: Schemes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SchemeCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var scheme = mapper.Map<Scheme>(model);
                await schemeRepository.AddAsync(scheme);
                return RedirectToAction(nameof(Index));
            }
            model.InstitutionalClients = new SelectList(_context.Clients.Where(q => q.ClientTypeId == 2), "Id", "Firstname" , model.InstitutionalClientsName);
            return View(model);
        }

        // GET: Schemes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null || schemeRepository.GetAllAsync() == null)
            {
                return NotFound();
            }

            var scheme = await schemeRepository.GetAsync(id);
            if (scheme == null)
            {
                return NotFound();
            }
            var model = mapper.Map<SchemeCreateVM>(scheme);
            return View(model);
        }

        // POST: Schemes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SchemeCreateVM schemeVM)
        {
            if (id != schemeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var scheme = mapper.Map<Scheme>(schemeVM);
                    await schemeRepository.UpdateAsync(scheme);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await schemeRepository.Exists(schemeVM.Id))
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
            return View(schemeVM);
        }


        // POST: Schemes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            if (schemeRepository.GetAllAsync() == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schemes'  is null.");
            }
            var scheme = await schemeRepository.GetAsync(Id);
            if (scheme != null)
            {
                await schemeRepository.DeleteAsync(Id);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
