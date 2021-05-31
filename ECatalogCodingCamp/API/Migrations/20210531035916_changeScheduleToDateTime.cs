using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class changeScheduleToDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "TB_M_InterviewRequest");

            migrationBuilder.AddColumn<DateTime>(
                name: "Schedule",
                table: "TB_M_InterviewRequest",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "TB_M_InterviewRequest");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TB_M_InterviewRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
