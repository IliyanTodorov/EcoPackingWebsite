using Microsoft.EntityFrameworkCore.Migrations;

namespace EcoPacking.Data.Migrations
{
    public partial class ChangePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Extention",
                table: "Images",
                newName: "Extension");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Extension",
                table: "Images",
                newName: "Extention");
        }
    }
}
