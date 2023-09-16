using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lib.Web.Data;
using Lib.Web.Models;

namespace Lib.Web.Controllers
{
    public class ImprintersController : Controller
    {
        private readonly Context _context;

        public ImprintersController(Context context)
        {
            _context = context;
        }

        // GET: Imprinters
        public async Task<IActionResult> Index()
        {
              return _context.Imprinters != null ? 
                          View(await _context.Imprinters.ToListAsync()) :
                          Problem("Entity set 'Context.Imprinters'  is null.");
        }

        // GET: Imprinters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Imprinters == null)
            {
                return NotFound();
            }

            var imprinter = await _context.Imprinters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imprinter == null)
            {
                return NotFound();
            }

            return View(imprinter);
        }

        // GET: Imprinters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Imprinters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Displayname,LastName,FirstName,Profil,DatedeNaissance,DisplayName,Id,CreateAt,DeleteAt,UpdateAt")] Imprinter imprinter)
        {
            if (ModelState.IsValid)
            {
                _context.Imprinters.Add(imprinter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imprinter);
        }

        // GET: Imprinters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Imprinters == null)
            {
                return NotFound();
            }

            var imprinter = await _context.Imprinters.FindAsync(id);
            if (imprinter == null)
            {
                return NotFound();
            }
            return View(imprinter);
        }

        // POST: Imprinters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Displayname,LastName,FirstName,Profil,DatedeNaissance,DisplayName,Id,CreateAt,DeleteAt,UpdateAt")] Imprinter imprinter)
        {
            if (id != imprinter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imprinter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImprinterExists(imprinter.Id))
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
            return View(imprinter);
        }

        // GET: Imprinters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Imprinters == null)
            {
                return NotFound();
            }

            var imprinter = await _context.Imprinters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (imprinter == null)
            {
                return NotFound();
            }

            return View(imprinter);
        }

        // POST: Imprinters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Imprinters == null)
            {
                return Problem("Entity set 'Context.Imprinters'  is null.");
            }
            var imprinter = await _context.Imprinters.FindAsync(id);
            if (imprinter != null)
            {
                _context.Imprinters.Remove(imprinter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImprinterExists(int id)
        {
          return (_context.Imprinters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
