using Abbasis.Generic.GlobalValues.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.GlobalValues.Services
{
	public interface IGlobalValueService
	{
		public GlobalValue GetGlobalValue(string key, DateTime effectiveDate);
	}
}
