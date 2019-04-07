using MediconEFC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Data
{
    public class MediconEFCContext : DbContext
    {
        public MediconEFCContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Mensagem> Mensagem { get; set; }
        public DbSet<Plano> Plano { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Corretor> Corretor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<FaixaEtaria> FaixaEtaria { get; set; }        
        public DbSet<PrecoPlano> PrecoPlano { get; set; }
        public DbSet<Proposta> Proposta { get; set; }
        public DbSet<Dependente> Dependente { get; set; }
        public DbSet<UploadArquivo> UploadArquivo { get; set; }
        //============Alteração para colocar os tipos nas tabelas de apaio==============
        public DbSet<AbrangenciaPlano> AbrangenciaPlano { get; set; }
        public DbSet<TipoAcomodacao> TipoAcomodacao { get; set; }
        public DbSet<TipoContrato> TipoContrato { get; set; }
        public DbSet<TipoPlano> TipoPlano { get; set; }


    }
}
