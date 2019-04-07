using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Dependente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Cpf { get; set; }
        public Dependente()
        {

        }

        public Dependente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }
    }
}
