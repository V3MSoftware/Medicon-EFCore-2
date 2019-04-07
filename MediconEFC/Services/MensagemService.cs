using Microsoft.EntityFrameworkCore;
using MediconEFC.Models;
using MediconEFC.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediconEFC.Data;

namespace MediconEFC.Services
{
    public class MensagemService
    {
        private readonly MediconEFCContext _context;

        public MensagemService(MediconEFCContext context)
        {
            _context = context;
        }

        public Mensagem RetornarMensagemPorNumero(int numeroMensagem)
        {
            List<Mensagem> listaMensagem = _context.Mensagem.ToList();
            Mensagem mensagem = new Mensagem();

            foreach (Mensagem item in from item in listaMensagem
                                      where item.Numero.Equals(numeroMensagem)
                                      select item)
            {
                mensagem.Id = item.Id;
                mensagem.Numero = item.Numero;
                mensagem.Segla = item.Segla;
                mensagem.Decricao = item.Decricao;
                mensagem.Observacao = item.Observacao;
                mensagem.Tipo = item.Tipo;
            }

            return mensagem;
        }
    }
}
