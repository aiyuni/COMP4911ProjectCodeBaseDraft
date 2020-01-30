﻿// <auto-generated />
using System;
using COMP4911DesignDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP4911DesignDemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP4911DesignDemo.Models.Credential", b =>
                {
                    b.Property<string>("CredentialId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CredentialId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Credentials");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("bit");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.Property<int?>("TimesheetApproverId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("TimesheetApproverId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.EmployeeProjectAssignment", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjectAssignments");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.EmployeeWorkPackageAssignment", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkPackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "WorkPackageId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("WorkPackageId", "ProjectId");

                    b.ToTable("EmployeeWorkPackageAssignments");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JobTitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Timesheet", b =>
                {
                    b.Property<int>("TimesheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("TimesheetId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Timesheet");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.TimesheetRow", b =>
                {
                    b.Property<int>("TimesheetRowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Friday")
                        .HasColumnType("int");

                    b.Property<int>("Monday")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Saturday")
                        .HasColumnType("int");

                    b.Property<int>("Sunday")
                        .HasColumnType("int");

                    b.Property<int>("Thursday")
                        .HasColumnType("int");

                    b.Property<int>("TimesheetId")
                        .HasColumnType("int");

                    b.Property<int>("Tuesday")
                        .HasColumnType("int");

                    b.Property<int>("Wednesday")
                        .HasColumnType("int");

                    b.Property<int>("WorkPackageId")
                        .HasColumnType("int");

                    b.Property<int>("WorkPackageId1")
                        .HasColumnType("int");

                    b.Property<int>("WorkPackageProjectId")
                        .HasColumnType("int");

                    b.HasKey("TimesheetRowId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TimesheetId");

                    b.HasIndex("WorkPackageId1", "WorkPackageProjectId");

                    b.ToTable("TimesheetRows");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.WorkPackage", b =>
                {
                    b.Property<int>("WorkPackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Activities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contractor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Inputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentWorkPackageId")
                        .HasColumnType("int");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResponsibleEngineerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("WorkPackageCost")
                        .HasColumnType("float");

                    b.Property<string>("WorkPackageDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkPackageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkPackageId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("ParentWorkPackageId", "ProjectId");

                    b.ToTable("WorkPackages");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Credential", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Employee", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Employee", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");

                    b.HasOne("COMP4911DesignDemo.Models.Employee", "TimesheetApprover")
                        .WithMany()
                        .HasForeignKey("TimesheetApproverId");
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.EmployeeProjectAssignment", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Employee", "Employee")
                        .WithMany("EmployeeProjectAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.Project", "Project")
                        .WithMany("EmployeeProjectAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.EmployeeWorkPackageAssignment", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Employee", "Employee")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.Project", "Project")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.WorkPackage", "WorkPackage")
                        .WithMany("EmployeeWorkPackageAssignments")
                        .HasForeignKey("WorkPackageId", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.Timesheet", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Employee", "Employee")
                        .WithOne("Timesheet")
                        .HasForeignKey("COMP4911DesignDemo.Models.Timesheet", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.TimesheetRow", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.Timesheet", "Timesheet")
                        .WithMany("TimesheetRows")
                        .HasForeignKey("TimesheetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.WorkPackage", "WorkPackage")
                        .WithMany("TimesheetRows")
                        .HasForeignKey("WorkPackageId1", "WorkPackageProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("COMP4911DesignDemo.Models.WorkPackage", b =>
                {
                    b.HasOne("COMP4911DesignDemo.Models.Project", "Project")
                        .WithMany("WorkPackages")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMP4911DesignDemo.Models.WorkPackage", "ParentWorkPackage")
                        .WithMany("ChildrenWorkPackages")
                        .HasForeignKey("ParentWorkPackageId", "ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
