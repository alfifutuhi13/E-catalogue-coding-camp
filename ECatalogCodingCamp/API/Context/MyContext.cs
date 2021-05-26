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
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<User> Users { get; set; }

        //public override void OnModelCreating(ModelBuilder modelBuilder) 
        //{ 
        //}

    }
}
