using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppArticulos.Migrations
{
    public partial class CorrecionPrecioUnitario2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "Productos",
                newName: "PrecioUnitario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "Productos",
                newName: "PrecioUnitario");
        }
    }
}
