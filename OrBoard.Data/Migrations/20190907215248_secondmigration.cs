using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicenseNumber",
                table: "Surgeons",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LicenseStatus",
                table: "Surgeons",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NPINumber",
                table: "Surgeons",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPIStatus",
                table: "Surgeons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LicenseNumber",
                table: "Anesthetists",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LicenseStatus",
                table: "Anesthetists",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NPINumber",
                table: "Anesthetists",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPIStatus",
                table: "Anesthetists",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "Surgeons");

            migrationBuilder.DropColumn(
                name: "LicenseStatus",
                table: "Surgeons");

            migrationBuilder.DropColumn(
                name: "NPINumber",
                table: "Surgeons");

            migrationBuilder.DropColumn(
                name: "NPIStatus",
                table: "Surgeons");

            migrationBuilder.DropColumn(
                name: "LicenseNumber",
                table: "Anesthetists");

            migrationBuilder.DropColumn(
                name: "LicenseStatus",
                table: "Anesthetists");

            migrationBuilder.DropColumn(
                name: "NPINumber",
                table: "Anesthetists");

            migrationBuilder.DropColumn(
                name: "NPIStatus",
                table: "Anesthetists");
        }
    }
}
