using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class NoUserCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_M_Candidate",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    StatusBook = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    JobRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Candidate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_JobRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_JobRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Major",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Major", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Parameter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Parameter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_University",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_University", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_OrganizationCV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_OrganizationCV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_SkillCV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_SkillCV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_WorkCV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_WorkCV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    StatusBook = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    JobRoleId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_User_TB_M_JobRole_JobRoleId",
                        column: x => x.JobRoleId,
                        principalTable: "TB_M_JobRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_User_TB_M_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "TB_M_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Organization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RoleOrganization = table.Column<string>(nullable: true),
                    OrganizationCVId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Organization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Organization_TB_T_OrganizationCV_OrganizationCVId",
                        column: x => x.OrganizationCVId,
                        principalTable: "TB_T_OrganizationCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SkillCVId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Skill_TB_T_SkillCV_SkillCVId",
                        column: x => x.SkillCVId,
                        principalTable: "TB_T_SkillCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Work",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WorkCVId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Work", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Work_TB_T_WorkCV_WorkCVId",
                        column: x => x.WorkCVId,
                        principalTable: "TB_T_WorkCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_Account_TB_M_User_Id",
                        column: x => x.Id,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Book_TB_M_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "TB_M_Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_T_Book_TB_M_User_UserId",
                        column: x => x.UserId,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_T_Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Degree = table.Column<string>(nullable: true),
                    GPA = table.Column<float>(nullable: false),
                    MajorId = table.Column<int>(nullable: true),
                    UniversityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_T_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_T_Education_TB_M_User_Id",
                        column: x => x.Id,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_T_Education_TB_M_Major_MajorId",
                        column: x => x.MajorId,
                        principalTable: "TB_M_Major",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_T_Education_TB_M_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "TB_M_University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_CV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OrganizationCVId = table.Column<int>(nullable: true),
                    SkillCVId = table.Column<int>(nullable: true),
                    WorkCVId = table.Column<int>(nullable: true),
                    OrganizationId = table.Column<int>(nullable: true),
                    SkillId = table.Column<int>(nullable: true),
                    WorkId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_CV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_M_User_Id",
                        column: x => x.Id,
                        principalTable: "TB_M_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_T_OrganizationCV_OrganizationCVId",
                        column: x => x.OrganizationCVId,
                        principalTable: "TB_T_OrganizationCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_M_Organization_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "TB_M_Organization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_T_SkillCV_SkillCVId",
                        column: x => x.SkillCVId,
                        principalTable: "TB_T_SkillCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_M_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "TB_M_Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_T_WorkCV_WorkCVId",
                        column: x => x.WorkCVId,
                        principalTable: "TB_T_WorkCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_M_CV_TB_M_Work_WorkId",
                        column: x => x.WorkId,
                        principalTable: "TB_M_Work",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_M_InterviewRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BidSalary = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_M_InterviewRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_M_InterviewRequest_TB_T_Book_Id",
                        column: x => x.Id,
                        principalTable: "TB_T_Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_OrganizationCVId",
                table: "TB_M_CV",
                column: "OrganizationCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_CV_OrganizationId",
                table: "TB_M_CV",
                column: "OrganizationId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Organization_OrganizationCVId",
                table: "TB_M_Organization",
                column: "OrganizationCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Skill_SkillCVId",
                table: "TB_M_Skill",
                column: "SkillCVId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_Email",
                table: "TB_M_User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_JobRoleId",
                table: "TB_M_User",
                column: "JobRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_User_RoleId",
                table: "TB_M_User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_M_Work_WorkCVId",
                table: "TB_M_Work",
                column: "WorkCVId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Education_MajorId",
                table: "TB_T_Education",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_T_Education_UniversityId",
                table: "TB_T_Education",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_M_Account");

            migrationBuilder.DropTable(
                name: "TB_M_CV");

            migrationBuilder.DropTable(
                name: "TB_M_InterviewRequest");

            migrationBuilder.DropTable(
                name: "TB_M_Parameter");

            migrationBuilder.DropTable(
                name: "TB_T_Education");

            migrationBuilder.DropTable(
                name: "TB_M_Organization");

            migrationBuilder.DropTable(
                name: "TB_M_Skill");

            migrationBuilder.DropTable(
                name: "TB_M_Work");

            migrationBuilder.DropTable(
                name: "TB_T_Book");

            migrationBuilder.DropTable(
                name: "TB_M_Major");

            migrationBuilder.DropTable(
                name: "TB_M_University");

            migrationBuilder.DropTable(
                name: "TB_T_OrganizationCV");

            migrationBuilder.DropTable(
                name: "TB_T_SkillCV");

            migrationBuilder.DropTable(
                name: "TB_T_WorkCV");

            migrationBuilder.DropTable(
                name: "TB_M_Candidate");

            migrationBuilder.DropTable(
                name: "TB_M_User");

            migrationBuilder.DropTable(
                name: "TB_M_JobRole");

            migrationBuilder.DropTable(
                name: "TB_M_Role");
        }
    }
}
