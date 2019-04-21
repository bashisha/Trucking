using Microsoft.EntityFrameworkCore.Migrations;

namespace Trucking.Entities.Migrations
{
    public partial class AddedFieldToTruck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentLocationId",
                table: "Trucks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_CurrentLocationId",
                table: "Trucks",
                column: "CurrentLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Addresses_CurrentLocationId",
                table: "Trucks",
                column: "CurrentLocationId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Addresses_CurrentLocationId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trucks_CurrentLocationId",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "CurrentLocationId",
                table: "Trucks");
        }
    }
}
