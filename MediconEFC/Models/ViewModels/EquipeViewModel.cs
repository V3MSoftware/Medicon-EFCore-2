using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class EquipeViewModel
    {
        public Equipe Equipe { get; set; }
        public Corretor Corretor { get; set; }
        public ICollection<Corretor> listaCorretor { get; set; }
    }
}
