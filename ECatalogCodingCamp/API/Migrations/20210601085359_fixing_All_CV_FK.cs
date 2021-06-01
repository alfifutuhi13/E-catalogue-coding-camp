using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class fixing_All_CV_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_T_OrganizationCV_OrganizationCVId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_T_SkillCV_SkillCVId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_M_Skill_SkillId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_T_WorkCV_WorkCVId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_M_Work_WorkId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Skill_TB_T_SkillCV_SkillCVId",
                table: "TB_M_Skill");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Work_TB_T_WorkCV_WorkCVId",
                table: "TB_M_Work");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Work_WorkCVId",
                table: "TB_M_Work");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Skill_SkillCVId",
                table: "TB_M_Skill");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_OrganizationCVId",
                table: "TB_M_CV");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_SkillCVId",
                table: "TB_M_CV");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_SkillId",
                table: "TB_M_CV");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_WorkCVId",
                table: "TB_M_CV");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_WorkId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "WorkCVId",
                table: "TB_M_Work");

            migrationBuilder.DropColumn(
                name: "SkillCVId",
                table: "TB_M_Skill");

            migrationBuilder.DropColumn(
                name: "OrganizationCVId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "SkillCVId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "WorkCVId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "WorkId",
                table: "TB_M_CV");

            migrationBuilder.AddColumn<int>(
                name: "CVId",
                table: "TB_T_WorkCV",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkId",
                table: "TB_T_WorkCV",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CVId",
                table: "TB_T_SkillCV",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "TB_T_SkillCV",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CVId",
                table: "TB_T_OrganizationCV",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_WorkCV_CVId",
                table: "TB_T_WorkCV",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_WorkCV_WorkId",
                table: "TB_T_WorkCV",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_SkillCV_CVId",
                table: "TB_T_SkillCV",
                column: "CVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_SkillCV_SkillId",
                table: "TB_T_SkillCV",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_OrganizationCV_CVId",
                table: "TB_T_OrganizationCV",
                column: "CVId");

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
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV",
                column: "SkillId",
                principalTable: "TB_M_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV",
                column: "CVId",
                principalTable: "TB_M_CV",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_CV_CVId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_CV_CVId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_SkillCV_TB_M_Skill_SkillId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_CV_CVId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_WorkCV_TB_M_Work_WorkId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_WorkCV_CVId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_WorkCV_WorkId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_SkillCV_CVId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_SkillCV_SkillId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_OrganizationCV_CVId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropColumn(
                name: "CVId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropColumn(
                name: "WorkId",
                table: "TB_T_WorkCV");

            migrationBuilder.DropColumn(
                name: "CVId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "TB_T_SkillCV");

            migrationBuilder.DropColumn(
                name: "CVId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.AddColumn<int>(
                name: "WorkCVId",
                table: "TB_M_Work",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillCVId",
                table: "TB_M_Skill",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationCVId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillCVId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkCVId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Work_WorkCVId",
                table: "TB_M_Work",
                column: "WorkCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Skill_SkillCVId",
                table: "TB_M_Skill",
                column: "SkillCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_OrganizationCVId",
                table: "TB_M_CV",
                column: "OrganizationCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_SkillCVId",
                table: "TB_M_CV",
                column: "SkillCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_SkillId",
                table: "TB_M_CV",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_WorkCVId",
                table: "TB_M_CV",
                column: "WorkCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_WorkId",
                table: "TB_M_CV",
                column: "WorkId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_T_OrganizationCV_OrganizationCVId",
                table: "TB_M_CV",
                column: "OrganizationCVId",
                principalTable: "TB_T_OrganizationCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_T_SkillCV_SkillCVId",
                table: "TB_M_CV",
                column: "SkillCVId",
                principalTable: "TB_T_SkillCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_M_Skill_SkillId",
                table: "TB_M_CV",
                column: "SkillId",
                principalTable: "TB_M_Skill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_T_WorkCV_WorkCVId",
                table: "TB_M_CV",
                column: "WorkCVId",
                principalTable: "TB_T_WorkCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_M_Work_WorkId",
                table: "TB_M_CV",
                column: "WorkId",
                principalTable: "TB_M_Work",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Skill_TB_T_SkillCV_SkillCVId",
                table: "TB_M_Skill",
                column: "SkillCVId",
                principalTable: "TB_T_SkillCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Work_TB_T_WorkCV_WorkCVId",
                table: "TB_M_Work",
                column: "WorkCVId",
                principalTable: "TB_T_WorkCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
