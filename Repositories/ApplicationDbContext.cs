using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using ClassManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ClassManager.Repositories
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers{get; set;}
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Enroll> Enroll { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AssignGrade>().HasOne(x=>x.Grade).
                WithMany(z=> z.AssignGrade).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<AssignGrade>().HasOne(x=>x.Lecturer).
                WithMany(z=> z.AssignGrade).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Student).
                WithMany(z=>z.YearlySession).HasForeignKey(x=>x.SessionId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Session).
                WithMany(z=>z.Enrollment).HasForeignKey(x=>x.SessionId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Enroll>().HasOne(x=>x.Grade).
                WithMany(z=>z.Enrolls).HasForeignKey(x=>x.GradeId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<LecturerSesssion>().HasOne(x=>x.Lecturer).
                WithMany(z=>z.LecturerSessions).HasForeignKey(x => x.LecturerId).OnDelete(DeleteBehavior.SetNull);

            builder.Entity<LecturerSesssion>().HasOne(x => x.Session).  
                WithMany(z => z.LecturerSessions).HasForeignKey(x => x.SessionId).OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);

        }
    }
}