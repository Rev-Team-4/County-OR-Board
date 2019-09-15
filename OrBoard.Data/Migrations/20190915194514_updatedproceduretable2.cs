using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class updatedproceduretable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnesthetistStatus",
                table: "Procedures",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AnesthetistStatus",
                table: "Procedures",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
