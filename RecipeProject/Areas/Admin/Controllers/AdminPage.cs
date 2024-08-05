using Microsoft.AspNetCore.Mvc;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    public class AdminPage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
