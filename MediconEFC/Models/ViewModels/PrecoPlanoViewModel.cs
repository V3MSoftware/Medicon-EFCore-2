using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class PrecoPlanoViewModel
    {
        public PrecoPlano precoPlano { get; set; }
        public FaixaEtaria faixaEtaria { get; set; }
        public TipoAcomodacao tipoAcomodacao { get; set; }
        public AbrangenciaPlano abrangenciaPlano { get; set; }
        public TipoContrato tipoContrato { get; set; }
        public TipoPlano tipoPlano { get; set; }

        public ICollection<PrecoPlano> listaPrecoPlano { get; set; }
        public ICollection<FaixaEtaria> listaFaixaEtaria { get; set; }
        public ICollection<TipoAcomodacao> listaTipoAcomodacao { get; set; }
        public ICollection<AbrangenciaPlano> listaAbrangenciaPlano { get; set; }
        public ICollection<TipoContrato> listaTipoContrato { get; set; }
        public ICollection<TipoPlano> listaTipoPlano { get; set; }
    }
}
