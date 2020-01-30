using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911DesignDemo.Migrations
{
    public partial class perrytest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contractor",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "WorkPackages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Inputs",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Outputs",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Purpose",
                table: "WorkPackages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResponsibleEngineerId",
                table: "WorkPackages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "WorkPackages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activities",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "Contractor",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "Inputs",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "Outputs",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "Purpose",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "ResponsibleEngineerId",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "WorkPackages");
        }
    }
}
