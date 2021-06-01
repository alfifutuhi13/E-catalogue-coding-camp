using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class test_FK_OrgCV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_CV_TB_M_Organization_OrganizationId",
                table: "TB_M_CV");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Organization_TB_T_OrganizationCV_OrganizationCVId",
                table: "TB_M_Organization");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Organization_OrganizationCVId",
                table: "TB_M_Organization");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_CV_OrganizationId",
                table: "TB_M_CV");

            migrationBuilder.DropColumn(
                name: "OrganizationCVId",
                table: "TB_M_Organization");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "TB_M_CV");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "TB_T_OrganizationCV",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_OrganizationCV_OrganizationId",
                table: "TB_T_OrganizationCV",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV",
                column: "OrganizationId",
                principalTable: "TB_M_Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_OrganizationCV_TB_M_Organization_OrganizationId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_OrganizationCV_OrganizationId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "TB_T_OrganizationCV");

            migrationBuilder.AddColumn<int>(
                name: "OrganizationCVId",
                table: "TB_M_Organization",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "TB_M_CV",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Organization_OrganizationCVId",
                table: "TB_M_Organization",
                column: "OrganizationCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_OrganizationId",
                table: "TB_M_CV",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_CV_TB_M_Organization_OrganizationId",
                table: "TB_M_CV",
                column: "OrganizationId",
                principalTable: "TB_M_Organization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Organization_TB_T_OrganizationCV_OrganizationCVId",
                table: "TB_M_Organization",
                column: "OrganizationCVId",
                principalTable: "TB_T_OrganizationCV",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
