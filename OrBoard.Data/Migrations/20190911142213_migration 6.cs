using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class migration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures");

            migrationBuilder.AddColumn<int>(
                name: "NPINumber",
                table: "Nurses",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NPIStatus",
                table: "Nurses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Surgeons_LoginId",
                table: "Surgeons",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_AnesthetistId",
                table: "Procedures",
                column: "AnesthetistId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_HospitalId",
                table: "Procedures",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_NurseId",
                table: "Procedures",
                column: "NurseId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_OperatingRoomId",
                table: "Procedures",
                column: "OperatingRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_LoginId",
                table: "Patients",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_LoginId",
                table: "Nurses",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Anesthetists_LoginId",
                table: "Anesthetists",
                column: "LoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_Anesthetists_Logins_LoginId",
                table: "Anesthetists",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_Logins_LoginId",
                table: "Nurses",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Logins_LoginId",
                table: "Patients",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Anesthetists_AnesthetistId",
                table: "Procedures",
                column: "AnesthetistId",
                principalTable: "Anesthetists",
                principalColumn: "AnesthetistId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Hospitals_HospitalId",
                table: "Procedures",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Nurses_NurseId",
                table: "Procedures",
                column: "NurseId",
                principalTable: "Nurses",
                principalColumn: "NurseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_OperatingRooms_OperatingRoomId",
                table: "Procedures",
                column: "OperatingRoomId",
                principalTable: "OperatingRooms",
                principalColumn: "OperatingRoomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures",
                column: "SurgeonId",
                principalTable: "Surgeons",
                principalColumn: "SurgeonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Surgeons_Logins_LoginId",
                table: "Surgeons",
                column: "LoginId",
                principalTable: "Logins",
                principalColumn: "LoginId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Anesthetists_Logins_LoginId",
                table: "Anesthetists");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_Logins_LoginId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Logins_LoginId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Anesthetists_AnesthetistId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Hospitals_HospitalId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Nurses_NurseId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_OperatingRooms_OperatingRoomId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures");

            migrationBuilder.DropForeignKey(
                name: "FK_Surgeons_Logins_LoginId",
                table: "Surgeons");

            migrationBuilder.DropIndex(
                name: "IX_Surgeons_LoginId",
                table: "Surgeons");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_AnesthetistId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_HospitalId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_NurseId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Procedures_OperatingRoomId",
                table: "Procedures");

            migrationBuilder.DropIndex(
                name: "IX_Patients_LoginId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_LoginId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Anesthetists_LoginId",
                table: "Anesthetists");

            migrationBuilder.DropColumn(
                name: "NPINumber",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "NPIStatus",
                table: "Nurses");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedures_Surgeons_SurgeonId",
                table: "Procedures",
                column: "SurgeonId",
                principalTable: "Surgeons",
                principalColumn: "SurgeonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
