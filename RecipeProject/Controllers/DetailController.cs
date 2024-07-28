using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class DetailController : Controller
    {
        private readonly IManager<Food, int> _foodManager;
        private readonly IManager<Comments, int> _commentsManager;

        public DetailController(IManager<Food, int> foodManager, IManager<Comments, int> commentsManager)
        {
            _foodManager = foodManager;
            _commentsManager = commentsManager;
        }

        public IActionResult Index(int id)
        {
            var food = _foodManager.GetAllInclude(p => p.ID == id, p => p.OtherPictures)
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

            _commentsManager.Insert(newComment);

            // Yorum eklendikten sonra yeniden Index aksiyonuna dön
            return RedirectToAction("Index", new { id = id });
        }
    }
}
