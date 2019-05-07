using Microsoft.EntityFrameworkCore.Migrations;

namespace Trucking.Entities.Migrations
{
    public partial class AddColumnToFreight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FreightType",
                table: "Freights",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreightType",
                table: "Freights");
        }
    }
}
