using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courses.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class DeclarationPeriodMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "period",
                table: "Declarations",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "period",
                table: "Declarations");
        }
    }
}
