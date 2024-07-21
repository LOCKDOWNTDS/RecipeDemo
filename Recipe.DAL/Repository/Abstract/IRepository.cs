using System.Linq.Expressions;

namespace Recipe.DAL.Repository.Abstract
{
	public interface IRepository<T>
	{
		public int Insert(T input);
		public int Update(T input);
		public int Delete(T input);
		public int DeleteById(int id);
		public T? GetById(int id);
		public List<T>? GetAll(Expression<Func<T, bool>> predicate = null);
		public T? Get(Expression<Func<T, bool>> predicate = null);
		IQueryable<T> GetAllInclude(Expression<Func<T, bool>>? predicate,
								 params Expression<Func<T, object>>[] includes);

	}
}
