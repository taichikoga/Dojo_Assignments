using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharp_Exam.Migrations
{
    public partial class ParticipateContextMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participate_Exercises_ExerciseId",
                table: "Participate");

            migrationBuilder.DropForeignKey(
                name: "FK_Participate_Users_UserId",
                table: "Participate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Participate",
                table: "Participate");

            migrationBuilder.RenameTable(
                name: "Participate",
                newName: "Participates");

            migrationBuilder.RenameIndex(
                name: "IX_Participate_UserId",
                table: "Participates",
                newName: "IX_Participates_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Participate_ExerciseId",
                table: "Participates",
                newName: "IX_Participates_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Participates",
                table: "Participates",
                column: "ParticipateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participates_Exercises_ExerciseId",
                table: "Participates",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participates_Users_UserId",
                table: "Participates",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participates_Exercises_ExerciseId",
                table: "Participates");

            migrationBuilder.DropForeignKey(
                name: "FK_Participates_Users_UserId",
                table: "Participates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Participates",
                table: "Participates");

            migrationBuilder.RenameTable(
                name: "Participates",
                newName: "Participate");

            migrationBuilder.RenameIndex(
                name: "IX_Participates_UserId",
                table: "Participate",
                newName: "IX_Participate_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Participates_ExerciseId",
                table: "Participate",
                newName: "IX_Participate_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Participate",
                table: "Participate",
                column: "ParticipateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Participate_Exercises_ExerciseId",
                table: "Participate",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "ExerciseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participate_Users_UserId",
                table: "Participate",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
