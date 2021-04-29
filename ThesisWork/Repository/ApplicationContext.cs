using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWork.Models;

namespace ThesisWork.Repository
{
    class ApplicationContext : DbContext
    {
        public DbSet<MarksReport> MarksReports { get; set; }
        public DbSet<PracticeBase> PracticeBases { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<PracticeSchedule> PracticeSchedule { get; set; }
        public virtual DbSet<Competence> Competences { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        
        
        public ApplicationContext()
        {
            Database.EnsureCreated();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(u => new { u.GradeBookNumber, u.SudtingYear });
            modelBuilder.Entity<PracticeSchedule>().HasMany(p => p.Competences).WithMany(p => p.PracticesSchedule);
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MUDJ8A0;Database=Thesis;Trusted_Connection=True;");
        }
    }
}
