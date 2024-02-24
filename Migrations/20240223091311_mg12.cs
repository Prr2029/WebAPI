using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class mg12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "LogSheets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LogSheets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LogSheets_CourseId",
                table: "LogSheets",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_LogSheets_SubjectId",
                table: "LogSheets",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LogSheets_UserId",
                table: "LogSheets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LogSheets_courses_CourseId",
                table: "LogSheets",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogSheets_subjects_SubjectId",
                table: "LogSheets",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LogSheets_User_UserId",
                table: "LogSheets",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_courses_CourseId",
                table: "LogSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_subjects_SubjectId",
                table: "LogSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_User_UserId",
                table: "LogSheets");

            migrationBuilder.DropIndex(
                name: "IX_LogSheets_CourseId",
                table: "LogSheets");

            migrationBuilder.DropIndex(
                name: "IX_LogSheets_SubjectId",
                table: "LogSheets");

            migrationBuilder.DropIndex(
                name: "IX_LogSheets_UserId",
                table: "LogSheets");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "LogSheets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LogSheets");

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });
        }
    }
}
