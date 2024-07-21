using Recipe.DAL.Repository.Abstract;
using Recipe.Entities.Model.Abstract;

namespace Recipe.BL.Manager.Abstract
{
    public interface IManager<T, Tid> : IRepository<T> where T : BaseEntity<Tid>
    {

    }
}
