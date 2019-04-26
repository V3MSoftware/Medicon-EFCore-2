using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Models
{
    public class UploadArquivo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public Proposta Proposta { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public int PropstaId { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public byte Arquivo { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string Mime { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string NomeArquivo { get; set; }
        [Required(ErrorMessage = "Campo {0} não foi preenchido.")]
        public string DataUploadArquivo { get; set; }

        public UploadArquivo()
        {

        }

        public UploadArquivo(int id, Proposta proposta, int propstaId, byte arquivo, string mime, string nomeArquivo, string dataUploadArquivo)
        {
            Id = id;
            Proposta = proposta;
            PropstaId = propstaId;
            Arquivo = arquivo;
            Mime = mime;
            NomeArquivo = nomeArquivo;
            DataUploadArquivo = dataUploadArquivo;
        }
    }
}
