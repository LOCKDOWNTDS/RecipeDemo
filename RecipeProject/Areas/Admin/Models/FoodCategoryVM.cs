using Recipe.Entities.Model.Concrete;

namespace RecipeProjectMVC.Areas.Admin.Models
{
    public class FoodCategoryVM
    {
        public List<Food> Foods { get; set; }
        public List<Category> Categories { get; set; }
        public int? SelectedCategoryId { get; set; }

    }
}
