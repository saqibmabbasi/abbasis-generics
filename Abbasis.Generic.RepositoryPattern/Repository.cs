using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Abbasis.Generic.RepositoryPattern
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
		protected readonly DbContext context;


		public Repository(DbContext _context)
		{
			context = _context;
		}


		public void Add(TEntity entity)
		{
			context.Entry(entity).State = EntityState.Added;
			context.Set<TEntity>().Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			context.Set<TEntity>().AddRange(entities);
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return context.Set<TEntity>().Where(predicate);
		}

		public TEntity GetById(long id)
		{
			return context.Set<TEntity>().Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return context.Set<TEntity>().ToList();
		}


		public long GetCount()
		{
			return context.Set<TEntity>().Count();
		}

		public void Remove(TEntity entity)
		{
			context.Set<TEntity>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			context.Set<TEntity>().RemoveRange(entities);
		}
	}
}
