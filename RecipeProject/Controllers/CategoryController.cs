using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Controllers
{
    public class CategoryController(IManager<Category, int> categorymanager, IManager<Food, int> foodmanager) : Controller
    {
        public IActionResult Index()
        {

            var Categories = categorymanager.GetAll();
            return View(Categories);
        }

        public IActionResult FoodList(int id)
        {
            var foodList = categorymanager.GetAllInclude(p => p.ID == id, p => p.Foods).FirstOrDefault();
            ViewBag.FoodPhoto = foodmanager.GetAllInclude(p => p.ID == foodList.ID, p => p.OtherPictures).FirstOrDefault();

            return View(foodList);
        }
    }
}
