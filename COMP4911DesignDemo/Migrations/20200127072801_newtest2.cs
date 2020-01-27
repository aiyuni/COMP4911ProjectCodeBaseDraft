using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911DesignDemo.Migrations
{
    public partial class newtest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId",
                table: "WorkPackages");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TimesheetRows");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId",
                table: "WorkPackages",
                column: "ParentWorkPackageId",
                principalTable: "WorkPackages",
                principalColumn: "WorkPackageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId",
                table: "WorkPackages");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "TimesheetRows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkPackages_WorkPackages_ParentWorkPackageId",
                table: "WorkPackages",
                column: "ParentWorkPackageId",
                principalTable: "WorkPackages",
                principalColumn: "WorkPackageId");
        }
    }
}
