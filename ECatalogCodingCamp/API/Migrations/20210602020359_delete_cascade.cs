using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class delete_cascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_CV_CVId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_CV_CVId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_CV_CVId",
                table: "TB_T_OrganizationCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_CV_CVId",
                table: "TB_T_SkillCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_CV_CVId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_CV_CVId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_CV_CVId",
                table: "TB_T_OrganizationCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_CV_CVId",
                table: "TB_T_SkillCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV",
                column: "CVId",
                principalTable: "TB_M_CV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
