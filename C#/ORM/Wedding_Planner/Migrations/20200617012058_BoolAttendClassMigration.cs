using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedding_Planner.Migrations
{
    public partial class BoolAttendClassMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRSVPed",
                table: "Attends",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRSVPed",
                table: "Attends");
        }
    }
}
