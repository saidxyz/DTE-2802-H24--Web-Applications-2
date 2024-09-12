namespace SimpleMVC.Models.Entities;

public class Car
{
    public string CarId { get; set; } = "No license";
    public string Make { get; set; } = "Unknown";
    public string Model { get; set; } = "Unknown";
    public int Year { get; set; }
}