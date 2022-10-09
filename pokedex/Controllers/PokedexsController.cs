using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pokedex.Models;

namespace pokedex.Controllers
{
    public class PokedexsController : Controller
    {
        private readonly Contexto _context;

        public PokedexsController(Contexto context)
        {
            _context = context;
        }

        // GET: Pokedexs
        public async Task<IActionResult> Index()
        {
              return View(await _context.pokedexs.ToListAsync());
        }

        // GET: Pokedexs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.pokedexs == null)
            {
                return NotFound();
            }

            var pokedex = await _context.pokedexs
                .FirstOrDefaultAsync(m => m.id == id);
            if (pokedex == null)
            {
                return NotFound();
            }

            return View(pokedex);
        }

        // GET: Pokedexs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pokedexs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,quantidade")] Pokedex pokedex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokedex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokedex);
        }

        // GET: Pokedexs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.pokedexs == null)
            {
                return NotFound();
            }

            var pokedex = await _context.pokedexs.FindAsync(id);
            if (pokedex == null)
            {
                return NotFound();
            }
            return View(pokedex);
        }

        // POST: Pokedexs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,quantidade")] Pokedex pokedex)
        {
            if (id != pokedex.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokedex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokedexExists(pokedex.id))
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
            return View(pokedex);
        }

        // GET: Pokedexs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.pokedexs == null)
            {
                return NotFound();
            }

            var pokedex = await _context.pokedexs
                .FirstOrDefaultAsync(m => m.id == id);
            if (pokedex == null)
            {
                return NotFound();
            }

            return View(pokedex);
        }

        // POST: Pokedexs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.pokedexs == null)
            {
                return Problem("Entity set 'Contexto.pokedexs'  is null.");
            }
            var pokedex = await _context.pokedexs.FindAsync(id);
            if (pokedex != null)
            {
                _context.pokedexs.Remove(pokedex);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokedexExists(int id)
        {
          return _context.pokedexs.Any(e => e.id == id);
        }
    }
}
