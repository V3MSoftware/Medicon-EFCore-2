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
using Newtonsoft.Json;
using Medicon.UtilLocal;
using System.Diagnostics;

namespace MediconEFC.Controllers
{
    public class EquipeController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly EquipeService _equipeService;
        private readonly MensagemService _mensagemService;
        private readonly CorretorService _corretorService;

        public EquipeController(MediconEFCContext context, EquipeService equipeService, MensagemService mensagemService, CorretorService corretorService)
        {
            _context = context;
            _equipeService = equipeService;
            _mensagemService = mensagemService;
            _corretorService = corretorService;
        }

        // GET: Equipe
        public async Task<IActionResult> Index()
        {
            var listaEquipe = await _equipeService.FindAllAsync();
            IEnumerable<EquipeViewModel> model = ConverterEquipeParaEquipeViewModel(listaEquipe);
            return View(model);
        }

        // GET: Equipe/Create
        public async Task<IActionResult> Create()
        {
            var listaCorretor = await _corretorService.FindAllAsync();
            var viewModel = new EquipeViewModel { listaCorretor = listaCorretor };
            //viewModel.Equipe = new Equipe();

            return View(viewModel);
        }

        // GET: Equipe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Equipe não encontrada!" });
            }

            var equipe = await _equipeService.FindByIdAsync(id.Value);
            if (equipe == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Corretor> lstCorretor = await _corretorService.FindAllAsync();
            EquipeViewModel viewModel = new EquipeViewModel { Equipe = equipe, listaCorretor = lstCorretor };
            return View(viewModel);
        }
        
        // GET: Equipe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Equipe não encontrado!" });
            }

            var model = await _equipeService.FindByIdAsync(id.Value);

            if (model == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Equipe não encontrado!" });
            }

            return View(model);
        }

        private bool EquipeExists(int id)
        {
            return _context.Equipe.Any(e => e.Id == id);
        }

        #region chamadas ajax


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarEquipe(EquipeViewModel modelEquipe, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();
            if (ModelState.IsValid)
            {
                if (!_equipeService.ExistsEquipe(modelEquipe.Equipe))
                {
                    try
                    {
                        modelEquipe.Equipe.Ativo = true;//TODO: Sempre que for cadastro já setar como ativo e tirar a opção da tela para que o usuário não cadastre uma equipe inativa.
                        _equipeService.CadastrarEquipe(modelEquipe.Equipe);

                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_110).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_110).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemSucesso;
                    }
                    catch (Exception)
                    {
                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_118).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_118).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemErro;

                    }
                }
                else
                {
                    data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_119).Numero;
                    data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_119).Decricao;
                    data.RedirecionarHome = true;
                    data.TituloMensagem = Constantes.TituloMensagemAlerta;
                }

                return Json(data, serializerSettings);
            }
            else
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_118).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_118).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

                return Json(data, serializerSettings);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AlterarEquipe(EquipeViewModel modelEquipe, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            if (modelEquipe.Equipe.Id <= 0 || !ModelState.IsValid)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_115).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_115).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            try
            {
                _equipeService.AlterarEquipe(ConverterEquipeViewModelParaEquipe(modelEquipe));

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_117).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_117).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (ApplicationException)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_112).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_112).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

            }

            return Json(data, serializerSettings);
        }

        public JsonResult ExcluirEquipe(int id, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            try
            {
                _equipeService.RemoveEquipe(id);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_114).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_114).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (Exception)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_113).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_113).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            return Json(data, serializerSettings);
        }

        #endregion

        #region conversores

        private IEnumerable<EquipeViewModel> ConverterEquipeParaEquipeViewModel(List<Equipe> listaEntrada)
        {
            return listaEntrada != null
                ? listaEntrada.Select(entrada => new EquipeViewModel()
                {
                    Equipe = new Equipe()
                    {
                        Id = entrada.Id,
                        Nome = entrada.Nome,
                        Telefone = entrada.Telefone,
                        Contato = entrada.Contato,
                        Ativo = entrada.Ativo,
                        CorretorId = entrada.CorretorId,
                    },
                    Corretor = new Corretor()
                    {
                        Id = entrada.Corretor.Id,
                        Nome = entrada.Corretor.Nome,
                        Ativo = entrada.Corretor.Ativo
                    }

                }).ToList()
            :
            null;
        }

        private Equipe ConverterEquipeViewModelParaEquipe(EquipeViewModel entrada)
        {
            Equipe saida = null;
            if (entrada != null)
            {
                saida = new Equipe();
                saida = entrada.Equipe;
            }

            return saida;
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
