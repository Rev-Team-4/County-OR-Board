using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OperatingnRoomStatus",
                table: "OperatingRooms",
                newName: "OperatingRoomStatus");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeAvailable",
                table: "OperatingRooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeAvailable",
                table: "OperatingRooms");

            migrationBuilder.RenameColumn(
                name: "OperatingRoomStatus",
                table: "OperatingRooms",
                newName: "OperatingnRoomStatus");
        }
    }
}
