using Recipe.BL.Manager.Abstract;
using Recipe.DAL.Repository.Concrete;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Abstract;


namespace Recipe.BL.Manager.Concrete
{
    public class BaseManager<T, Tid> : Repository<T, Tid>, IManager<T, Tid>
        where T : BaseEntity<Tid>
    {
        private sqlContext context;

        public BaseManager(sqlContext context)
        {
            this.context = context;
        }
    }
}
