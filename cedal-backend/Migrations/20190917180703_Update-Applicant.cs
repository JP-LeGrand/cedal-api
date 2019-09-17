using Microsoft.EntityFrameworkCore.Migrations;

namespace cedal_backend.Migrations
{
    public partial class UpdateApplicant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Educations_EducationID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EducationID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EducationID",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "ApplicantID",
                table: "Educations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantID",
                table: "Educations",
                column: "ApplicantID");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_ApplicantID",
                table: "Educations",
                column: "ApplicantID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_ApplicantID",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ApplicantID",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ApplicantID",
                table: "Educations");

            migrationBuilder.AddColumn<int>(
                name: "EducationID",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EducationID",
                table: "Users",
                column: "EducationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Educations_EducationID",
                table: "Users",
                column: "EducationID",
                principalTable: "Educations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
