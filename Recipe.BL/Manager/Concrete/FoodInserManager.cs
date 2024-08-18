using Recipe.BL.Manager.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Concrete;

namespace Recipe.BL.Manager.Concrete
{
    public class FoodInserManager : BaseManager<Food, int>, IFoodInsertManager
    {
        private readonly sqlContext _context;
        public FoodInserManager(sqlContext context) : base(context)
        {
            this._context = context;
        }


        public int InsertFood(Food item)
        {

            bool succes = true;
            if (item.Name.Length < 0 && item.Name.Length > 50)
            {
                succes = false;
                throw new Exception("Yemek ismi hatalı");
            }
            if (item.Materials.Length < 0 && item.Materials.Length > 500)
            {
                succes = false;
                throw new Exception("Yemek Malzemeleri  hatalı");
            }
            if (item.HowManyPerson == null)
            {
                succes = false;
                throw new Exception("Kaç kişilik Kısmı Boş Bırakılamaz!");
            }
            if (item.CookingTime == null)
            {
                succes = false;
                throw new Exception("Pişirme Süresi Boş Bırakılamaz!");
            }
            if (item.RecipeExplanation == null)
            {
                succes = false;
                throw new Exception("Hazırlık süresi Boş Bırakılamaz!");
            }
            if (item.Categorys == null)
            {
                succes = false;
                throw new Exception("Kategori Boş Bırakılamaz");
            }


            _context.Foods.Add(item);
            return _context.SaveChanges();
        }
    }
}
