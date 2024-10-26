using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.Core.DB.Bases
{
	public interface IBaseWho
	{
		public long CREATED_BY { get; set; }

		public DateTime CREATED_ON { get; set; }

		public long LAST_UPDATED_BY { get; set; }

		public DateTime LAST_UPDATED_ON { get; set; }
	}
}
