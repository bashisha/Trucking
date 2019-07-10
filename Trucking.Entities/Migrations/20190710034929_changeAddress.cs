using Microsoft.EntityFrameworkCore.Migrations;

namespace Trucking.Entities.Migrations
{
    public partial class changeAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Freights_Addresses_FromAddressId",
                table: "Freights");

            migrationBuilder.DropForeignKey(
                name: "FK_Freights_Addresses_ToAddressId",
                table: "Freights");

            migrationBuilder.DropIndex(
                name: "IX_Freights_FromAddressId",
                table: "Freights");

            migrationBuilder.DropIndex(
                name: "IX_Freights_ToAddressId",
                table: "Freights");

            migrationBuilder.DropColumn(
                name: "FromAddressId",
                table: "Freights");

            migrationBuilder.DropColumn(
                name: "ToAddressId",
                table: "Freights");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Owners",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromAddress",
                table: "Freights",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToAddress",
                table: "Freights",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "FromAddress",
                table: "Freights");

            migrationBuilder.DropColumn(
                name: "ToAddress",
                table: "Freights");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "FromAddressId",
                table: "Freights",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToAddressId",
                table: "Freights",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Freights_FromAddressId",
                table: "Freights",
                column: "FromAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Freights_ToAddressId",
                table: "Freights",
                column: "ToAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Freights_Addresses_FromAddressId",
                table: "Freights",
                column: "FromAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Freights_Addresses_ToAddressId",
                table: "Freights",
                column: "ToAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
