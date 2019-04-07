﻿// <auto-generated />
using System;
using MediconEFC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediconEFC.Migrations
{
    [DbContext(typeof(MediconEFCContext))]
    [Migration("20181113192114_Initial_DataBase")]
    partial class Initial_DataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediconEFC.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.Property<string>("Observacao");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("MediconEFC.Models.Corretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Corretor");
                });

            modelBuilder.Entity("MediconEFC.Models.Dependente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<int>("PropostaId");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Dependente");
                });

            modelBuilder.Entity("MediconEFC.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Contato");

                    b.Property<int>("CorretorId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("CorretorId");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("MediconEFC.Models.FaixaEtaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("FaixaEtaria");
                });

            modelBuilder.Entity("MediconEFC.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Decricao")
                        .IsRequired();

                    b.Property<int>("Numero");

                    b.Property<string>("Observacao");

                    b.Property<string>("Segla")
                        .IsRequired();

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Mensagem");
                });

            modelBuilder.Entity("MediconEFC.Models.Plano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("MediconEFC.Models.PrecoPlano", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbrangenciaPlano");

                    b.Property<bool>("Ativo");

                    b.Property<int>("FaixaEtariaId");

                    b.Property<string>("Observacao");

                    b.Property<int>("TipoAcomodacao");

                    b.Property<int>("TipoAcomodacaoId");

                    b.Property<int>("TipoContrato");

                    b.Property<int>("TipoContratoId");

                    b.Property<int>("TipoPlano");

                    b.Property<int>("TipoPlanoId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("FaixaEtariaId");

                    b.ToTable("PrecoPlano");
                });

            modelBuilder.Entity("MediconEFC.Models.Proposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("ClienteId");

                    b.Property<int>("CorretorId");

                    b.Property<DateTime>("DataProposta");

                    b.Property<int>("PlanoId");

                    b.Property<int>("PrecoPlanoId");

                    b.Property<int>("TipoAcomodacao");

                    b.Property<int>("TipoDependenteId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CorretorId");

                    b.HasIndex("PlanoId");

                    b.HasIndex("PrecoPlanoId");

                    b.ToTable("Proposta");
                });

            modelBuilder.Entity("MediconEFC.Models.UploadArquivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Arquivo");

                    b.Property<string>("DataUploadArquivo")
                        .IsRequired();

                    b.Property<string>("Mime")
                        .IsRequired();

                    b.Property<string>("NomeArquivo")
                        .IsRequired();

                    b.Property<int?>("PropostaId");

                    b.Property<int>("PropstaId");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("UploadArquivo");
                });

            modelBuilder.Entity("MediconEFC.Models.Dependente", b =>
                {
                    b.HasOne("MediconEFC.Models.Proposta", "Proposta")
                        .WithMany()
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediconEFC.Models.Equipe", b =>
                {
                    b.HasOne("MediconEFC.Models.Corretor", "Corretor")
                        .WithMany("Equipes")
                        .HasForeignKey("CorretorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediconEFC.Models.PrecoPlano", b =>
                {
                    b.HasOne("MediconEFC.Models.FaixaEtaria", "FaixaEtaria")
                        .WithMany()
                        .HasForeignKey("FaixaEtariaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediconEFC.Models.Proposta", b =>
                {
                    b.HasOne("MediconEFC.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediconEFC.Models.Corretor", "Corretor")
                        .WithMany()
                        .HasForeignKey("CorretorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediconEFC.Models.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MediconEFC.Models.PrecoPlano", "PrecoPlano")
                        .WithMany()
                        .HasForeignKey("PrecoPlanoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MediconEFC.Models.UploadArquivo", b =>
                {
                    b.HasOne("MediconEFC.Models.Proposta", "Proposta")
                        .WithMany()
                        .HasForeignKey("PropostaId");
                });
#pragma warning restore 612, 618
        }
    }
}
