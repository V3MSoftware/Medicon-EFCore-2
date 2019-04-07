using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediconEFC.Migrations
{
    public partial class Initial_DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Observacao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corretor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaixaEtaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaixaEtaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mensagem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(nullable: false),
                    Segla = table.Column<string>(nullable: false),
                    Decricao = table.Column<string>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    CorretorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipe_Corretor_CorretorId",
                        column: x => x.CorretorId,
                        principalTable: "Corretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrecoPlano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FaixaEtariaId = table.Column<int>(nullable: false),
                    TipoAcomodacao = table.Column<int>(nullable: false),
                    TipoAcomodacaoId = table.Column<int>(nullable: false),
                    AbrangenciaPlano = table.Column<int>(nullable: false),
                    TipoContrato = table.Column<int>(nullable: false),
                    TipoContratoId = table.Column<int>(nullable: false),
                    TipoPlano = table.Column<int>(nullable: false),
                    TipoPlanoId = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrecoPlano", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrecoPlano_FaixaEtaria_FaixaEtariaId",
                        column: x => x.FaixaEtariaId,
                        principalTable: "FaixaEtaria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proposta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataProposta = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    PlanoId = table.Column<int>(nullable: false),
                    CorretorId = table.Column<int>(nullable: false),
                    PrecoPlanoId = table.Column<int>(nullable: false),
                    TipoAcomodacao = table.Column<int>(nullable: false),
                    TipoDependenteId = table.Column<int>(nullable: false),
                    Valor = table.Column<double>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proposta_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposta_Corretor_CorretorId",
                        column: x => x.CorretorId,
                        principalTable: "Corretor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposta_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proposta_PrecoPlano_PrecoPlanoId",
                        column: x => x.PrecoPlanoId,
                        principalTable: "PrecoPlano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dependente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    PropostaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependente_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadArquivo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropostaId = table.Column<int>(nullable: true),
                    PropstaId = table.Column<int>(nullable: false),
                    Arquivo = table.Column<byte>(nullable: false),
                    Mime = table.Column<string>(nullable: false),
                    NomeArquivo = table.Column<string>(nullable: false),
                    DataUploadArquivo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadArquivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadArquivo_Proposta_PropostaId",
                        column: x => x.PropostaId,
                        principalTable: "Proposta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependente_PropostaId",
                table: "Dependente",
                column: "PropostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_CorretorId",
                table: "Equipe",
                column: "CorretorId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPlano_FaixaEtariaId",
                table: "PrecoPlano",
                column: "FaixaEtariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_ClienteId",
                table: "Proposta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_CorretorId",
                table: "Proposta",
                column: "CorretorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_PlanoId",
                table: "Proposta",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_PrecoPlanoId",
                table: "Proposta",
                column: "PrecoPlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadArquivo_PropostaId",
                table: "UploadArquivo",
                column: "PropostaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependente");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Mensagem");

            migrationBuilder.DropTable(
                name: "UploadArquivo");

            migrationBuilder.DropTable(
                name: "Proposta");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Corretor");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "PrecoPlano");

            migrationBuilder.DropTable(
                name: "FaixaEtaria");
        }
    }
}
