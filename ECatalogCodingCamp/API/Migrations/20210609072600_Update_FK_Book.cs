using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Update_FK_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Book_TB_M_Candidate_CandidateId",
                table: "TB_T_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_T_Book_TB_M_User_UserId",
                table: "TB_T_Book");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Book_CandidateId",
                table: "TB_T_Book");

            migrationBuilder.DropIndex(
                name: "IX_TB_T_Book_UserId",
                table: "TB_T_Book");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "TB_M_User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "TB_M_Candidate",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_BookId",
                table: "TB_M_User",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Candidate_BookId",
                table: "TB_M_Candidate",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_Candidate_TB_T_Book_BookId",
                table: "TB_M_Candidate",
                column: "BookId",
                principalTable: "TB_T_Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_M_User_TB_T_Book_BookId",
                table: "TB_M_User",
                column: "BookId",
                principalTable: "TB_T_Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_Candidate_TB_T_Book_BookId",
                table: "TB_M_Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_M_User_TB_T_Book_BookId",
                table: "TB_M_User");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_User_BookId",
                table: "TB_M_User");

            migrationBuilder.DropIndex(
                name: "IX_TB_M_Candidate_BookId",
                table: "TB_M_Candidate");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "TB_M_User");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "TB_M_Candidate");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Book_CandidateId",
                table: "TB_T_Book",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Book_UserId",
                table: "TB_T_Book",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Book_TB_M_Candidate_CandidateId",
                table: "TB_T_Book",
                column: "CandidateId",
                principalTable: "TB_M_Candidate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_T_Book_TB_M_User_UserId",
                table: "TB_T_Book",
                column: "UserId",
                principalTable: "TB_M_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
