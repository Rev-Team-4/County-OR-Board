using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrBoard.Data.Migrations
{
    public partial class testUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreationDateTime = table.Column<DateTime>(nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "OperatingRooms",
                columns: table => new
                {
                    OperatingRoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HospitalId = table.Column<int>(nullable: false),
                    OrName = table.Column<string>(nullable: false),
                    DateTimeAvailable = table.Column<DateTime>(nullable: false),
                    OpRoomStatus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingRooms", x => x.OperatingRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Anesthetists",
                columns: table => new
                {
                    AnesthetistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    LicenseNumber = table.Column<int>(nullable: false),
                    LicenseStatus = table.Column<bool>(nullable: false),
                    NPINumber = table.Column<int>(nullable: false),
                    NPIStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anesthetists", x => x.AnesthetistId);
                    table.ForeignKey(
                        name: "FK_Anesthetists_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    FacilityOwnership = table.Column<string>(maxLength: 50, nullable: false),
                    ORManager = table.Column<string>(maxLength: 50, nullable: false),
                    ManagerEmail = table.Column<string>(maxLength: 50, nullable: false),
                    LicenseNumber = table.Column<int>(nullable: false),
                    LicenseStatus = table.Column<bool>(nullable: false),
                    EINNumber = table.Column<int>(nullable: false),
                    EINStatus = table.Column<bool>(nullable: false),
                    FacilityType = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Telephone = table.Column<string>(nullable: false),
                    Fax = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                    table.ForeignKey(
                        name: "FK_Hospitals_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    NurseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    LicenseNumber = table.Column<int>(nullable: false),
                    LicenseStatus = table.Column<bool>(nullable: false),
                    NPINumber = table.Column<int>(nullable: false),
                    NPIStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.NurseId);
                    table.ForeignKey(
                        name: "FK_Nurses_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patients_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Surgeons",
                columns: table => new
                {
                    SurgeonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoginId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    StreetAddress = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 50, nullable: false),
                    Zip = table.Column<int>(nullable: false),
                    LicenseNumber = table.Column<int>(nullable: false),
                    LicenseStatus = table.Column<bool>(nullable: false),
                    NPINumber = table.Column<int>(nullable: false),
                    NPIStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgeons", x => x.SurgeonId);
                    table.ForeignKey(
                        name: "FK_Surgeons_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurgeonId = table.Column<int>(nullable: false),
                    AnesthetistId = table.Column<int>(nullable: false),
                    OperatingRoomId = table.Column<int>(nullable: false),
                    HospitalId = table.Column<int>(nullable: false),
                    NurseId = table.Column<int>(nullable: true),
                    ScheduledDateTime = table.Column<DateTime>(nullable: false),
                    ProcedureName = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    EstimatedProcedureLength = table.Column<string>(nullable: false),
                    ActualStart = table.Column<DateTime>(nullable: false),
                    ActualFinish = table.Column<DateTime>(nullable: false),
                    AnesthetistStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureId);
                    table.ForeignKey(
                        name: "FK_Procedures_Anesthetists_AnesthetistId",
                        column: x => x.AnesthetistId,
                        principalTable: "Anesthetists",
                        principalColumn: "AnesthetistId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_Nurses_NurseId",
                        column: x => x.NurseId,
                        principalTable: "Nurses",
                        principalColumn: "NurseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_OperatingRooms_OperatingRoomId",
                        column: x => x.OperatingRoomId,
                        principalTable: "OperatingRooms",
                        principalColumn: "OperatingRoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_Surgeons_SurgeonId",
                        column: x => x.SurgeonId,
                        principalTable: "Surgeons",
                        principalColumn: "SurgeonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anesthetists_LoginId",
                table: "Anesthetists",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_LoginId",
                table: "Hospitals",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_LoginId",
                table: "Nurses",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_LoginId",
                table: "Patients",
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
                name: "IX_Procedures_SurgeonId",
                table: "Procedures",
                column: "SurgeonId");

            migrationBuilder.CreateIndex(
                name: "IX_Surgeons_LoginId",
                table: "Surgeons",
                column: "LoginId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "Anesthetists");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "OperatingRooms");

            migrationBuilder.DropTable(
                name: "Surgeons");

            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
