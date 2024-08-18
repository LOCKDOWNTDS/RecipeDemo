using Recipe.Entities.Model.Concrete;

namespace Recipe.BL.Manager.Abstract
{
    public interface IFoodInsertManager : IManager<Food, int>
    {
        public void InsertFood(Food item);
    }
}
