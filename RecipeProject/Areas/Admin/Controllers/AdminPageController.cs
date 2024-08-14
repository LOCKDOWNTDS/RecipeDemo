using Microsoft.AspNetCore.Mvc;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
    public class AdminPage(IManager<MyUser, int> userManager, sqlContext context) : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            var users = userManager.GetAllInclude(null, p => p.Roles).ToList();

            return View(users);
        }
    }
}
