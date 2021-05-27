using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class modify_usermodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TB_M_User");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "TB_M_User",
                maxLength: 255,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "StatusBook",
                table: "TB_M_User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TB_M_User");

            migrationBuilder.DropColumn(
                name: "StatusBook",
                table: "TB_M_User");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "TB_M_User",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
