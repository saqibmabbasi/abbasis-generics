using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.GlobalValues.Repositories
{
	public interface IGlobalValueUnitOfWork : IDisposable
	{
		IFndGlobalValuesRepository globalValuesRepository { get; }
		int Complete();
	}


	public class GlobalValueUnitOfWork: IGlobalValueUnitOfWork
	{
		private readonly DbContext context;

		public IFndGlobalValuesRepository globalValuesRepository { get; }

        public GlobalValueUnitOfWork(DbContext _context)
        {
			this.context = _context;
			globalValuesRepository = new FndGlobalValuesRepository(_context);
		}


        public int Complete()
		{
			return context.SaveChanges();
		}

		public void Dispose()
		{
			context.Dispose();
		}
	}
}
