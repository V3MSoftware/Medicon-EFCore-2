
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Corretor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }

        public string Telefone { get; set; }
        public bool Ativo { get; set; }        
        public ICollection<Equipe> Equipes { get; set; }

        public Corretor()
        {

        }

        public Corretor(int id, string nome, string telefone, bool ativo)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Ativo = ativo;            
        }

        //public void AddEquipe(Equipe equipe)
        //{
        //    Equipes.Add(equipe);
        //}

        //public void RemoveEquipe(Equipe equipe)
        //{
        //    Equipes.Remove(equipe);
        //}
    }
}
