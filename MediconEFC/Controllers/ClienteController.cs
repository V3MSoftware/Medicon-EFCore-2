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
    public class ClienteController : Controller
    {
        private readonly MediconEFCContext _context;
        private readonly ClienteService _clienteService;
        private readonly MensagemService _mensagemService;

        public ClienteController(MediconEFCContext context, ClienteService clienteService, MensagemService mensagemService)
        {
            _context = context;
            _clienteService = clienteService;
            _mensagemService = mensagemService;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            var model = await _clienteService.FindAllAsync();
            return View(model);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Cliente não encontrado!" });
            }

            var obj = await _clienteService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Cliente não encontrado!" });
            }

            return View(obj);
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Cliente não encontrado!" });
            }

            var obj = await _clienteService.FindByIdAsync(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Cliente não encontrado!" });
            }

            return View(obj);
        }

        #region chamadas ajax

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CadastrarCliente(Cliente cliente, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();
            if (ModelState.IsValid)
            {
                if (!_clienteService.ExistsCliente(cliente))
                {
                    try
                    {
                        cliente.Ativo = true;//TODO: Sempre que for cadastro já setar como ativo e tirar a opção da tela para que o usuário não cadastre uma equipe inativa.
                        _clienteService.CadastrarCliente(cliente);

                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_137).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_137).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemSucesso;
                    }
                    catch (Exception)
                    {
                        data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_138).Numero;
                        data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_138).Decricao;
                        data.RedirecionarHome = true;
                        data.TituloMensagem = Constantes.TituloMensagemErro;

                    }
                }
                else
                {
                    data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_139).Numero;
                    data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_139).Decricao;
                    data.RedirecionarHome = true;
                    data.TituloMensagem = Constantes.TituloMensagemAlerta;
                }

                return Json(data, serializerSettings);
            }
            else
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_138).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_138).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

                return Json(data, serializerSettings);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AlterarCliente(Cliente cliente, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            if (cliente.Id <= 0 || !ModelState.IsValid)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_135).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_135).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;
            }

            try
            {
                _clienteService.AlterarCliente(cliente);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_131).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_131).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (ApplicationException)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_141).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_141).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemErro;

            }

            return Json(data, serializerSettings);
        }

        public JsonResult ExcluirCliente(int id, JsonSerializerSettings serializerSettings)
        {
            MensagemRetornoViewModel data = new MensagemRetornoViewModel();

            try
            {
                _clienteService.RemoveCliente(id);

                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_134).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_134).Decricao;
                data.RedirecionarHome = true;
                data.TituloMensagem = Constantes.TituloMensagemSucesso;
            }
            catch (Exception)
            {
                data.NumeroMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_133).Numero;
                data.DescricaoMensagem = _mensagemService.RetornarMensagemPorNumero(Constantes.MENSAGEM_133).Decricao;
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
