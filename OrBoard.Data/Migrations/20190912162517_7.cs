using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NurseId",
                table: "Procedures",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NurseId",
                table: "Procedures",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
