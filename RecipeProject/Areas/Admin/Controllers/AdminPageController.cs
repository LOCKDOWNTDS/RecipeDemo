using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Areas.Admin.Models;

namespace RecipeProjectMVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "Admin")]
	public class AdminPage(IManager<MyUser, int> userManager, IManager<Food, int> foodManager, sqlContext context) : Controller
	{


		public IActionResult myUser()
		{
			var users = userManager.GetAllInclude(null, p => p.Roles).ToList();
			return View(users);
		}



		public IActionResult Foods(int? categoryId)
		{
			var foodsQuery = context.Foods.Include(x => x.Categorys).ThenInclude(x => x.Category).AsQueryable();

			if (categoryId.HasValue)
			{
				foodsQuery = foodsQuery.Where(x => x.Categorys.Any(c => c.CategoryId == categoryId));
			}

			var foods = foodsQuery.ToList();

			var categories = context.Categories.ToList(); // Dropdown için kategorileri çekiyoruz

			var viewModel = new FoodCategoryVM
			{
				Foods = foods,
				Categories = categories,
				SelectedCategoryId = categoryId
			};

			return View(viewModel);
		}
	}
}
