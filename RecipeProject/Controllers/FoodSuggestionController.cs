using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class FoodSuggestionController(sqlContext context) : Controller
    {
        public IActionResult Index()
        {



            var food1 = context.CategoryFoods.Where(p => p.CategoryId == 2).Include(p => p.Food).ToList();
            var food2 = context.CategoryFoods.Where(p => p.CategoryId == randomCategory()).Include(p => p.Food).ToList();
            var Food3 = context.CategoryFoods.Where(p => p.CategoryId == 9).Include(p => p.Food).ToList();


            var soap = food1.Where(p => p.FoodId == RandomFood(food1)).FirstOrDefault();
            var MainFood = food2.Where(p => p.FoodId == RandomFood(food2)).FirstOrDefault();
            var Dessert = Food3.Where(p => p.FoodId == RandomFood(Food3)).FirstOrDefault();



            var newDailyMenu = new DailyMenuVM()
            {
                Soap = soap,
                Main = MainFood,
                Dessert = Dessert
            };

            return View(newDailyMenu);
        }

        public int RandomFood(List<CategoryFood> food)
        {
            var count = food.Count();
            var rnd = new Random();
            var random = rnd.Next(1, count);
            return random;
        }

        public int randomCategory()
        {
            var rnd = new Random();
            List<int> randoms = new List<int> { 1, 3, 4, 5, 7, 8 };
            int randomIndex = rnd.Next(randoms.Count);
            return randoms[randomIndex];
        }



    }
}
