using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cedal_backend.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    AddressID = table.Column<int>(nullable: true),
                    EventTypes = table.Column<int>(nullable: false),
                    EventImage = table.Column<string>(nullable: true),
                    EventDamage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IdNumber = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: true),
                    MaritalStatus = table.Column<int>(nullable: true),
                    Disabilities = table.Column<bool>(nullable: true),
                    DisabilityDetails = table.Column<string>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    DriverLicence = table.Column<bool>(nullable: true),
                    OwnCar = table.Column<bool>(nullable: true),
                    ContactPersonUserId = table.Column<int>(nullable: true),
                    EducationDescription = table.Column<string>(nullable: true),
                    EmploymentStatus = table.Column<int>(nullable: true),
                    WorkExperience = table.Column<string>(nullable: true),
                    VolunteeringExperience = table.Column<bool>(nullable: true),
                    NameOfInstitution = table.Column<string>(nullable: true),
                    DescriptionOfTrainingExperience = table.Column<string>(nullable: true),
                    ReasonOfVolunteering = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: true),
                    TimePreferences = table.Column<int>(nullable: true),
                    OtherPreference = table.Column<string>(nullable: true),
                    OtherMeansOfHelp = table.Column<string>(nullable: true),
                    RefName = table.Column<string>(nullable: true),
                    RefNumber = table.Column<string>(nullable: true),
                    RefEmail = table.Column<string>(nullable: true),
                    RefOccupation = table.Column<string>(nullable: true),
                    IdentificationDocument = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_ContactPersonUserId",
                        column: x => x.ContactPersonUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationType = table.Column<int>(nullable: false),
                    ApplicantUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Users_ApplicantUserId",
                        column: x => x.ApplicantUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageType = table.Column<int>(nullable: false),
                    ApplicantUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Users_ApplicantUserId",
                        column: x => x.ApplicantUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SchoolSubjects = table.Column<int>(nullable: false),
                    ApplicantUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Users_ApplicantUserId",
                        column: x => x.ApplicantUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeekDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DaysOfTheWeek = table.Column<int>(nullable: false),
                    ApplicantUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeekDays_Users_ApplicantUserId",
                        column: x => x.ApplicantUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_ApplicantUserId",
                table: "Educations",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_AddressID",
                table: "Events",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ApplicantUserId",
                table: "Languages",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicantUserId",
                table: "Subjects",
                column: "ApplicantUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressID",
                table: "Users",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ContactPersonUserId",
                table: "Users",
                column: "ContactPersonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WeekDays_ApplicantUserId",
                table: "WeekDays",
                column: "ApplicantUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "WeekDays");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
