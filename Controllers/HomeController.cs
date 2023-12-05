using Microsoft.AspNetCore.Mvc;

namespace aspnet_vite.MVC.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

}
