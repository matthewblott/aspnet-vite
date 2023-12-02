using Microsoft.AspNetCore.Mvc;

namespace aspnet_vite.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
