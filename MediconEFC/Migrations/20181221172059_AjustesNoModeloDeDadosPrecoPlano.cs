using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediconEFC.Migrations
{
    public partial class AjustesNoModeloDeDadosPrecoPlano : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoAcomodacao",
                table: "Proposta");

            migrationBuilder.DropColumn(
                name: "AbrangenciaPlano",
                table: "PrecoPlano");

            migrationBuilder.DropColumn(
                name: "TipoAcomodacao",
                table: "PrecoPlano");

            migrationBuilder.DropColumn(
                name: "TipoContrato",
                table: "PrecoPlano");

            migrationBuilder.RenameColumn(
                name: "TipoPlano",
                table: "PrecoPlano",
                newName: "AbrangenciaPlanoId");

            migrationBuilder.CreateTable(
                name: "AbrangenciaPlano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbrangenciaPlano", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoAcomodacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAcomodacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContrato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPlano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPlano", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPlano_AbrangenciaPlanoId",
                table: "PrecoPlano",
                column: "AbrangenciaPlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPlano_TipoAcomodacaoId",
                table: "PrecoPlano",
                column: "TipoAcomodacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPlano_TipoContratoId",
                table: "PrecoPlano",
                column: "TipoContratoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrecoPlano_TipoPlanoId",
                table: "PrecoPlano",
                column: "TipoPlanoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoPlano_AbrangenciaPlano_AbrangenciaPlanoId",
                table: "PrecoPlano",
                column: "AbrangenciaPlanoId",
                principalTable: "AbrangenciaPlano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoPlano_TipoAcomodacao_TipoAcomodacaoId",
                table: "PrecoPlano",
                column: "TipoAcomodacaoId",
                principalTable: "TipoAcomodacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoPlano_TipoContrato_TipoContratoId",
                table: "PrecoPlano",
                column: "TipoContratoId",
                principalTable: "TipoContrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrecoPlano_TipoPlano_TipoPlanoId",
                table: "PrecoPlano",
                column: "TipoPlanoId",
                principalTable: "TipoPlano",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrecoPlano_AbrangenciaPlano_AbrangenciaPlanoId",
                table: "PrecoPlano");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoPlano_TipoAcomodacao_TipoAcomodacaoId",
                table: "PrecoPlano");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoPlano_TipoContrato_TipoContratoId",
                table: "PrecoPlano");

            migrationBuilder.DropForeignKey(
                name: "FK_PrecoPlano_TipoPlano_TipoPlanoId",
                table: "PrecoPlano");

            migrationBuilder.DropTable(
                name: "AbrangenciaPlano");

            migrationBuilder.DropTable(
                name: "TipoAcomodacao");

            migrationBuilder.DropTable(
                name: "TipoContrato");

            migrationBuilder.DropTable(
                name: "TipoPlano");

            migrationBuilder.DropIndex(
                name: "IX_PrecoPlano_AbrangenciaPlanoId",
                table: "PrecoPlano");

            migrationBuilder.DropIndex(
                name: "IX_PrecoPlano_TipoAcomodacaoId",
                table: "PrecoPlano");

            migrationBuilder.DropIndex(
                name: "IX_PrecoPlano_TipoContratoId",
                table: "PrecoPlano");

            migrationBuilder.DropIndex(
                name: "IX_PrecoPlano_TipoPlanoId",
                table: "PrecoPlano");

            migrationBuilder.RenameColumn(
                name: "AbrangenciaPlanoId",
                table: "PrecoPlano",
                newName: "TipoPlano");

            migrationBuilder.AddColumn<int>(
                name: "TipoAcomodacao",
                table: "Proposta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbrangenciaPlano",
                table: "PrecoPlano",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoAcomodacao",
                table: "PrecoPlano",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoContrato",
                table: "PrecoPlano",
                nullable: false,
                defaultValue: 0);
        }
    }
}
