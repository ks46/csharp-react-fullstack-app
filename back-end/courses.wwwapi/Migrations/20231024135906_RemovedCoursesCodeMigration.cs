using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courses.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class RemovedCoursesCodeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Courses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "Courses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
