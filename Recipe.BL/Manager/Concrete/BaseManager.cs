using Recipe.BL.Manager.Abstract;
using Recipe.DAL.Repository.Concrete;
using Recipe.Entities.Model.Abstract;


namespace Recipe.BL.Manager.Concrete
{
    public class BaseManager<T, Tid> : Repository<T, Tid>, IManager<T, Tid>
        where T : BaseEntity<Tid>
    {

    }
}
