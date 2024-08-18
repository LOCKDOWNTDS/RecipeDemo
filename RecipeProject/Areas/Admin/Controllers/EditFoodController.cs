using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    public class EditFoodController(IManager<Food, int> foodManager) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hide(int id)
        {
            var selectedFood = foodManager.GetById(id);
            selectedFood.Active = (selectedFood.Active == true) ? selectedFood.Active = false : selectedFood.Active = true;
            // ViewBag.message = "OK";
            return View();
        }
    }
}
