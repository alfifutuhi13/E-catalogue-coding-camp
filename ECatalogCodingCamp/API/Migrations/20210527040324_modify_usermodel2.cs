using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class modify_usermodel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TB_M_User_Email",
                table: "TB_M_User");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_M_User",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_Email",
                table: "TB_M_User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TB_M_User_Email",
                table: "TB_M_User");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_M_User",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_Email",
                table: "TB_M_User",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }
    }
}
