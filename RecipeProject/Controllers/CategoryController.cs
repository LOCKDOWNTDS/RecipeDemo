using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Controllers
{
    public class CategoryController(IManager<Category, int> categorymanager, IManager<Food, int> foodmanager) : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
