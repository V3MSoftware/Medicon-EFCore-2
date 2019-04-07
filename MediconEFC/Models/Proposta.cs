using MediconEFC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Proposta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string NomeProsposta { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public DateTime DataProposta { get; set; }
        public Cliente Cliente { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int ClienteId { get; set; }
        public Plano Plano { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int PlanoId { get; set; }
        public Corretor Corretor { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int CorretorId { get; set; }
        public PrecoPlano PrecoPlano { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int PrecoPlanoId { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public Dependente Dependente { get; set; }
        public int DependenteId { get; set; }

        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public double Valor { get; set; }
        public bool Ativo { get; set; }

        public Proposta()
        {

        }

        public Proposta(int id, string nomeProposta, DateTime dataProposta, Cliente cliente, int clienteId, Plano plano, int planoId, Corretor corretor, int corretorId, PrecoPlano precoPlano, int precoPlanoId, Dependente dependente, int dependenteId ,double valor, bool ativo)
        {
            Id = id;
            NomeProsposta = nomeProposta;
            DataProposta = dataProposta;
            Cliente = cliente;
            ClienteId = clienteId;
            Plano = plano;
            PlanoId = planoId;
            Corretor = corretor;
            CorretorId = corretorId;
            PrecoPlano = precoPlano;
            PrecoPlanoId = precoPlanoId;
            Dependente = dependente;
            DependenteId = dependenteId;
            Valor = valor;
            Ativo = ativo;
        }
    }
}
