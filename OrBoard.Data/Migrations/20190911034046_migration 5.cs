using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Procedures_SurgeonId",
                table: "Procedures",
                column: "SurgeonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures",
                column: "SurgeonId",
                principalTable: "Surgeons",
                principalColumn: "SurgeonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_SurgeonId",
                table: "Procedures");
        }
    }
}
