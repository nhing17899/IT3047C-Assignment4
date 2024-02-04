using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment4_ClassLib_StudentDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "ClassOf", "FirstName", "LastName", "MajorID", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 2025, "Nhi", "Nguyen", 0, "5132887145" },
                    { 2, 2026, "Elena", "Dutch", 0, "5133099222" },
                    { 3, 2028, "Queen", "Thomas", 0, "6048891983" },
                    { 4, 2018, "Jack", "Thomas", 0, "5132896788" },
                    { 5, 2020, "Mina", "Le", 0, "5458398299" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5);
        }
    }
}
