using Microsoft.EntityFrameworkCore;
using Recipe.DAL.Repository.Abstract;
using Recipe.Entities.DbContexts;
using Recipe.Entities.Model.Abstract;
using System.Linq.Expressions;

namespace Recipe.DAL.Repository.Concrete
{
    public class Repository<T, Tid> : IRepository<T> where T : BaseEntity<Tid>
    {
        readonly sqlContext sqlContext;
        public Repository()
        {
            sqlContext = new sqlContext();
        }
        public virtual int Delete(T input)
        {
            sqlContext.Set<T>().Remove(input);
            return sqlContext.SaveChanges();
        }

        public virtual int DeleteById(int id)
        {
            var Delete = sqlContext.Set<T>().Find(id);
            sqlContext.Set<T>().Remove(Delete);
            return sqlContext.SaveChanges();
        }

        public virtual T? Get(Expression<Func<T, bool>> predicate)
        {
            return sqlContext.Set<T>().Where(predicate).FirstOrDefault();
        }

        public virtual List<T>? GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return sqlContext.Set<T>().Where(predicate).ToList();
            }
            else
                return sqlContext.Set<T>().ToList();
        }

        public virtual IQueryable<T> GetAllInclude(Expression<Func<T, bool>>? predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> queryable;
            if (predicate != null)
            {
                queryable = sqlContext.Set<T>().Where(predicate);
            }
            else
            {
                queryable = sqlContext.Set<T>();
            }
            return includes.Aggregate(queryable, (current, includeProperty) => current.Include(includeProperty));

        }

        public virtual T? GetById(int id)
        {
            return sqlContext.Set<T>().Find(id);

        }

        public virtual int Insert(T input)
        {
            sqlContext.Set<T>().Add(input);
            return sqlContext.SaveChanges();
        }

        public virtual int Update(T input)
        {
            sqlContext.Set<T>().Update(input);
            return sqlContext.SaveChanges();
        }
    }
}
