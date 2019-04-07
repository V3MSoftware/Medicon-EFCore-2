using MediconEFC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class PrecoPlano
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public FaixaEtaria FaixaEtaria { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int FaixaEtariaId { get; set; }
        public TipoAcomodacao TipoAcomodacao { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int TipoAcomodacaoId { get; set; }
        public AbrangenciaPlano AbrangenciaPlano { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int AbrangenciaPlanoId { get; set; }
        public TipoContrato TipoContrato { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int TipoContratoId { get; set; }
        public TipoPlano TipoPlano { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int TipoPlanoId { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public double Valor { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        public PrecoPlano()
        {

        }

        public PrecoPlano(int id, FaixaEtaria faixaEtaria, int faixaEtariaId, TipoAcomodacao tipoAcomodacao, int tipoAcomodacaoId, AbrangenciaPlano abrangenciaPlano ,int abrangenciaPlanoId, TipoContrato tipoContrato, TipoPlano tipoPlano, int tipoContratoId, int tipoPlanoId, double valor, string observacao, bool ativo)
        {
            Id = id;
            FaixaEtaria = faixaEtaria;
            FaixaEtariaId = faixaEtariaId;
            TipoAcomodacao = tipoAcomodacao;
            TipoAcomodacaoId = tipoAcomodacaoId;
            AbrangenciaPlano = abrangenciaPlano;
            AbrangenciaPlanoId = abrangenciaPlanoId;
            TipoContrato = tipoContrato;
            TipoContratoId = tipoContratoId;
            TipoPlano = tipoPlano;
            TipoPlanoId = tipoPlanoId;
            Valor = valor;
            Observacao = observacao;
            Ativo = ativo;
        }
    }
}
