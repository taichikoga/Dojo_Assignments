using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedding_Planner.Migrations
{
    public partial class AttendClassMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attends",
                columns: table => new
                {
                    AttendId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    WeddingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attends", x => x.AttendId);
                    table.ForeignKey(
                        name: "FK_Attends_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attends_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "WeddingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attends_UserId",
                table: "Attends",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attends_WeddingId",
                table: "Attends",
                column: "WeddingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attends");
        }
    }
}
