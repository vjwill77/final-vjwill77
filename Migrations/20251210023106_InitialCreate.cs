using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace final_vjwill77.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    ShirtSize = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantID);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipantID = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipantCourseCourseID = table.Column<int>(type: "INTEGER", nullable: true),
                    ParticipantCourseParticipantID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantCourses", x => new { x.CourseID, x.ParticipantID });
                    table.ForeignKey(
                        name: "FK_ParticipantCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParticipantCourses_ParticipantCourses_ParticipantCourseCourseID_ParticipantCourseParticipantID",
                        columns: x => new { x.ParticipantCourseCourseID, x.ParticipantCourseParticipantID },
                        principalTable: "ParticipantCourses",
                        principalColumns: new[] { "CourseID", "ParticipantID" });
                    table.ForeignKey(
                        name: "FK_ParticipantCourses_Participants_ParticipantID",
                        column: x => x.ParticipantID,
                        principalTable: "Participants",
                        principalColumn: "ParticipantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantCourses_ParticipantCourseCourseID_ParticipantCourseParticipantID",
                table: "ParticipantCourses",
                columns: new[] { "ParticipantCourseCourseID", "ParticipantCourseParticipantID" });

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantCourses_ParticipantID",
                table: "ParticipantCourses",
                column: "ParticipantID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipantCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Participants");
        }
    }
}
