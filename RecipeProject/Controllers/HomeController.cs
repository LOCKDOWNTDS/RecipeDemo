using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;

namespace RecipeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IManager<Food, int> _foodManager;
        private readonly IManager<Info, int> _infomanager;

        public HomeController(IManager<Food, int> foodManager, IManager<Info, int> infomanager)
        {
            this._foodManager = foodManager;
            this._infomanager = infomanager;
        }

        public IActionResult Index()
        {
            var foods = _foodManager.GetAllInclude(null, p => p.OtherPictures).Where(x => x.Active == true).ToList();
            ViewBag.infos = _infomanager.GetAll();
            return View(foods);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
