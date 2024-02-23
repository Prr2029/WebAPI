using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class mg16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogDateTime",
                table: "LogSheets",
                newName: "startTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "LogSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "LogSheets");

            migrationBuilder.RenameColumn(
                name: "startTime",
                table: "LogSheets",
                newName: "LogDateTime");
        }
    }
}
