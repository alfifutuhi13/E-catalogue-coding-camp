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
        public DbSet<Client> Clients { get; set; }
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

            //Skill-CV
            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.Skill)
                .WithMany(skill => skill.CVs);

            //Organization-CV
            modelBuilder.Entity<CV>()
                .HasOne(cv => cv.Organization)
                .WithMany(organization => organization.CVs);

            //User-CV
            modelBuilder.Entity<User>()
                .HasOne(user => user.Education)
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

            //User-Client (Where RoleID =2)
            modelBuilder.Entity<User>()
                .HasOne(user => user.Client)
                .WithOne(client => client.User)
                .HasForeignKey<Client>(client => client.Id);

            //User-Book
            modelBuilder.Entity<Book>()
               .HasOne(book => book.User)
               .WithMany(user => user.Books);

            //Book-InterviewRequest
            modelBuilder.Entity<Book>()
                .HasOne(book => book.InterviewRequest)
                .WithOne(interviewrequest => interviewrequest.Book)
                .HasForeignKey<InterviewRequest>(interviewrequest => interviewrequest.Id);
        }

    }
}
