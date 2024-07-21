using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
    public class Comments : BaseEntity<int>
    {
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public int Stars { get; set; }

        public Food Food { get; set; }
        public int FoodId { get; set; }
    }
}