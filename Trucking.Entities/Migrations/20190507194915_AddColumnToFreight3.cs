using Microsoft.EntityFrameworkCore.Migrations;

namespace Trucking.Entities.Migrations
{
    public partial class AddColumnToFreight3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Freights",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Freights");
        }
    }
}
