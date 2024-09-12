using Microsoft.AspNetCore.Mvc;

namespace SimpleMVC.Controllers;

public class GarageController : Controller
{
    // GET
    public IActionResult Index()
    {
         return View();
    }
}