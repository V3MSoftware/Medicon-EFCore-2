using Microsoft.EntityFrameworkCore.Migrations;

namespace MediconEFC.Migrations
{
    public partial class AjustesNoModeloDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependente_Proposta_PropostaId",
                table: "Dependente");

            migrationBuilder.DropIndex(
                name: "IX_Dependente_PropostaId",
                table: "Dependente");

            migrationBuilder.DropColumn(
                name: "PropostaId",
                table: "Dependente");

            migrationBuilder.RenameColumn(
                name: "TipoDependenteId",
                table: "Proposta",
                newName: "DependenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Proposta_DependenteId",
                table: "Proposta",
                column: "DependenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposta_Dependente_DependenteId",
                table: "Proposta",
                column: "DependenteId",
                principalTable: "Dependente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposta_Dependente_DependenteId",
                table: "Proposta");

            migrationBuilder.DropIndex(
                name: "IX_Proposta_DependenteId",
                table: "Proposta");

            migrationBuilder.RenameColumn(
                name: "DependenteId",
                table: "Proposta",
                newName: "TipoDependenteId");

            migrationBuilder.AddColumn<int>(
                name: "PropostaId",
                table: "Dependente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dependente_PropostaId",
                table: "Dependente",
                column: "PropostaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependente_Proposta_PropostaId",
                table: "Dependente",
                column: "PropostaId",
                principalTable: "Proposta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
