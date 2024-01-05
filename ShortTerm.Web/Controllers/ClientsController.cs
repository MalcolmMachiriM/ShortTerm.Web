using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Clients.Include(c => c.Gender).Include(c => c.Language).Include(c => c.MaritalStatus).Include(c => c.Religion);
            return View(await applicationDbContext.ToListAsync());
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
                .Include(c => c.Language)
                .Include(c => c.MaritalStatus)
                .Include(c => c.Religion)
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
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Id");
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Id");
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Id");
            ViewData["ReligionId"] = new SelectList(_context.Religions, "Id", "Id");
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegNo,ClientTypeId,TitleId,FirstName,Surname,MiddleName,DateOfBirth,GenderId,MaritalStatusId,CountryOfBirthId,CountryOfResidenceId,LanguageId,ReligionId,IncomeGroupId,HghestQualificationId,Active,AddedBy,ModifiedBy,ContactPersonId,NationalId,Status,StatusValue,IsAuthorized,Id,DateCreated,DateModified")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Id", client.GenderId);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Id", client.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Id", client.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religions, "Id", "Id", client.ReligionId);
            return View(client);
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
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Id", client.GenderId);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Id", client.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Id", client.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religions, "Id", "Id", client.ReligionId);
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegNo,ClientTypeId,TitleId,FirstName,Surname,MiddleName,DateOfBirth,GenderId,MaritalStatusId,CountryOfBirthId,CountryOfResidenceId,LanguageId,ReligionId,IncomeGroupId,HghestQualificationId,Active,AddedBy,ModifiedBy,ContactPersonId,NationalId,Status,StatusValue,IsAuthorized,Id,DateCreated,DateModified")] Client client)
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
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Id", client.LanguageId);
            ViewData["MaritalStatusId"] = new SelectList(_context.MaritalStatuses, "Id", "Id", client.MaritalStatusId);
            ViewData["ReligionId"] = new SelectList(_context.Religions, "Id", "Id", client.ReligionId);
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
                .Include(c => c.Language)
                .Include(c => c.MaritalStatus)
                .Include(c => c.Religion)
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
