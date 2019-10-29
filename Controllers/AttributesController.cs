using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaxAttributeMVC.Models;

namespace MaxAttributeMVC.Controllers
{
    public class AttributesController : Controller
    {
        private readonly MaxAttributeDatabaseContext _context;

        public AttributesController(MaxAttributeDatabaseContext context)
        {
            _context = context;
        }

        // GET: Todos
        public async Task<IActionResult> Index()
        {
            return View(await _context.MaxAttribute.ToListAsync());
        }

        // GET: Todos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maxAttr = await _context.MaxAttribute.FirstOrDefaultAsync(m => m.ID == id);
            if (maxAttr == null)
            {
                return NotFound();
            }

            return View(maxAttr);
        }

        // GET: Todos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,ObjectName,AttributeName,Type,Size,Purpose,CreatedDate")] MaxAttribute maxAttr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maxAttr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maxAttr);
        }

        // GET: Todos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maxAttr = await _context.MaxAttribute.FindAsync(id);
            if (maxAttr == null)
            {
                return NotFound();
            }
            return View(maxAttr);
        }

        // POST: Todos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ObjectName,AttributeName,Description,CreatedDate")] MaxAttribute maxAttr)
        {
            if (id != maxAttr.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maxAttr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaxAttrExists(maxAttr.ID))
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
            return View(maxAttr);
        }

        // GET: Todos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maxAttr = await _context.MaxAttribute
                .FirstOrDefaultAsync(m => m.ID == id);
            if (maxAttr == null)
            {
                return NotFound();
            }

            return View(maxAttr);
        }

        // POST: Todos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maxAttr = await _context.MaxAttribute.FindAsync(id);
            _context.MaxAttribute.Remove(maxAttr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaxAttrExists(int id)
        {
            return _context.MaxAttribute.Any(e => e.ID == id);
        }
    }
}
