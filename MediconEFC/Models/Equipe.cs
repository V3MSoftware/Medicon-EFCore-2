using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Equipe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Contato { get; set; }
        public bool Ativo { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int CorretorId { get; set; }
        public Corretor Corretor { get; set; }


        public Equipe()
        {

        }

        public Equipe(int id, string nome, string telefone, string contato, bool ativo, int corretorId, Corretor corretor)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Contato = contato;
            Ativo = ativo;
            CorretorId = corretorId;
            Corretor = corretor;
        }
    }
}
