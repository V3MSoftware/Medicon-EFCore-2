using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediconEFC.Data;
using MediconEFC.Models;
using MediconEFC.Services;
using Medicon.UtilLocal;
using Newtonsoft.Json;

namespace MediconEFC.Controllers
{
    public class FaixaEtariaController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly FaixaEtariaService _faixaEtariaService;
        private readonly MensagemService _mensagemService;

        public FaixaEtariaController(MediconEFCContext context, FaixaEtariaService faixaEtariaService, MensagemService mensagemService)
        {
            _context = context;
            _faixaEtariaService = faixaEtariaService;
            _mensagemService = mensagemService;
        }

        // GET: FaixaEtaria
        public async Task<IActionResult> Index()
        {
            var model = await _faixaEtariaService.FindAllAsync();
            return View(model);
        }

        // GET: FaixaEtaria/Create
        public IActionResult Create()
        {
            return View();
        }


        // GET: FaixaEtaria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Faixa etária não encontrada!" });
            }

            var obj = await _faixaEtariaService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Faixa etária não encontrada!" });
            }

            return View(obj);
        }

        // GET: FaixaEtaria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Faixa etária não encontrada!" });
            }

            var obj = await _faixaEtariaService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Faixa etária não encontrada!" });
            }

            return View(obj);
        }



        #region chamadas ajax


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarFaixaEtaria(FaixaEtaria faixaEtaria, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();
            if (ModelState.IsValid)
            {
                if (!_faixaEtariaService.ExistsFaixaEtaria(faixaEtaria))
                {
                    try
                    {
                        _faixaEtariaService.CadastrarFaixaEtaria(faixaEtaria);

                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_146).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_146).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemSucesso;
                    }
                    catch (Exception)
                    {
                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_147).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_147).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemErro;

                    }
                }
                else
                {
                    data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_148).Numero;
                    data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_148).Decricao;
                    data.RedirecionarHome = true;
                    data.TituloMensagem = Constantes.TituloMensagemAlerta;
                }

                return Json(data, serializerSettings);
            }
            else
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_147).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_147).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

                return Json(data, serializerSettings);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AlterarFaixaEtaria(int id, FaixaEtaria  faixaEtaria, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            if (id != faixaEtaria.Id || !ModelState.IsValid)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_143).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_143).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            try
            {
                _faixaEtariaService.AlterarFaixaEtaria(faixaEtaria);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_161).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_161).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (ApplicationException)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_149).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_149).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

            }

            return Json(data, serializerSettings);
        }

        public JsonResult ExcluirFaixaEtaria(int id, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            try
            {
                _faixaEtariaService.RemoveFaixaEtaria(id);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_144).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_144).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (Exception)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_150).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_150).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            return Json(data, serializerSettings);
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

        #endregion

        private bool FaixaEtariaExists(int id)
        {
            return _context.FaixaEtaria.Any(e => e.Id == id);
        }
    }
}
