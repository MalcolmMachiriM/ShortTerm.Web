using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShortTerm.Web.Constants;
using ShortTerm.Web.Contracts;
using ShortTerm.Web.Data;
using ShortTerm.Web.Models;
using ShortTerm.Web.Repositories;


namespace ShortTerm.Web.Controllers
{
    public class PoliciesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;
        private readonly IPolicyRepository policyRepository;

        public PoliciesController(ApplicationDbContext context, IMapper mapper, IPolicyRepository policyRepository)
        {
            _context = context;
            this.mapper = mapper;
            this.policyRepository = policyRepository;
        }

        // GET: Policies
        public async Task<IActionResult> Index()
        {
            var model = await policyRepository.GetAll();
            return View(model);
        }

        // GET: Policies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Policies == null)
            {
                return NotFound();
            }
            var policy = await _context.Policies
                .Include(p => p.ProductGroup)
                .Include(p => p.IndividualProduct)
                .Include(p => p.Client)
                .Include(p => p.PaymentMethod)
                .Include(p => p.PaymentFrequency)
                .FirstOrDefaultAsync(m => m.Id == id);

            var model = new PolicyDetailsVM
            {
                Id = policy.Id,
                ClientId = policy.ClientId,
                ProductGroup = mapper.Map<ProductGroupVM>(policy.ProductGroup),
                IndividualProduct = mapper.Map<IndividualProductVM>(policy.IndividualProduct),
                Client = mapper.Map<ClientListVM>(policy.Client),
                PaymentMethod = policy.PaymentMethod,
                PaymentFrequency = policy.PaymentFrequency,
                ApplicationDate = policy.ApplicationDate,
                PremiumTerm = policy.PremiumTerm,
                SumAssured = policy.SumAssured,
                Premium = policy.Premium,
                DateCreated = policy.DateCreated,
            };
            if (policy == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Policies/Create
        public IActionResult Create()
        {
            var model = new PolicyCreateVM
            {
                Groups = new SelectList(_context.ProductGroups, "Id", "Name"),
                Products = new SelectList(_context.IndividualProducts, "Id", "Name"),
                Clients = new SelectList(_context.Clients
                                .Where(q => q.Status == 1 &&  q.ClientTypeId ==1)
                                .Select(c => new { Id = c.Id, FullName = $"{c.FirstName} {c.Surname}" }),
                            "Id", "FullName"),
                PaymentMethod = new SelectList(_context.PaymentMethods, "Id", "Method"),
                PaymentFrequency = new SelectList(_context.PaymentFrequencies, "Id", "Frequency")

            };
            return View(model);
        }

        // POST: Policies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PolicyCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var policy = mapper.Map<Policy>(model);
                await policyRepository.AddAsync(policy);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", model.ProductGroupId);
            return View(model);
        }

        // GET: Policies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Policies == null)
            {
                return NotFound();
            }

            var policy = await _context.Policies.FindAsync(id);
            if (policy == null)
            {
                return NotFound();
            }
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", policy.ProductGroupId);
            return View(policy);
        }

        // POST: Policies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationDate,ProductGroupId,Product,ClientId,FirstName,Surname,NationalID,DateOfBirth,Age,AnnualSalary,PremiumTerm,SumAssured,Premium,PremiumPaymentMethod,PremiumPaymentFrequency,Id,DateCreated,DateModified")] Policy policy)
        {
            if (id != policy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolicyExists(policy.Id))
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
            ViewData["ProductGroupId"] = new SelectList(_context.ProductGroups, "Id", "Id", policy.ProductGroupId);
            return View(policy);
        }

        // POST: Policies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Policies == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Policies'  is null.");
            }
            var policy = await _context.Policies.FindAsync(id);
            if (policy != null)
            {
                _context.Policies.Remove(policy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolicyExists(int id)
        {
            return (_context.Policies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
        public IActionResult GetClientData(int clientId)
        {
            var client = _context.Clients.Find(clientId);
            return Json(new SearchClientResultVM
            {
                ID = client.Id,
                Firstname = client.FirstName,
                Surname = client.Surname,
                DateOfBirth = client.DateOfBirth.ToString(),
                NationalID = client.NationalId
            });
        }

        [Authorize(Roles = Roles.Administrator)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApprovePolicy(int id, bool approved)
        {
            try
            {
                await policyRepository.ChangeApprovalStatus(id, approved);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Clients/UnderWriting
        public async Task<IActionResult> UnderWriting(int policyId)
        {
            var model = new UnderWritingVM
            {
                StateOfProps = new SelectList( _context.Clients, "Id","FirstName"),
                LocationOfProps = new SelectList( _context.Clients, "Id", "FirstName"),
                SecurityOfProps = new SelectList(_context.Clients, "Id", "FirstName"),
                PrimaryUseOfProps = new SelectList(_context.Clients, "Id", "FirstName")
            };

            return View(model);
        }

        // POST: Clients/ChangeApprovalStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UnderWriting(int id, int approved)
        {
            //try
            //{
            //    await clientRepository.ChangeStatus(id, approved);
            //}
            //catch (Exception ex)
            //{

            //    ModelState.AddModelError("", ex.Message);
            //}
            return RedirectToAction(nameof(Index));
        }
    }
}
