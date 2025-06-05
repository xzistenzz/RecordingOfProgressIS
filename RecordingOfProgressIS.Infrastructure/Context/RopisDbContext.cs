using Microsoft.EntityFrameworkCore;
using RecordingOfProgressIS.Domain.Models;
using System.Reflection;

namespace RecordingOfProgressIS.Infrastructure.Context
{
    public class RopisDbContext : DbContext
    {
        public DbSet<AcademicDiscipline> AcademicDisciplines { get; set; }
        public DbSet<DisciplineGroupProfessor> DisciplineGroupProfessors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }

        public RopisDbContext(DbContextOptions<RopisDbContext> options) :
            base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}