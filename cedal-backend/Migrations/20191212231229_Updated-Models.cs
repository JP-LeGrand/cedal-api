using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cedal_backend.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_ApplicantUserId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Users_ApplicantUserId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Users_ApplicantUserId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ContactPersonUserId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Users_ApplicantUserId",
                table: "WeekDays");

            migrationBuilder.DropIndex(
                name: "IX_WeekDays_ApplicantUserId",
                table: "WeekDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ContactPersonUserId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ApplicantUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Languages_ApplicantUserId",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ApplicantUserId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ApplicantUserId",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "ContactPersonUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApplicantUserId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ApplicantUserId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ApplicantUserId",
                table: "Educations");

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "WeekDays",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContactPersonId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "Languages",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Events",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicantId",
                table: "Educations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_ApplicantId",
                table: "WeekDays",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContactPersonId",
                table: "Users",
                column: "ContactPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicantId",
                table: "Subjects",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ApplicantId",
                table: "Languages",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations",
                column: "ApplicantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_ApplicantId",
                table: "Educations",
                column: "ApplicantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Users_ApplicantId",
                table: "Languages",
                column: "ApplicantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Users_ApplicantId",
                table: "Subjects",
                column: "ApplicantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ContactPersonId",
                table: "Users",
                column: "ContactPersonId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Users_ApplicantId",
                table: "WeekDays",
                column: "ApplicantId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Users_ApplicantId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Users_ApplicantId",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Users_ApplicantId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ContactPersonId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WeekDays_Users_ApplicantId",
                table: "WeekDays");

            migrationBuilder.DropIndex(
                name: "IX_WeekDays_ApplicantId",
                table: "WeekDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ContactPersonId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_ApplicantId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Languages_ApplicantId",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Educations_ApplicantId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "WeekDays");

            migrationBuilder.DropColumn(
                name: "ContactPersonId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ApplicantId",
                table: "Educations");

            migrationBuilder.AddColumn<int>(
                name: "ApplicantUserId",
                table: "WeekDays",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Users",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "ContactPersonUserId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Users",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ApplicantUserId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApplicantUserId",
                table: "Languages",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Events",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Events",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ApplicantUserId",
                table: "Educations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_ApplicantUserId",
                table: "WeekDays",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContactPersonUserId",
                table: "Users",
                column: "ContactPersonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicantUserId",
                table: "Subjects",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ApplicantUserId",
                table: "Languages",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantUserId",
                table: "Educations",
                column: "ApplicantUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Users_ApplicantUserId",
                table: "Educations",
                column: "ApplicantUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Users_ApplicantUserId",
                table: "Languages",
                column: "ApplicantUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Users_ApplicantUserId",
                table: "Subjects",
                column: "ApplicantUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ContactPersonUserId",
                table: "Users",
                column: "ContactPersonUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeekDays_Users_ApplicantUserId",
                table: "WeekDays",
                column: "ApplicantUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
