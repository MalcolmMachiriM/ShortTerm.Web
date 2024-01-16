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
    public class UnderwritingQuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UnderwritingQuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UnderwritingQuestions
        public async Task<IActionResult> Index()
        {
            return _context.UnderwritingQuestions != null ?
                        View(await _context.UnderwritingQuestions.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.UnderwritingQuestions'  is null.");
        }

        // GET: UnderwritingQuestions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UnderwritingQuestions == null)
            {
                return NotFound();
            }

            var underwritingQuestions = await _context.UnderwritingQuestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (underwritingQuestions == null)
            {
                return NotFound();
            }

            return View(underwritingQuestions);
        }

        // GET: UnderwritingQuestions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnderwritingQuestions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionType,QuestionDescription,Id,DateCreated,DateModified")] UnderwritingQuestions underwritingQuestions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(underwritingQuestions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(underwritingQuestions);
        }

        // GET: UnderwritingQuestions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UnderwritingQuestions == null)
            {
                return NotFound();
            }

            var underwritingQuestions = await _context.UnderwritingQuestions.FindAsync(id);
            if (underwritingQuestions == null)
            {
                return NotFound();
            }
            return View(underwritingQuestions);
        }

        // POST: UnderwritingQuestions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionType,QuestionDescription,Id,DateCreated,DateModified")] UnderwritingQuestions underwritingQuestions)
        {
            if (id != underwritingQuestions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(underwritingQuestions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnderwritingQuestionsExists(underwritingQuestions.Id))
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
            return View(underwritingQuestions);
        }

        // GET: UnderwritingQuestions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UnderwritingQuestions == null)
            {
                return NotFound();
            }

            var underwritingQuestions = await _context.UnderwritingQuestions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (underwritingQuestions == null)
            {
                return NotFound();
            }

            return View(underwritingQuestions);
        }

        // POST: UnderwritingQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UnderwritingQuestions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UnderwritingQuestions'  is null.");
            }
            var underwritingQuestions = await _context.UnderwritingQuestions.FindAsync(id);
            if (underwritingQuestions != null)
            {
                _context.UnderwritingQuestions.Remove(underwritingQuestions);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnderwritingQuestionsExists(int id)
        {
            return (_context.UnderwritingQuestions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
