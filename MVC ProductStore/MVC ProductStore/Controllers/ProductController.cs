using Microsoft.AspNetCore.Mvc;
using MVC_ProductStore.Models.Entities;

namespace MVC_ProductStore.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        List<Product> products = new List<Product>{
            new Product {Name="Hammer", Price=121.50m, Category="Verktøy"},
            new Product {Name="Vinkelsliper", Price=1520.00m, Category ="Verktøy"},
            new Product {Name="Melk", Price=14.50m, Category ="Dagligvarer"},
            new Product {Name="Kjøttkaker", Price=32.00m, Category ="Dagligvarer"},
            new Product {Name="Brød", Price=25.50m, Category ="Dagligvarer"}
        };
        return View(products);
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
}

