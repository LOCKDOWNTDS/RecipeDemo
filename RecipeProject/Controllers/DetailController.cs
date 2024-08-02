using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class DetailController(sqlContext context, IManager<Food, int> foodManager, IManager<Comments, int> commentsManager) : Controller
    {


        public IActionResult Index(int id)
        {
            var food = foodManager.GetAllInclude(p => p.ID == id, p => p.OtherPictures)
                                     .Include(p => p.Comments)
                                     .FirstOrDefault();

            if (food == null)
            {
                return NotFound();
            }

            var foodDetailVM = new FoodDetailVM
            {
                Food = food,
                Comments = food.Comments.ToList()

            };

            return View(foodDetailVM);
        }
        [HttpPost]
        public IActionResult SaveComment(FoodDetailVM foodcomment, int id)
        {
            if (!ModelState.IsValid)
            {
                // Yeniden Index aksiyonuna dönerek hataları göstermek
                return RedirectToAction("Index", new { id = foodcomment.Food.ID });
            }

            var newComment = new Comments
            {
                CommentText = foodcomment.NewCommentText,
                CommentTitle = foodcomment.NewCommentTitle,
                FoodId = id,
                Stars = foodcomment.Stars,
            };

            commentsManager.Insert(newComment);

            // Yorum eklendikten sonra yeniden Index aksiyonuna dön
            return RedirectToAction("Index", new { id = id });
        }


        public IActionResult FromCategoryToDetail(int id)
        {
            var food = foodManager.GetAllInclude(p => p.ID == id, p => p.OtherPictures)
                                    .Include(p => p.Comments)
                                    .FirstOrDefault();
            var foodCategory = context.Foods.Include(p => p.Categorys).ThenInclude(p => p.Category).FirstOrDefault(p => p.ID == id);
            ViewBag.CategoryID = foodCategory.Categorys.Select(p => p.CategoryId).FirstOrDefault();


            if (food == null)
            {
                return NotFound();
            }

            var foodDetailVM = new FoodDetailVM
            {
                Food = food,
                Comments = food.Comments.ToList()

            };

            return View(foodDetailVM);
        }

        public IActionResult FromFoodSuggestion(int id)
        {
            var food = foodManager.GetAllInclude(p => p.ID == id, p => p.OtherPictures)
                                  .Include(p => p.Comments)
                                  .FirstOrDefault();
            var foodCategory = context.Foods.Include(p => p.Categorys).ThenInclude(p => p.Category).FirstOrDefault(p => p.ID == id);
            ViewBag.CategoryID = foodCategory.Categorys.Select(p => p.CategoryId).FirstOrDefault();


            if (food == null)
            {
                return NotFound();
            }

            var foodDetailVM = new FoodDetailVM
            {
                Food = food,
                Comments = food.Comments.ToList()

            };

            return View(foodDetailVM);
        }

    }
}
