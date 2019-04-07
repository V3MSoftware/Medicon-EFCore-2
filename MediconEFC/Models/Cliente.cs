using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class Cliente
    {

        /// <summary>
        /// Carregar endereço a partir do cep
        /// http://www.eduardorizo.com.br/2014/12/04/correios-webservice-para-consulta-de-enderecos-a-partir-de-um-cep/
        /// </summary>

        /// <summary>
        /// Validação de email 
        /// http://www.eduardopires.net.br/2013/04/mvc-validando-dados-com-dataannotations/
        /// </summary>

        /// <summary>
        /// Validação de cpf valido
        /// https://github.com/lucas-silva/mvczin/tree/master/Mvczin.Web/Mvc/Validation
        /// </summary>

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        [Display(Name = "E-mail")]
        [RegularExpression(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*$", ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        public string Observacao { get; set; }
        public bool Ativo { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string nome, string cpf, string cep, string endereco, int numero, string complemento, string bairro, string cidade, string estado, string telefone, string celular, string email, string observacao, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Cep = cep;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Observacao = observacao;
            Ativo = ativo;
        }
    }

}
