using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class oncascadeDeleteAllCV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_Work_WorkId",
                table: "TB_T_WorkCV");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV",
                column: "OrganizationId",
                principalTable: "TB_M_Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV",
                column: "SkillId",
                principalTable: "TB_M_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_Work_WorkId",
                table: "TB_T_WorkCV",
                column: "WorkId",
                principalTable: "TB_M_Work",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_Work_WorkId",
                table: "TB_T_WorkCV");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV",
                column: "OrganizationId",
                principalTable: "TB_M_Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV",
                column: "SkillId",
                principalTable: "TB_M_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_Work_WorkId",
                table: "TB_T_WorkCV",
                column: "WorkId",
                principalTable: "TB_M_Work",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
