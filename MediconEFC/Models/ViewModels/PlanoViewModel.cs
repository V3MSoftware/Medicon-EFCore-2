using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class PlanoViewModel : MensagemRetornoViewModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }

        public bool ConfirmarAlteracaoPlano { get; set; }
    }
}
