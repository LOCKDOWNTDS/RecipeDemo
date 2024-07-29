using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Controllers
{
    public class CategoryController(IManager<Category, int> categorymanager, sqlContext context) : Controller
    {
        public IActionResult Index()
        {

            var Categories = categorymanager.GetAll();
            ViewBag.Bool = true;
            return View(Categories);
        }
        public IActionResult FoodList(int id)
        {
            var foodList = context.Categories.Include(p => p.Foods)
                .ThenInclude(p => p.Food)
                .ThenInclude(p => p.OtherPictures)
                .FirstOrDefault(p => p.ID == id);

            return View(foodList);
        }
    }
}
