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
            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.SkillCV)
                .WithMany(skill => skill.CVs);

            //SkillCV-Skill
            modelBuilder.Entity<Skill>()
                .HasOne(skill => skill.SkillCV)
                .WithMany(skillcv => skillcv.Skills);

            //OrganizationCV-CV
            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.OrganizationCV)
                .WithMany(organizationcv => organizationcv.CVs);

            //OrganizationCV-Organization
            modelBuilder.Entity<Organization>()
                .HasOne(organization => organization.OrganizationCV)
                .WithMany(organizationcv => organizationcv.Organizations);

            //WorkCV-CV
            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.WorkCV)
                .WithMany(workcv => workcv.CVs);

            //WorkCV-Work
            modelBuilder.Entity<Work>()
                .HasOne(work => work.WorkCV)
                .WithMany(workcv => workcv.Works);

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
