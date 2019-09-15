﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrBoard.Data;

namespace OrBoard.Data.Migrations
{
    [DbContext(typeof(OrBoardDbContext))]
    [Migration("20190915194514_updatedproceduretable2")]
    partial class updatedproceduretable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrBoard.Domain.Models.Anesthetist", b =>
                {
                    b.Property<int>("AnesthetistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("LicenseNumber")
                        .HasMaxLength(10);

                    b.Property<bool>("LicenseStatus");

                    b.Property<int>("LoginId");

                    b.Property<int>("NPINumber")
                        .HasMaxLength(10);

                    b.Property<bool>("NPIStatus");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Zip");

                    b.HasKey("AnesthetistId");

                    b.HasIndex("LoginId");

                    b.ToTable("Anesthetists");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("EINNumber");

                    b.Property<bool>("EINStatus");

                    b.Property<string>("FacilityOwnership")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FacilityType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("LicenseNumber");

                    b.Property<bool>("LicenseStatus");

                    b.Property<int>("LoginId");

                    b.Property<string>("ManagerEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ORManager")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("HospitalId");

                    b.HasIndex("LoginId");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Login", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("LoginId");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Nurse", b =>
                {
                    b.Property<int?>("NurseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("LicenseNumber")
                        .HasMaxLength(10);

                    b.Property<bool>("LicenseStatus");

                    b.Property<int>("LoginId");

                    b.Property<int>("NPINumber")
                        .HasMaxLength(10);

                    b.Property<bool>("NPIStatus");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Zip");

                    b.HasKey("NurseId");

                    b.HasIndex("LoginId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.OperatingRoom", b =>
                {
                    b.Property<int>("OperatingRoomId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeAvailable");

                    b.Property<int>("HospitalId");

                    b.Property<string>("OpRoomStatus")
                        .IsRequired();

                    b.HasKey("OperatingRoomId");

                    b.HasIndex("HospitalId");

                    b.ToTable("OperatingRooms");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("LoginId");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Zip");

                    b.HasKey("PatientId");

                    b.HasIndex("LoginId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Procedure", b =>
                {
                    b.Property<int>("ProcedureId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActualFinish");

                    b.Property<DateTime>("ActualStart");

                    b.Property<int>("AnesthetistId");

                    b.Property<string>("AnesthetistStatus");

                    b.Property<string>("EstimatedProcedureLength")
                        .IsRequired();

                    b.Property<int>("HospitalId");

                    b.Property<int?>("NurseId");

                    b.Property<int>("OperatingRoomId");

                    b.Property<string>("ProcedureName")
                        .IsRequired();

                    b.Property<DateTime>("ScheduledDateTime");

                    b.Property<string>("Status")
                        .IsRequired();

                    b.Property<int>("SurgeonId");

                    b.HasKey("ProcedureId");

                    b.HasIndex("AnesthetistId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("NurseId");

                    b.HasIndex("OperatingRoomId");

                    b.HasIndex("SurgeonId");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Surgeon", b =>
                {
                    b.Property<int>("SurgeonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("LicenseNumber")
                        .HasMaxLength(10);

                    b.Property<bool>("LicenseStatus");

                    b.Property<int>("LoginId");

                    b.Property<int>("NPINumber")
                        .HasMaxLength(10);

                    b.Property<bool>("NPIStatus");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Zip");

                    b.HasKey("SurgeonId");

                    b.HasIndex("LoginId");

                    b.ToTable("Surgeons");
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Anesthetist", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Hospital", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Nurse", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.OperatingRoom", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Patient", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Procedure", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Anesthetist", "Anesthetist")
                        .WithMany()
                        .HasForeignKey("AnesthetistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OrBoard.Domain.Models.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OrBoard.Domain.Models.Nurse", "Nurse")
                        .WithMany()
                        .HasForeignKey("NurseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OrBoard.Domain.Models.OperatingRoom", "OperatingRoom")
                        .WithMany()
                        .HasForeignKey("OperatingRoomId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("OrBoard.Domain.Models.Surgeon", "Surgeon")
                        .WithMany()
                        .HasForeignKey("SurgeonId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("OrBoard.Domain.Models.Surgeon", b =>
                {
                    b.HasOne("OrBoard.Domain.Models.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
