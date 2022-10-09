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
    public class PokemonsDtController : Controller
    {
        private readonly Contexto _context;

        public PokemonsDtController(Contexto context)
        {
            _context = context;
        }

        // GET: PokemonsDt
        public async Task<IActionResult> Index()
        {
              return View(await _context.pokemons.ToListAsync());
        }

        // GET: PokemonsDt/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.pokemons
                .FirstOrDefaultAsync(m => m.id == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: PokemonsDt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PokemonsDt/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,tipo,compra,venda")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokemon);
        }

        // GET: PokemonsDt/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            return View(pokemon);
        }

        // POST: PokemonsDt/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,tipo,compra,venda")] Pokemon pokemon)
        {
            if (id != pokemon.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonExists(pokemon.id))
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
            return View(pokemon);
        }

        // GET: PokemonsDt/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.pokemons == null)
            {
                return NotFound();
            }

            var pokemon = await _context.pokemons
                .FirstOrDefaultAsync(m => m.id == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: PokemonsDt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.pokemons == null)
            {
                return Problem("Entity set 'Contexto.pokemons'  is null.");
            }
            var pokemon = await _context.pokemons.FindAsync(id);
            if (pokemon != null)
            {
                _context.pokemons.Remove(pokemon);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(int id)
        {
          return _context.pokemons.Any(e => e.id == id);
        }
    }
}
