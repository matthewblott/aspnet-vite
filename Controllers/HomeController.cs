using Microsoft.AspNetCore.Mvc;

namespace ViteNET.MVC.Controllers;

public class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

}
