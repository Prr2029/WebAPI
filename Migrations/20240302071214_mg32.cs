using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class mg32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursesubjects_courses_CourseId",
                table: "coursesubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesubjects_subjects_SubjectId",
                table: "coursesubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_coursesubjects",
                table: "coursesubjects");

            migrationBuilder.RenameTable(
                name: "coursesubjects",
                newName: "courseSubjects");

            migrationBuilder.RenameIndex(
                name: "IX_coursesubjects_SubjectId",
                table: "courseSubjects",
                newName: "IX_courseSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_coursesubjects_CourseId",
                table: "courseSubjects",
                newName: "IX_courseSubjects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courseSubjects",
                table: "courseSubjects",
                column: "CourseSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_courseSubjects_courses_CourseId",
                table: "courseSubjects",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courseSubjects_subjects_SubjectId",
                table: "courseSubjects",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseSubjects_courses_CourseId",
                table: "courseSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSubjects_subjects_SubjectId",
                table: "courseSubjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseSubjects",
                table: "courseSubjects");

            migrationBuilder.RenameTable(
                name: "courseSubjects",
                newName: "coursesubjects");

            migrationBuilder.RenameIndex(
                name: "IX_courseSubjects_SubjectId",
                table: "coursesubjects",
                newName: "IX_coursesubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_courseSubjects_CourseId",
                table: "coursesubjects",
                newName: "IX_coursesubjects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_coursesubjects",
                table: "coursesubjects",
                column: "CourseSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_coursesubjects_courses_CourseId",
                table: "coursesubjects",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_coursesubjects_subjects_SubjectId",
                table: "coursesubjects",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
