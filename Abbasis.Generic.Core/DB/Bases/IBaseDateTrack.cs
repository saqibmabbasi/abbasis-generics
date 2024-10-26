using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.Core.DB.Bases
{
	public interface IBaseDateTrack
	{
		public DateOnly EFFECTIVE_START_DATE { get; set; }

		public DateOnly EFFECTIVE_END_DATE { get; set; }
	}
}
