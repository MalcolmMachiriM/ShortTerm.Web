using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShortTerm.Web.Data;

namespace ShortTerm.Web.Controllers.SystemVariables
{
    public class PaymentMethodsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentMethodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentMethods
        public async Task<IActionResult> Index()
        {
            return _context.PaymentMethods_1 != null ?
                        View(await _context.PaymentMethods_1.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.PaymentMethods_1'  is null.");
        }

        // GET: PaymentMethods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PaymentMethods_1 == null)
            {
                return NotFound();
            }

            var paymentMethods = await _context.PaymentMethods_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentMethods == null)
            {
                return NotFound();
            }

            return View(paymentMethods);
        }

        // GET: PaymentMethods/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentMethods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Method,Code,BankDetailsRequired,MobileNumRequired,Id,DateCreated,DateModified")] PaymentMethods paymentMethods)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentMethods);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentMethods);
        }

        // GET: PaymentMethods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PaymentMethods_1 == null)
            {
                return NotFound();
            }

            var paymentMethods = await _context.PaymentMethods_1.FindAsync(id);
            if (paymentMethods == null)
            {
                return NotFound();
            }
            return View(paymentMethods);
        }

        // POST: PaymentMethods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Method,Code,BankDetailsRequired,MobileNumRequired,Id,DateCreated,DateModified")] PaymentMethods paymentMethods)
        {
            if (id != paymentMethods.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentMethods);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentMethodsExists(paymentMethods.Id))
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
            return View(paymentMethods);
        }

        // GET: PaymentMethods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PaymentMethods_1 == null)
            {
                return NotFound();
            }

            var paymentMethods = await _context.PaymentMethods_1
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paymentMethods == null)
            {
                return NotFound();
            }

            return View(paymentMethods);
        }

        // POST: PaymentMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PaymentMethods_1 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PaymentMethods_1'  is null.");
            }
            var paymentMethods = await _context.PaymentMethods_1.FindAsync(id);
            if (paymentMethods != null)
            {
                _context.PaymentMethods_1.Remove(paymentMethods);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentMethodsExists(int id)
        {
            return (_context.PaymentMethods_1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
