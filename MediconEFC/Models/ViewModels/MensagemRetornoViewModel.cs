using System;

namespace MediconEFC.Models
{
    public class MensagemRetornoViewModel
    {
        public MensagemRetornoViewModel()
        {
            this.ExibirMensagem = true;
        }

        /// <summary>
        /// Caso a mensagem sejá valida será setado true
        /// </summary>
        public bool MensagemValida { get; set; }

        /// <summary>
        /// Codigo interno da Mensagem
        /// </summary>
        public int NumeroMensagem { get; set; }

        /// <summary>
        /// Descrição completa da mensagem que será exibida ao usuario
        /// </summary>
        public string DescricaoMensagem { get; set; }

        /// <summary>
        /// Titulo que será exibido no cabeçalho do modal
        /// </summary>
        public string TituloMensagem { get; set; }

        /// <summary>
        /// Caso seja necessario redirecionar a Home setar como true
        /// </summary>
        public bool RedirecionarHome { get; set; }

        /// <summary>
        /// Está url será montada para redirecionar a outra pagina
        /// </summary>
        public string UrlRetorno { get; set; }

        /// <summary>
        /// Por padrao ele exibe a mensagem
        /// </summary>
        public bool ExibirMensagem { get; set; }
    }
}