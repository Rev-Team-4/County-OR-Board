using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class HospitalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fax",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Hospitals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Hospitals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fax",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Hospitals");
        }
    }
}
