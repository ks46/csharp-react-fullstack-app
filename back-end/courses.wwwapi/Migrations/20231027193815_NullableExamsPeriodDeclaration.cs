using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace courses.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class NullableExamsPeriodDeclaration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "examsPeriod",
                table: "Declarations",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSpecializations_courseId",
                table: "CoursesSpecializations",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesDeclarations_declarationId",
                table: "CoursesDeclarations",
                column: "declarationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesDeclarations_Declarations_declarationId",
                table: "CoursesDeclarations",
                column: "declarationId",
                principalTable: "Declarations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoursesSpecializations_Courses_courseId",
                table: "CoursesSpecializations",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoursesDeclarations_Declarations_declarationId",
                table: "CoursesDeclarations");

            migrationBuilder.DropForeignKey(
                name: "FK_CoursesSpecializations_Courses_courseId",
                table: "CoursesSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_CoursesSpecializations_courseId",
                table: "CoursesSpecializations");

            migrationBuilder.DropIndex(
                name: "IX_CoursesDeclarations_declarationId",
                table: "CoursesDeclarations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "examsPeriod",
                table: "Declarations",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);
        }
    }
}
