using Microsoft.AspNetCore.Mvc;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
	public class AdminPage : Controller
	{
		[Area("Admin")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
