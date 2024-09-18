using System.Security.Cryptography.Pkcs;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Data;
using StudentMVC.Models.Entities;

namespace StudentMVC.Models;

public class StudentRepository : IStudentRepository
{
    private static List<Student> Students { get; }
    private readonly StudentDbContext _db;

    public StudentRepository(StudentDbContext db)
    {
        _db = db;
    }
    
    public IEnumerable<Student> GetAll()
    {
        var students = _db.Students
            .Include(deg => deg.Degree)
            .ToList();
        return students;
    }

    public void Save(Student student)

    {
        // Add Student to database
        // SAve changes
    }
}