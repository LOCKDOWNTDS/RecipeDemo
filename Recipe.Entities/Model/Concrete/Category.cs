using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }
        public string? CategoryPhotoPath { get; set; }
        public List<CategoryFood>? Foods { get; set; }

    }
}