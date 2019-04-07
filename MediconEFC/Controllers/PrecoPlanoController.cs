using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MediconEFC.Data;
using MediconEFC.Models;
using MediconEFC.Services;
using System.Diagnostics;

namespace MediconEFC.Controllers
{
    public class PrecoPlanoController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly PrecoPlanoService _precoPlanoService;
        private readonly MensagemService _mensagemService;


        public PrecoPlanoController(MediconEFCContext context, PrecoPlanoService precoPlanoService, MensagemService mensagemService)
        {
            _context = context;
            _precoPlanoService = precoPlanoService;
            _mensagemService = mensagemService;
        }

        // GET: PrecoPlano
        public async Task<IActionResult> Index()
        {
            var listaPrecoPlano = await _precoPlanoService.FindAllAsync();
            IEnumerable<PrecoPlanoViewModel> model = ConverterPrecoPlanoParaPrecoPlanoViewModel(listaPrecoPlano);
            return View(model);
        }

        // GET: PrecoPlano/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            //FindByIdAsync
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Preço Plano não encontrado!" });
            }

            var obj = await _precoPlanoService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Preço Plano não encontrado!" });
            }

            return View(obj);
        }

        // GET: PrecoPlano/Create
        public async Task<IActionResult> Create()
        {
            //ViewData["AbrangenciaPlanoId"] = new SelectList(_context.AbrangenciaPlano, "Id", "Nome");
            //ViewData["FaixaEtariaId"] = new SelectList(_context.FaixaEtaria, "Id", "Descricao");
            //ViewData["TipoAcomodacaoId"] = new SelectList(_context.TipoAcomodacao, "Id", "Nome");
            //ViewData["TipoContratoId"] = new SelectList(_context.TipoContrato, "Id", "Nome");
            //ViewData["TipoPlanoId"] = new SelectList(_context.TipoPlano, "Id", "Nome");


            var _listaAbrangenciaPlano = await _context.AbrangenciaPlano.ToListAsync();
            var _listaFaixaEtaria = await _context.FaixaEtaria.ToListAsync();
            var _listaTipoAcomodacao = await _context.TipoAcomodacao.ToListAsync();
            var _listaTipoContrato = await _context.TipoContrato.ToListAsync();
            var _listaTipoPlano = await _context.TipoPlano.ToListAsync();
            var viewModel = new PrecoPlanoViewModel
            {
                listaAbrangenciaPlano = _listaAbrangenciaPlano,
                listaFaixaEtaria = _listaFaixaEtaria,
                listaTipoAcomodacao = _listaTipoAcomodacao,
                listaTipoContrato = _listaTipoContrato,
                listaTipoPlano = _listaTipoPlano
            };


            return View(viewModel);
        }

        // POST: PrecoPlano/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FaixaEtariaId,TipoAcomodacaoId,AbrangenciaPlanoId,TipoContratoId,TipoPlanoId,Valor,Observacao,Ativo")] PrecoPlano precoPlano)
        {
            if (ModelState.IsValid)
            {
                _context.Add(precoPlano);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AbrangenciaPlanoId"] = new SelectList(_context.AbrangenciaPlano, "Id", "Nome", precoPlano.AbrangenciaPlanoId);
            ViewData["FaixaEtariaId"] = new SelectList(_context.FaixaEtaria, "Id", "Descricao", precoPlano.FaixaEtariaId);
            ViewData["TipoAcomodacaoId"] = new SelectList(_context.TipoAcomodacao, "Id", "Nome", precoPlano.TipoAcomodacaoId);
            ViewData["TipoContratoId"] = new SelectList(_context.TipoContrato, "Id", "Nome", precoPlano.TipoContratoId);
            ViewData["TipoPlanoId"] = new SelectList(_context.TipoPlano, "Id", "Nome", precoPlano.TipoPlanoId);
            return View(precoPlano);
        }

        // GET: PrecoPlano/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precoPlano = await _context.PrecoPlano.FindAsync(id);
            if (precoPlano == null)
            {
                return NotFound();
            }
            ViewData["AbrangenciaPlanoId"] = new SelectList(_context.AbrangenciaPlano, "Id", "Nome", precoPlano.AbrangenciaPlanoId);
            ViewData["FaixaEtariaId"] = new SelectList(_context.FaixaEtaria, "Id", "Descricao", precoPlano.FaixaEtariaId);
            ViewData["TipoAcomodacaoId"] = new SelectList(_context.TipoAcomodacao, "Id", "Nome", precoPlano.TipoAcomodacaoId);
            ViewData["TipoContratoId"] = new SelectList(_context.TipoContrato, "Id", "Nome", precoPlano.TipoContratoId);
            ViewData["TipoPlanoId"] = new SelectList(_context.TipoPlano, "Id", "Nome", precoPlano.TipoPlanoId);
            return View(precoPlano);
        }

        // POST: PrecoPlano/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FaixaEtariaId,TipoAcomodacaoId,AbrangenciaPlanoId,TipoContratoId,TipoPlanoId,Valor,Observacao,Ativo")] PrecoPlano precoPlano)
        {
            if (id != precoPlano.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(precoPlano);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrecoPlanoExists(precoPlano.Id))
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
            ViewData["AbrangenciaPlanoId"] = new SelectList(_context.AbrangenciaPlano, "Id", "Nome", precoPlano.AbrangenciaPlanoId);
            ViewData["FaixaEtariaId"] = new SelectList(_context.FaixaEtaria, "Id", "Descricao", precoPlano.FaixaEtariaId);
            ViewData["TipoAcomodacaoId"] = new SelectList(_context.TipoAcomodacao, "Id", "Nome", precoPlano.TipoAcomodacaoId);
            ViewData["TipoContratoId"] = new SelectList(_context.TipoContrato, "Id", "Nome", precoPlano.TipoContratoId);
            ViewData["TipoPlanoId"] = new SelectList(_context.TipoPlano, "Id", "Nome", precoPlano.TipoPlanoId);
            return View(precoPlano);
        }

        // GET: PrecoPlano/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var precoPlano = await _context.PrecoPlano
                .Include(p => p.AbrangenciaPlano)
                .Include(p => p.FaixaEtaria)
                .Include(p => p.TipoAcomodacao)
                .Include(p => p.TipoContrato)
                .Include(p => p.TipoPlano)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (precoPlano == null)
            {
                return NotFound();
            }

            return View(precoPlano);
        }

        // POST: PrecoPlano/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var precoPlano = await _context.PrecoPlano.FindAsync(id);
            _context.PrecoPlano.Remove(precoPlano);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrecoPlanoExists(int id)
        {
            return _context.PrecoPlano.Any(e => e.Id == id);
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }


        #region Conversores

        private IEnumerable<PrecoPlanoViewModel> ConverterPrecoPlanoParaPrecoPlanoViewModel(List<PrecoPlano> listaEntrada)
        {
            return listaEntrada != null
                ? listaEntrada.Select(entrada => new PrecoPlanoViewModel()
                {
                    precoPlano = new PrecoPlano()
                    {
                        Id = entrada.Id,
                        Valor = entrada.Valor,
                        Observacao = entrada.Observacao,
                        Ativo = entrada.Ativo,
                        FaixaEtariaId = entrada.FaixaEtariaId,
                        TipoAcomodacaoId = entrada.TipoAcomodacaoId,
                        AbrangenciaPlanoId = entrada.AbrangenciaPlanoId,
                        TipoContratoId = entrada.TipoContratoId,
                        TipoPlanoId = entrada.TipoPlanoId
                    },
                    faixaEtaria = new FaixaEtaria()
                    {
                        Id = entrada.FaixaEtaria.Id,
                        Descricao = entrada.FaixaEtaria.Descricao,
                        Ativo = entrada.FaixaEtaria.Ativo
                    },
                    tipoAcomodacao = new TipoAcomodacao()
                    {
                        Id = entrada.TipoAcomodacao.Id,
                        Nome = entrada.TipoAcomodacao.Nome
                    },
                    abrangenciaPlano = new AbrangenciaPlano()
                    {
                        Id = entrada.AbrangenciaPlano.Id,
                        Nome = entrada.AbrangenciaPlano.Nome
                    },
                    tipoContrato = new TipoContrato()
                    {
                        Id = entrada.TipoContrato.Id,
                        Nome = entrada.TipoContrato.Nome
                    },
                    tipoPlano = new TipoPlano()
                    {
                        Id = entrada.TipoPlano.Id,
                        Nome = entrada.TipoPlano.Nome
                    }
                }).ToList()
            :
            null;
        }

        #endregion






    }
}
