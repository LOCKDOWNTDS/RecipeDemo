namespace Recipe.Entities.Model.Concrete
{
    public class CategoryFood
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
