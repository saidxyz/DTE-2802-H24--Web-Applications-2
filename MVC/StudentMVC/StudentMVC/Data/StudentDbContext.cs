using Microsoft.EntityFrameworkCore;
using StudentMVC.Models.Entities;

namespace StudentMVC.Data;

public class StudentDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Student>().ToTable("Student");
        
        // SEEDING
        
        // Degrees
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 1, Name = "Bachelor" });
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 1, Name = "Master" });
        modelBuilder.Entity<Degree>().HasData(new Degree { DegreeId = 1, Name = "Phd" });
        
        
    }
    
    public StudentDbContext(DbContextOptions<StudentDbContext> options)
    {
    }
    
    public DbSet<Degree>? Degrees { get; set; }
    public DbSet<Student>? Students { get; set; }
    
}