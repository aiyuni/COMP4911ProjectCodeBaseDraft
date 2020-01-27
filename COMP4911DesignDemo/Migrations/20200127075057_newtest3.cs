using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP4911DesignDemo.Migrations
{
    public partial class newtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId",
                table: "TimesheetRows");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_WorkPackages_WorkPackageId",
                table: "TimesheetRows");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId",
                table: "TimesheetRows",
                column: "TimesheetId",
                principalTable: "Timesheet",
                principalColumn: "TimesheetId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_WorkPackages_WorkPackageId",
                table: "TimesheetRows",
                column: "WorkPackageId",
                principalTable: "WorkPackages",
                principalColumn: "WorkPackageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId",
                table: "TimesheetRows");

            migrationBuilder.DropForeignKey(
                name: "FK_TimesheetRows_WorkPackages_WorkPackageId",
                table: "TimesheetRows");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_Timesheet_TimesheetId",
                table: "TimesheetRows",
                column: "TimesheetId",
                principalTable: "Timesheet",
                principalColumn: "TimesheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimesheetRows_WorkPackages_WorkPackageId",
                table: "TimesheetRows",
                column: "WorkPackageId",
                principalTable: "WorkPackages",
                principalColumn: "WorkPackageId");
        }
    }
}
