using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
    public class Food : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Materials { get; set; }
        public int? Like { get; set; }
        public string HowManyPerson { get; set; }
        public string PreparationTime { get; set; }
        public string CookingTime { get; set; }
        public string? PictureOne { get; set; }
        public List<Photos> OtherPictures { get; set; }
        public string RecipeExplanation { get; set; }

        public List<Comments>? Comments { get; set; }
        public List<CategoryFood>? Categorys { get; set; }
        public bool Active { get; set; } = true;
    }
}
