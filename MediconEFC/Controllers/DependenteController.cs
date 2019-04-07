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
    public class DependenteController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly DependenteService _dependenteService;
        private readonly MensagemService _mensagemService;

        public DependenteController(MediconEFCContext context, DependenteService dependenteService , MensagemService mensagemService)
        {
            _context = context;
            _dependenteService = dependenteService;
            _mensagemService = mensagemService;
        }

        #region chamadas assincronas

        // GET: Plano
        public async Task<IActionResult> Index()
        {
            var model = await _dependenteService.FindAllAsync();
            return View(model);
        }

        // GET: Plano/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Plano/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Dependente não encontrado!" });
            }

            var obj = await _dependenteService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Dependente não encontrado!" });
            }

            return View(obj);
        }

        // GET: Plano/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Dependente não encontrado!" });
            }

            var obj = await _dependenteService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Dependente não encontrado!" });
            }

            return View(obj);
        }

        #endregion

        #region chamadas ajax

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarDependente(Dependente dependente, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();
            if (ModelState.IsValid)
            {
                if (!_dependenteService.ExistsDependente(dependente))
                {
                    try
                    {
                        _dependenteService.CadastrarDependente(dependente);

                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_155).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_155).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemSucesso;
                    }
                    catch (Exception)
                    {
                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemErro;

                    }
                }
                else
                {
                    data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_152).Numero;
                    data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_152).Decricao;
                    data.RedirecionarHome = true;
                    data.TituloMensagem = Constantes.TituloMensagemAlerta;
                }

                return Json(data, serializerSettings);
            }
            else
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

                return Json(data, serializerSettings);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AlterarDependente(int id, Dependente dependente, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            if (id != dependente.Id || !ModelState.IsValid)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_152).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_152).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            try
            {
                _dependenteService.AlterarDependente(dependente);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_160).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_160).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (ApplicationException)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_156).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

            }

            return Json(data, serializerSettings);
        }

        public JsonResult ExcluirDependente(int id, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            try
            {
                _dependenteService.RemoveDependente(id);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_153).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_153).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (Exception)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_159).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_159).Decricao;
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
    }
}
