using Microsoft.EntityFrameworkCore;
using StudentMVC.Models.Entities;

namespace StudentMVC.Data;

// dotnet ef migrations add <name of migration>
// dotnet ef database update

public class StudentDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Student>().ToTable("Student");
        
        // SEEDING
        
        // Degrees
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 1, Name = "Bachelor" });
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 2, Name = "Master" });
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 3, Name = "Phd" });
        
        // Students
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "ssa171", Firstname = "Said", Lastname = "Nasser", DegreeId = 1});
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "jbe123", Firstname = "Johnny", Lastname = "BeGood", DegreeId = 2});
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "mla789", Firstname = "Morgan", Lastname = "Larsen", DegreeId = 1});
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "lpr058", Firstname = "Linda", Lastname = "Pravidin", DegreeId = 3});
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "rol000", Firstname = "Roy", Lastname = "Olsen", DegreeId = 2});
        modelBuilder.Entity<Student>().HasData(new Student { StudentId = "Ono456", Firstname = "Ola", Lastname = "Nordmann", DegreeId = 3});
    }
    
    public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
    {
    }
    
    public DbSet<Degree>? Degrees { get; set; }
    public DbSet<Student>? Students { get; set; }
    
}