using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "NPIStatus",
                table: "Surgeons",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "NPIStatus",
                table: "Nurses",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Hospitals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "NPIStatus",
                table: "Anesthetists",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_LoginId",
                table: "Hospitals",
                column: "LoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Logins_LoginId",
                table: "Hospitals",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Logins_LoginId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_LoginId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Hospitals");

            migrationBuilder.AlterColumn<int>(
                name: "NPIStatus",
                table: "Surgeons",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "NPIStatus",
                table: "Nurses",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "NPIStatus",
                table: "Anesthetists",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
