using Microsoft.AspNetCore.Mvc;

namespace MVC_ProductStore.Controllers;

public class ProductController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}