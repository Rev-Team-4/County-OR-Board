using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Procedures");

            migrationBuilder.AlterColumn<string>(
                name: "EstimatedProcedureLength",
                table: "Procedures",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedProcedureLength",
                table: "Procedures",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Procedures",
                nullable: false,
                defaultValue: 0);
        }
    }
}
