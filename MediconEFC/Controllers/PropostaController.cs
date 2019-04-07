using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediconEFC.Data;
using MediconEFC.Models;

namespace MediconEFC.Controllers
{
    public class PropostaController : Controller
    {
        private readonly MediconEFCContext _context;

        public PropostaController(MediconEFCContext context)
        {
            _context = context;
        }

        // GET: Proposta
        public async Task<IActionResult> Index()
        {
            var mediconEFCContext = _context.Proposta.Include(p => p.Cliente).Include(p => p.Corretor).Include(p => p.Dependente).Include(p => p.Plano).Include(p => p.PrecoPlano);
            return View(await mediconEFCContext.ToListAsync());
        }

        // GET: Proposta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .Include(p => p.Cliente)
                .Include(p => p.Corretor)
                .Include(p => p.Dependente)
                .Include(p => p.Plano)
                .Include(p => p.PrecoPlano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

        // GET: Proposta/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Cpf");
            ViewData["CorretorId"] = new SelectList(_context.Corretor, "Id", "Nome");
            ViewData["DependenteId"] = new SelectList(_context.Dependente, "Id", "Cpf");
            ViewData["PlanoId"] = new SelectList(_context.Plano, "Id", "Nome");
            ViewData["PrecoPlanoId"] = new SelectList(_context.PrecoPlano, "Id", "Id");
            return View();
        }

        // POST: Proposta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeProsposta,DataProposta,ClienteId,PlanoId,CorretorId,PrecoPlanoId,DependenteId,Valor,Ativo")] Proposta proposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Cpf", proposta.ClienteId);
            ViewData["CorretorId"] = new SelectList(_context.Corretor, "Id", "Nome", proposta.CorretorId);
            ViewData["DependenteId"] = new SelectList(_context.Dependente, "Id", "Cpf", proposta.DependenteId);
            ViewData["PlanoId"] = new SelectList(_context.Plano, "Id", "Nome", proposta.PlanoId);
            ViewData["PrecoPlanoId"] = new SelectList(_context.PrecoPlano, "Id", "Id", proposta.PrecoPlanoId);
            return View(proposta);
        }

        // GET: Proposta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta.FindAsync(id);
            if (proposta == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Cpf", proposta.ClienteId);
            ViewData["CorretorId"] = new SelectList(_context.Corretor, "Id", "Nome", proposta.CorretorId);
            ViewData["DependenteId"] = new SelectList(_context.Dependente, "Id", "Cpf", proposta.DependenteId);
            ViewData["PlanoId"] = new SelectList(_context.Plano, "Id", "Nome", proposta.PlanoId);
            ViewData["PrecoPlanoId"] = new SelectList(_context.PrecoPlano, "Id", "Id", proposta.PrecoPlanoId);
            return View(proposta);
        }

        // POST: Proposta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeProsposta,DataProposta,ClienteId,PlanoId,CorretorId,PrecoPlanoId,DependenteId,Valor,Ativo")] Proposta proposta)
        {
            if (id != proposta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropostaExists(proposta.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Cpf", proposta.ClienteId);
            ViewData["CorretorId"] = new SelectList(_context.Corretor, "Id", "Nome", proposta.CorretorId);
            ViewData["DependenteId"] = new SelectList(_context.Dependente, "Id", "Cpf", proposta.DependenteId);
            ViewData["PlanoId"] = new SelectList(_context.Plano, "Id", "Nome", proposta.PlanoId);
            ViewData["PrecoPlanoId"] = new SelectList(_context.PrecoPlano, "Id", "Id", proposta.PrecoPlanoId);
            return View(proposta);
        }

        // GET: Proposta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proposta = await _context.Proposta
                .Include(p => p.Cliente)
                .Include(p => p.Corretor)
                .Include(p => p.Dependente)
                .Include(p => p.Plano)
                .Include(p => p.PrecoPlano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposta == null)
            {
                return NotFound();
            }

            return View(proposta);
        }

        // POST: Proposta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proposta = await _context.Proposta.FindAsync(id);
            _context.Proposta.Remove(proposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropostaExists(int id)
        {
            return _context.Proposta.Any(e => e.Id == id);
        }
    }
}
