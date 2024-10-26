using Abbasis.Generic.GlobalValues.Entities;
using Abbasis.Generic.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.GlobalValues.Repositories
{
	public class FndGlobalValuesRepository : Repository<FND_GLOBAL_VALUES>, IFndGlobalValuesRepository
	{
		public FndGlobalValuesRepository(DbContext context) : base(context)
		{
		}
	}
}
