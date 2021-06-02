using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext()
        {}

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Candidate> Clients { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<InterviewRequest> InterviewRequests { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Email should be unique
            modelBuilder.Entity<User>()
                .HasIndex(user => user.Email)
                .IsUnique();

            //University-Education
            modelBuilder.Entity<Education>()
                .HasOne(education => education.University)
                .WithMany(university => university.Educations);

            //Major-Education
            modelBuilder.Entity<Education>()
                .HasOne(education => education.Major)
                .WithMany(major => major.Educations);

            //User-Education
            modelBuilder.Entity<User>()
                .HasOne(user => user.Education)
                .WithOne(education => education.User)
                .HasForeignKey<Education>(education => education.Id);

            //SkillCV-CV
            modelBuilder.Entity<SkillCV>()
                .HasOne(skillcv => skillcv.CV)
                .WithMany(cv => cv.SkillCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //SkillCV-Skill
            modelBuilder.Entity<SkillCV>()
                .HasOne(skillcv => skillcv.Skill)
                .WithMany(skill => skill.SkillCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //OrganizationCV-CV
            modelBuilder.Entity<OrganizationCV>()
                .HasOne(organizationcv => organizationcv.CV)
                .WithMany(cv => cv.OrganizationCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //OrganizationCV-Organization
            modelBuilder.Entity<OrganizationCV>()
                .HasOne(organizationcv => organizationcv.Organization)
                .WithMany(organization => organization.OrganizationCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //WorkCV-CV
            modelBuilder.Entity<WorkCV>()
                .HasOne(workcv => workcv.CV)
                .WithMany(cv => cv.WorkCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //WorkCV-Work
            modelBuilder.Entity<WorkCV>()
                .HasOne(workcv => workcv.Work)
                .WithMany(work => work.WorkCVs)
                .OnDelete(DeleteBehavior.Cascade);

            //User-CV
            modelBuilder.Entity<User>()
                .HasOne(user => user.CV)
                .WithOne(cv => cv.User)
                .HasForeignKey<CV>(cv => cv.Id);

            //Role-User
            modelBuilder.Entity<User>()
                .HasOne(user => user.Role)
                .WithMany(role => role.Users);

            //User-Account
            modelBuilder.Entity<Account>()
                .HasOne(account => account.User)
                .WithOne(user => user.Account)
                .HasForeignKey<Account>(Account => Account.Id);

            //JobRole-User
            modelBuilder.Entity<User>()
               .HasOne(user => user.Role)
               .WithMany(jobrole => jobrole.Users);

            //Book-Candidate
            modelBuilder.Entity<Candidate>()
                .HasOne(candidate => candidate.Book)
                .WithOne(book => book.Candidate)
                .HasForeignKey<Book>(book => book.CandidateId);

            //User-Book
            modelBuilder.Entity<User>()
               .HasOne(user => user.Book)
               .WithOne(book => book.User)
               .HasForeignKey<Book>(book => book.UserId);

            //Book-InterviewRequest
            modelBuilder.Entity<Book>()
                .HasOne(book => book.InterviewRequest)
                .WithOne(interviewrequest => interviewrequest.Book)
                .HasForeignKey<InterviewRequest>(interviewrequest => interviewrequest.Id);
        }

    }
}
