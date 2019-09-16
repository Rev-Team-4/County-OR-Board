using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class updatingtables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperatingRooms_Hospitals_HospitalId",
                table: "OperatingRooms");

            migrationBuilder.DropIndex(
                name: "IX_OperatingRooms_HospitalId",
                table: "OperatingRooms");

            migrationBuilder.AddColumn<string>(
                name: "OrName",
                table: "OperatingRooms",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrName",
                table: "OperatingRooms");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingRooms_HospitalId",
                table: "OperatingRooms",
                column: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperatingRooms_Hospitals_HospitalId",
                table: "OperatingRooms",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
