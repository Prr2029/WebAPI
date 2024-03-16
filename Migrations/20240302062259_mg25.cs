using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class mg25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courseSubjects_courses_CourseId",
                table: "courseSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_courseSubjects_subjects_SubjectId",
                table: "courseSubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_courses_CourseId",
                table: "LogSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_subjects_SubjectId",
                table: "LogSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_LogSheets_User_UserId",
                table: "LogSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LogSheets",
                table: "LogSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courseSubjects",
                table: "courseSubjects");

            migrationBuilder.RenameTable(
                name: "LogSheets",
                newName: "logsheets");

            migrationBuilder.RenameTable(
                name: "courseSubjects",
                newName: "coursesubjects");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "logsheets",
                newName: "StartTime");

            migrationBuilder.RenameIndex(
                name: "IX_LogSheets_UserId",
                table: "logsheets",
                newName: "IX_logsheets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_LogSheets_SubjectId",
                table: "logsheets",
                newName: "IX_logsheets_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_LogSheets_CourseId",
                table: "logsheets",
                newName: "IX_logsheets_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_courseSubjects_SubjectId",
                table: "coursesubjects",
                newName: "IX_coursesubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_courseSubjects_CourseId",
                table: "coursesubjects",
                newName: "IX_coursesubjects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_logsheets",
                table: "logsheets",
                column: "LogSheetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_coursesubjects",
                table: "coursesubjects",
                column: "CourseSubjectId");

            migrationBuilder.CreateTable(
                name: "labplans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    verifiedId = table.Column<int>(type: "int", nullable: false),
                    ApprovedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labplans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_labplans_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labplans_logsheets_ApprovedId",
                        column: x => x.ApprovedId,
                        principalTable: "logsheets",
                        principalColumn: "LogSheetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labplans_logsheets_verifiedId",
                        column: x => x.verifiedId,
                        principalTable: "logsheets",
                        principalColumn: "LogSheetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_labplans_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_labplans_ApprovedId",
                table: "labplans",
                column: "ApprovedId");

            migrationBuilder.CreateIndex(
                name: "IX_labplans_CourseId",
                table: "labplans",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_labplans_SubjectId",
                table: "labplans",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_labplans_verifiedId",
                table: "labplans",
                column: "verifiedId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_logsheets_courses_CourseId",
                table: "logsheets",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_logsheets_subjects_SubjectId",
                table: "logsheets",
                column: "SubjectId",
                principalTable: "subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_logsheets_User_UserId",
                table: "logsheets",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_coursesubjects_courses_CourseId",
                table: "coursesubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_coursesubjects_subjects_SubjectId",
                table: "coursesubjects");

            migrationBuilder.DropForeignKey(
                name: "FK_logsheets_courses_CourseId",
                table: "logsheets");

            migrationBuilder.DropForeignKey(
                name: "FK_logsheets_subjects_SubjectId",
                table: "logsheets");

            migrationBuilder.DropForeignKey(
                name: "FK_logsheets_User_UserId",
                table: "logsheets");

            migrationBuilder.DropTable(
                name: "labplans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_logsheets",
                table: "logsheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_coursesubjects",
                table: "coursesubjects");

            migrationBuilder.RenameTable(
                name: "logsheets",
                newName: "LogSheets");

            migrationBuilder.RenameTable(
                name: "coursesubjects",
                newName: "courseSubjects");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "LogSheets",
                newName: "startTime");

            migrationBuilder.RenameIndex(
                name: "IX_logsheets_UserId",
                table: "LogSheets",
                newName: "IX_LogSheets_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_logsheets_SubjectId",
                table: "LogSheets",
                newName: "IX_LogSheets_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_logsheets_CourseId",
                table: "LogSheets",
                newName: "IX_LogSheets_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_coursesubjects_SubjectId",
                table: "courseSubjects",
                newName: "IX_courseSubjects_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_coursesubjects_CourseId",
                table: "courseSubjects",
                newName: "IX_courseSubjects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogSheets",
                table: "LogSheets",
                column: "LogSheetId");

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
    }
}
