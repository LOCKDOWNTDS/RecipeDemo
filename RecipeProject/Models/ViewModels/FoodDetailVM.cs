using Recipe.Entities.Model.Concrete;
namespace RecipeProjectMVC.Models.ViewModels
{
    public class FoodDetailVM
    {

        public Food? Food { get; set; }
        public List<Comments>? Comments { get; set; }
        public string NewCommentText { get; set; }
        public string NewCommentTitle { get; set; }
        public int Stars { get; set; }
    }
}
