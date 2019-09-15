using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class updateorroomtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OpRoomStatus",
                table: "OperatingRooms",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperatingRooms_Hospitals_HospitalId",
                table: "OperatingRooms");

            migrationBuilder.DropIndex(
                name: "IX_OperatingRooms_HospitalId",
                table: "OperatingRooms");

            migrationBuilder.AlterColumn<string>(
                name: "OpRoomStatus",
                table: "OperatingRooms",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
