using Recipe.Entities.Model.Abstract;

namespace Recipe.Entities.Model.Concrete
{
    public class Photos : BaseEntity<int>
    {
        public string PhotoPath { get; set; }

        public int? FoodId { get; set; }
        public Food Food { get; set; }

        public int? UserId { get; set; }
        public MyUser User { get; set; }
    }
}