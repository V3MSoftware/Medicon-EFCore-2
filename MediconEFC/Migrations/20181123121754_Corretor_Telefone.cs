using Microsoft.EntityFrameworkCore.Migrations;

namespace MediconEFC.Migrations
{
    public partial class Corretor_Telefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Corretor",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Corretor");
        }
    }
}
