using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArsenalDeTanques.Data;
using ArsenalDeTanques.Models;
using Microsoft.AspNetCore.Authorization;

namespace ArsenalDeTanques.Controllers
{
    public class TiposController : Controller
    {
        private readonly ArsenalContext _context;

        public TiposController(ArsenalContext context)
        {
            _context = context;
        }

        // GET: Tipos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoTanque.ToListAsync());
        }

        // GET: Tipos/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTanque = await _context.TipoTanque
                .Include(T => T.tanques)
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoTanque == null)
            {
                return NotFound();
            }

            return View(tipoTanque);
        }

        // GET: Tipos/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tipos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("id,NomeTipo,LinkImagem,Compras")] TipoTanque tipoTanque)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoTanque);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoTanque);
        }

        // GET: Tipos/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTanque = await _context.TipoTanque.FindAsync(id);
            if (tipoTanque == null)
            {
                return NotFound();
            }
            return View(tipoTanque);
        }

        // POST: Tipos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("id,NomeTipo,LinkImagem,Compras")] TipoTanque tipoTanque)
        {
            if (id != tipoTanque.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoTanque);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoTanqueExists(tipoTanque.id))
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
            return View(tipoTanque);
        }

        // GET: Tipos/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTanque = await _context.TipoTanque
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoTanque == null)
            {
                return NotFound();
            }

            return View(tipoTanque);
        }

        // POST: Tipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoTanque = await _context.TipoTanque.FindAsync(id);
            _context.TipoTanque.Remove(tipoTanque);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoTanqueExists(int id)
        {
            return _context.TipoTanque.Any(e => e.id == id);
        }
    }
}
