using Microsoft.AspNetCore.Mvc;

namespace RecipeProjectMVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
