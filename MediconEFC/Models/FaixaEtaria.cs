using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class FaixaEtaria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public FaixaEtaria()
        {

        }

        public FaixaEtaria(int id, string descricao, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Ativo = ativo;
        }
    }
}
