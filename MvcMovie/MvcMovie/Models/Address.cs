using MessagePack;

namespace MvcMovie.Models;

public class Address
{
    [Key]
    public int id { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}