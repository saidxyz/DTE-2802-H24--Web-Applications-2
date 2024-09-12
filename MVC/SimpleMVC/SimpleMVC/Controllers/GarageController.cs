using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models.Entities;

namespace SimpleMVC.Controllers;

public class GarageController : Controller
{
    private readonly List<Car> _cars = new()
    {
        new Car { CarId = "AX32968", Make = "Chevrolet", Model = "Camaro", Year = 1981},
        new Car { CarId = "HF27343", Make = "Mazda", Model = "Mazda 6", Year = 2016},
        new Car { CarId = "YZ97000", Make = "Hyundai", Model = "Santa Fe", Year = 2007}
    };
    
    
    // GET:
    // Url: /Garage
    // or simply "/" when default in program.cs is set to GarageController
    public IActionResult Index()
    {
        return View(_cars);
    }
}