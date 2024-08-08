using Microsoft.AspNetCore.Mvc;

namespace RecipeProjectMVC.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
