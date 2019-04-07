using MediconEFC.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class TipoContrato
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }

        public TipoContrato()
        {

        }

        public TipoContrato(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
