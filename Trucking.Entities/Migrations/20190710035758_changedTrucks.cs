using Microsoft.EntityFrameworkCore.Migrations;

namespace Trucking.Entities.Migrations
{
    public partial class changedTrucks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToAddress",
                table: "Freights",
                newName: "ToCity");

            migrationBuilder.RenameColumn(
                name: "FromAddress",
                table: "Freights",
                newName: "FromCity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToCity",
                table: "Freights",
                newName: "ToAddress");

            migrationBuilder.RenameColumn(
                name: "FromCity",
                table: "Freights",
                newName: "FromAddress");
        }
    }
}
