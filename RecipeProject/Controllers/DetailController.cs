using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe.BL.Manager.Abstract;
using Recipe.Entities.Model.Concrete;
using RecipeProjectMVC.Models.ViewModels;

namespace RecipeProjectMVC.Controllers
{
    public class DetailController(IManager<Food, int> foodManager, IManager<Comments, int> commentsManager) : Controller
    {
        public IActionResult Index(int id)
        {
            var Food = foodManager.GetAllInclude(p => p.ID == id, p => p.OtherPictures).Include(p => p.Comments).FirstOrDefault();


            if (Food == null)
            {
                return NotFound();
            }

            var foodDetailVM = new FoodDetailVM
            {
                Food = Food,
                Comments = Food.Comments.ToList()
            };


            return View(foodDetailVM);




        }
        [HttpPost]
        public IActionResult SaveComment(FoodDetailVM foodcomment)
        {
            var newComment = new Comments
            {
                CommentText = foodcomment.NewCommentText,
                CommentTitle = foodcomment.NewCommentTitle,
                FoodId = foodcomment.Food.ID,
                Stars = foodcomment.Stars,
            };

            commentsManager.Insert(newComment);

            return View();
        }


    }
}
