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
using Medicon.UtilLocal;
using Newtonsoft.Json;

namespace MediconEFC.Controllers
{
    public class CorretorController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly CorretorService _corretorService;
        private readonly MensagemService _mensagemService;

        public CorretorController(MediconEFCContext context, CorretorService corretorService, MensagemService mensagemService)
        {
            _context = context;
            _corretorService = corretorService;
            _mensagemService = mensagemService;
        }

        // GET: Corretor
        public async Task<IActionResult> Index()
        {
            var model = await _corretorService.FindAllAsync();
            return View(model);
        }


        // GET: Corretor/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Corretor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Corretor não encontrado!" });
            }

            var obj = await _corretorService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Corretor não encontrado!" });
            }
            return View(obj);
        }

        // GET: Corretor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Corretor não encontrado!" });
            }

            var obj = await _corretorService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Corretor não encontrado!" });
            }
            return View(obj);
        }

        #region chamadas ajax

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarCorretor(Corretor corretor, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();
            if (ModelState.IsValid)
            {
                if (!_corretorService.ExistsCorretor(corretor))
                {
                    try
                    {
                        corretor.Ativo = true;//TODO: Sempre que for cadastro já setar como ativo e tirar a opção da tela para que o usuário não cadastre uma equipe inativa.
                        _corretorService.CadastrarCorretor(corretor);

                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_127).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_127).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemSucesso;
                    }
                    catch (Exception)
                    {
                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_128).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_128).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemErro;

                    }
                }
                else
                {
                    data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_129).Numero;
                    data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_129).Decricao;
                    data.RedirecionarHome = true;
                    data.TituloMensagem = Constantes.TituloMensagemAlerta;
                }

                return Json(data, serializerSettings);
            }
            else
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_128).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_128).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

                return Json(data, serializerSettings);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AlterarCorretor(Corretor corretor, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            if (corretor.Id < 0 || !ModelState.IsValid)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_125).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_125).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            try
            {
                _corretorService.AlterarCorretor(corretor);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_120).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_120).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (ApplicationException)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_122).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_122).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            return Json(data, serializerSettings);
        }

        public JsonResult ExcluirCorretor(int id, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            try
            {
                _corretorService.RemoveCorretor(id);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_124).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_124).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (Exception)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_123).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_123).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            return Json(data, serializerSettings);
        }

        #endregion

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
