using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models.Entities;

public class Student
{
    [MaxLength(8)]
    public string? StudentId { get; set; } // ssa171
    public string? Firstname { get; set; }
    public string? Lastname { get; set; }
    
    // Navigational Properties
    public int DegreeId { get; set; }
    public Degree Degree { get; set; }
}