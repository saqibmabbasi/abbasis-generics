using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.RepositoryPattern
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity GetById(long id);

		IEnumerable<TEntity> GetAll();

		long GetCount();

		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

		void Add(TEntity entity);

		void AddRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);

		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
