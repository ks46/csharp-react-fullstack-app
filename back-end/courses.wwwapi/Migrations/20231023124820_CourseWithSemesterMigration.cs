using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courses.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class CourseWithSemesterMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "semester",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "semester",
                table: "Courses");
        }
    }
}
