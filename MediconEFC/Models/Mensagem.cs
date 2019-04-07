using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Mensagem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Segla { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Decricao { get; set; }
        public string Observacao { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Tipo { get; set; }

        public Mensagem()
        {

        }

        public Mensagem(int id, int numero, string segla, string decricao, string observacao, string tipo)
        {
            Id = id;
            Numero = numero;
            Segla = segla;
            Decricao = decricao;
            Observacao = observacao;
            Tipo = tipo;
        }
    }
}
