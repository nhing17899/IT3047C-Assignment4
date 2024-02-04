using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment4_ClassLib_StudentDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MajorID",
                table: "Courses",
                newName: "StudentID");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Majors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseMajor",
                columns: table => new
                {
                    CoursesCourseID = table.Column<int>(type: "int", nullable: false),
                    MajorsMajorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseMajor", x => new { x.CoursesCourseID, x.MajorsMajorID });
                    table.ForeignKey(
                        name: "FK_CourseMajor_Courses_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseMajor_Majors_MajorsMajorID",
                        column: x => x.MajorsMajorID,
                        principalTable: "Majors",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesCourseID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesCourseID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MajorStudent",
                columns: table => new
                {
                    MajorsMajorID = table.Column<int>(type: "int", nullable: false),
                    StudentsStudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorStudent", x => new { x.MajorsMajorID, x.StudentsStudentID });
                    table.ForeignKey(
                        name: "FK_MajorStudent_Majors_MajorsMajorID",
                        column: x => x.MajorsMajorID,
                        principalTable: "Majors",
                        principalColumn: "MajorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajorStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "CourseID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "CourseID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3,
                column: "CourseID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4,
                column: "CourseID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5,
                column: "CourseID",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseMajor_MajorsMajorID",
                table: "CourseMajor",
                column: "MajorsMajorID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudentID",
                table: "CourseStudent",
                column: "StudentsStudentID");

            migrationBuilder.CreateIndex(
                name: "IX_MajorStudent_StudentsStudentID",
                table: "MajorStudent",
                column: "StudentsStudentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseMajor");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "MajorStudent");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Majors");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Courses",
                newName: "MajorID");
        }
    }
}
