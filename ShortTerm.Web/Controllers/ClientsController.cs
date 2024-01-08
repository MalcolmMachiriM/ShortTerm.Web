﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using System.Xml.Linq;

namespace ShortTerm.Web.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IClientRepository clientRepository;

        public ClientsController(ApplicationDbContext context, IMapper mapper, IClientRepository clientRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.clientRepository = clientRepository;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Clients.Include(c => c.Gender).Include(c => c.MaritalStatus);
            var clients = await clientRepository.GetAllAsync();
            var model = mapper.Map<List<ClientListVM>>(clients);
            //return View(await applicationDbContext.ToListAsync());
            return await clientRepository.GetAllAsync() != null ?
                View(model) : Problem("No Clients Found");
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Gender)
                .Include(c => c.MaritalStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            var model = new ClientCreateVM
            {
                GenderId =new SelectList(_context.Genders, "Id", "Sex"),
                ClientTypeId = new SelectList(_context.ClientTypes, "Id", "Type"),
                HighestQualificationId = new SelectList(_context.HighestQualifications, "Id", "Qualification"),
                MaritalStatusId = new SelectList(_context.MaritalStatuses, "Id", "Status"),
                TitleId = new SelectList(_context.Titles, "Id", "Name")
            };
            return View(model);
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ClientCreateVM clientVM)
        {
            if (ModelState.IsValid)
            {
                var client = mapper.Map<Client>(clientVM);
                await clientRepository.AddAsync(client);
                return RedirectToAction(nameof(Index));
            }


            clientVM.GenderId = new SelectList(_context.Genders, "Id", "Sex",clientVM.GenderId);
            clientVM.MaritalStatusId = new SelectList(_context.MaritalStatuses, "Id", "Status", clientVM.MaritalStatusId);
            clientVM.ClientTypeId = new SelectList(_context.ClientTypes, "Id", "Type", clientVM.ClientTypeId);
            clientVM.HighestQualificationId = new SelectList(_context.HighestQualifications, "Id", "Qualification", clientVM.HighestQualificationId);
            clientVM.TitleId = new SelectList(_context.Titles, "Id", "Name", clientVM.TitleId);

            return View(clientVM);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Sex", client.GenderId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Status", client.MaritalStatusId);
            ViewData["ClientType"] = new SelectList(_context.ClientTypes, "Id", "Type", client.ClientTypeId);
            ViewData["HighestQualification"] = new SelectList(_context.HighestQualifications, "Id", "Qualification", client.HighestQualificationId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegNo,ClientTypeId,Title,FirstName,Surname,MiddleName,DateOfBirth,GenderId,MaritalStatusId,CountryOfBirth,CountryOfResidence,Language,Religion,IncomeGroupId,HghestQualificationId,Active,AddedBy,ModifiedBy,ContactPersonName,ContactPersonNumber,NationalId,Status,StatusValue,IsAuthorized,Id,DateCreated,DateModified")] Client client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
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
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Id", client.GenderId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Id", client.MaritalStatusId);
            ViewData["ClientType"] = new SelectList(_context.ClientTypes, "Id", "Type", client.ClientTypeId);
            ViewData["HighestQualification"] = new SelectList(_context.HighestQualifications, "Id", "Qualification", client.HighestQualificationId);
            return View(client);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Clients == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .Include(c => c.Gender)
                .Include(c => c.MaritalStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Clients == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Clients'  is null.");
            }
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return (_context.Clients?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
