﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;

namespace ShortTerm.Web.Controllers
{
    public class UnderWritingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IMapper mapper;
        private readonly IUnderwritingRepository underwritingRepository;

        public UnderWritingsController(ApplicationDbContext context, AutoMapper.IConfigurationProvider configurationProvider, IMapper mapper, IUnderwritingRepository underwritingRepository)
        {
            _context = context;
            this.configurationProvider = configurationProvider;
            this.mapper = mapper;
            this.underwritingRepository = underwritingRepository;
        }

        // GET: UnderWritings
        public async Task<IActionResult> Index(int Id=0)
        {
            if (Id == 0)
            {
                var model = await underwritingRepository.GetAll();
                return View(model);
            }
            else
            {
                var model = await underwritingRepository.GetAll(Id);
                return View(model);
            }
        }

        // GET: UnderWritings/Details/5
        public async Task<IActionResult> Details(int? id, int policyId=0)
        {
            if (policyId == 0)
            {
                if (id == null || _context.UnderWritings == null)
                {
                    return NotFound();
                }

                var underWriting = await _context.UnderWritings
                    .Include(u => u.Client)
                    .Include(u => u.Policy)
                    .Include(u => u.StateOfProperty)
                    .Include(u => u.LocationOfProperty)
                    .Include(u => u.SecurityOfPropertyScore)
                    .Include(u => u.PrimaryUseOfPropertyScore)
                    .FirstOrDefaultAsync(m => m.Id == id);
                var model = mapper.Map<UnderwritingListVM>(underWriting);
                if (underWriting == null)
                {
                    return NotFound();
                }

                return View(model);
            }
            else
            {
                if (id == null || _context.UnderWritings == null)
                {
                    return NotFound();
                }

                var underWriting = await _context.UnderWritings
                    .Include(u => u.Client)
                    .Include(u => u.Policy)
                    .Include(u => u.StateOfProperty)
                    .Include(u => u.LocationOfProperty)
                    .Include(u => u.SecurityOfPropertyScore)
                    .Include(u => u.PrimaryUseOfPropertyScore)
                    .FirstOrDefaultAsync(m => m.Id == id && m.PolicyId ==policyId);
                var model = mapper.Map<UnderwritingListVM>(underWriting);
                if (underWriting == null)
                {
                    return NotFound();
                }

                return View(model);
            }
            
        }

        // GET: UnderWritings/Create
        public IActionResult Create(int id=0)
        {
            //var policy = _context.Policies.Include(q => q.Client)
            //    .ProjectTo<UnderWritingVM>(configurationProvider)
            //    .Where(q => q.PolicyId == id);

            var model = new UnderWritingVM
            {
                StateOfProps = new SelectList( _context.StateOfProperty, "Id", "Description"),
                LocationOfProps = new SelectList(_context.LocationOfProperty, "Id", "Description"),
                SecurityOfProps = new SelectList(_context.SecurityOfPropertyScore, "Id", "Description"),
                PrimaryUseOfProps = new SelectList(_context.PrimaryUseOfPropertyScore, "Id", "Description")
            };
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id");
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id");
            return View(model);
        }

        // POST: UnderWritings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UnderWritingVM model, int id=0)
        {
            if (ModelState.IsValid)
            {
                var underwriting = mapper.Map<UnderWriting>(model);
                underwriting.PolicyId = id;
                await underwritingRepository.AddAsync(underwriting);
                return RedirectToAction(nameof(Index),"Policies");
            }
            model.StateOfProps = new SelectList(_context.StateOfProperty, "Id", "Description",model.StateOfPropertyId);
            model.LocationOfProps = new SelectList(_context.LocationOfProperty, "Id", "Description", model.LocationOfPropertyId);
            model.SecurityOfProps = new SelectList(_context.SecurityOfPropertyScore, "Id", "Description", model.SecurityOfPropertyScoreId);
            model.PrimaryUseOfProps = new SelectList(_context.PrimaryUseOfPropertyScore, "Id", "Description", model.PrimaryUseOfPropertyScoreId);
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", model.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", model.PolicyId);
            return View(model);
        }

        // GET: UnderWritings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UnderWritings == null)
            {
                return NotFound();
            }

            var underWriting = mapper.Map<UnderWritingVM>(await _context.UnderWritings.FindAsync(id));
            if (underWriting == null)
            {
                return NotFound();
            }


            underWriting.StateOfProps = new SelectList(_context.StateOfProperty, "Id", "Description", underWriting.StateOfPropertyId);
            underWriting.LocationOfProps = new SelectList(_context.LocationOfProperty, "Id", "Description", underWriting.LocationOfPropertyId);
            underWriting.SecurityOfProps = new SelectList(_context.SecurityOfPropertyScore, "Id", "Description", underWriting.SecurityOfPropertyScoreId);
            underWriting.PrimaryUseOfProps = new SelectList(_context.PrimaryUseOfPropertyScore, "Id", "Description", underWriting.PrimaryUseOfPropertyScoreId);
            
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", underWriting.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", underWriting.PolicyId);
            return View(underWriting);
        }

        // POST: UnderWritings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientId,PolicyId,ClientProposedValueOfAsset,StateOfProperty,LocationOfProperty,SecurityOfPropertyScore,PrimaryUseOfPropertyScore,AdditionalNotes,Approved,Id,DateCreated,DateModified")] UnderWriting underWriting)
        {
            if (id != underWriting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(underWriting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnderWritingExists(underWriting.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Clients, "Id", "Id", underWriting.ClientId);
            ViewData["PolicyId"] = new SelectList(_context.Policies, "Id", "Id", underWriting.PolicyId);
            return View(underWriting);
        }

        // GET: UnderWritings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UnderWritings == null)
            {
                return NotFound();
            }

            var underWriting = await _context.UnderWritings
                .Include(u => u.Client)
                .Include(u => u.Policy)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (underWriting == null)
            {
                return NotFound();
            }

            return View(underWriting);
        }

        // POST: UnderWritings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UnderWritings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UnderWritings'  is null.");
            }
            var underWriting = await _context.UnderWritings.FindAsync(id);
            if (underWriting != null)
            {
                _context.UnderWritings.Remove(underWriting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnderWritingExists(int id)
        {
          return (_context.UnderWritings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
