using Microsoft.EntityFrameworkCore.Migrations;

namespace MediconEFC.Migrations
{
    public partial class AjustesNoModeloDeDadosDependente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Dependente",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Dependente");
        }
    }
}
