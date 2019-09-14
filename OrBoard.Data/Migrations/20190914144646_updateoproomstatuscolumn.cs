using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class updateoproomstatuscolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OperatingRoomStatus",
                table: "OperatingRooms",
                newName: "OpRoomStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OpRoomStatus",
                table: "OperatingRooms",
                newName: "OperatingRoomStatus");
        }
    }
}
