﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Account");
                });

            modelBuilder.Entity("API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("TB_T_Book");
                });

            modelBuilder.Entity("API.Models.CV", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_CV");
                });

            modelBuilder.Entity("API.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusBook")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Candidate");
                });

            modelBuilder.Entity("API.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GPA")
                        .HasColumnType("real");

                    b.Property<int?>("MajorId")
                        .HasColumnType("int");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MajorId");

                    b.HasIndex("UniversityId");

                    b.ToTable("TB_T_Education");
                });

            modelBuilder.Entity("API.Models.InterviewRequest", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<long>("BidSalary")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Schedule")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TB_M_InterviewRequest");
                });

            modelBuilder.Entity("API.Models.JobRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_JobRole");
                });

            modelBuilder.Entity("API.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Major");
                });

            modelBuilder.Entity("API.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleOrganization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Organization");
                });

            modelBuilder.Entity("API.Models.OrganizationCV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("TB_T_OrganizationCV");
                });

            modelBuilder.Entity("API.Models.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Parameter");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Role");
                });

            modelBuilder.Entity("API.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Skill");
                });

            modelBuilder.Entity("API.Models.SkillCV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.HasIndex("SkillId");

                    b.ToTable("TB_T_SkillCV");
                });

            modelBuilder.Entity("API.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_University");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("StatusBook")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("JobRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("TB_M_User");
                });

            modelBuilder.Entity("API.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_M_Work");
                });

            modelBuilder.Entity("API.Models.WorkCV", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CVId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.HasIndex("WorkId");

                    b.ToTable("TB_T_WorkCV");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("API.Models.Account", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Book", b =>
                {
                    b.HasOne("API.Models.Candidate", "Candidate")
                        .WithOne("Book")
                        .HasForeignKey("API.Models.Book", "CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.User", "User")
                        .WithOne("Book")
                        .HasForeignKey("API.Models.Book", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.CV", b =>
                {
                    b.HasOne("API.Models.User", "User")
                        .WithOne("CV")
                        .HasForeignKey("API.Models.CV", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.Education", b =>
                {
                    b.HasOne("API.Models.User", "User")
                        .WithOne("Education")
                        .HasForeignKey("API.Models.Education", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Major", "Major")
                        .WithMany("Educations")
                        .HasForeignKey("MajorId");

                    b.HasOne("API.Models.University", "University")
                        .WithMany("Educations")
                        .HasForeignKey("UniversityId");
                });

            modelBuilder.Entity("API.Models.InterviewRequest", b =>
                {
                    b.HasOne("API.Models.Book", "Book")
                        .WithOne("InterviewRequest")
                        .HasForeignKey("API.Models.InterviewRequest", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Models.OrganizationCV", b =>
                {
                    b.HasOne("API.Models.CV", "CV")
                        .WithMany("OrganizationCVs")
                        .HasForeignKey("CVId");

                    b.HasOne("API.Models.Organization", "Organization")
                        .WithMany("OrganizationCVs")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("API.Models.SkillCV", b =>
                {
                    b.HasOne("API.Models.CV", "CV")
                        .WithMany("SkillCVs")
                        .HasForeignKey("CVId");

                    b.HasOne("API.Models.Skill", "Skill")
                        .WithMany("SkillCVs")
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.HasOne("API.Models.JobRole", "JobRole")
                        .WithMany("Users")
                        .HasForeignKey("JobRoleId");

                    b.HasOne("API.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("API.Models.WorkCV", b =>
                {
                    b.HasOne("API.Models.CV", "CV")
                        .WithMany("WorkCVs")
                        .HasForeignKey("CVId");

                    b.HasOne("API.Models.Work", "Work")
                        .WithMany("WorkCVs")
                        .HasForeignKey("WorkId");
                });
#pragma warning restore 612, 618
        }
    }
}
