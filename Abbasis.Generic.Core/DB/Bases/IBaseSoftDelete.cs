using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.Core.DB.Bases
{
	public interface IBaseSoftDelete
	{
        public bool IS_DELETED { get; set; }
    }
}
