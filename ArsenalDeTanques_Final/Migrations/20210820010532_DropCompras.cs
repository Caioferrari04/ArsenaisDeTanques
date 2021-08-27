using Microsoft.EntityFrameworkCore.Migrations;

namespace ArsenalDeTanques.Migrations
{
    public partial class DropCompras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Compras",
                table: "TipoTanque");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Compras",
                table: "TipoTanque",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
