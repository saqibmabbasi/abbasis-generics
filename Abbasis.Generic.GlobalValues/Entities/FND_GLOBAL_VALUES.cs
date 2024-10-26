//using Abbasis.Generic.Core.DB.Bases;
using Abbasis.Generic.Core.DB.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbasis.Generic.GlobalValues.Entities
{
	public class FND_GLOBAL_VALUES : IBaseDateTrack, IBaseWho, IBaseActive, IBaseAttributes
	{
        public long GLOBAL_VALUE_ID { get; set; }
        public string GLOBAL_VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public DateOnly EFFECTIVE_START_DATE { get; set; }
		public DateOnly EFFECTIVE_END_DATE { get; set; }
		public bool ACTIVE { get; set; }
		public long CREATED_BY { get; set; }
		public DateTime CREATED_ON { get; set; }
		public long LAST_UPDATED_BY { get; set; }
		public DateTime LAST_UPDATED_ON { get; set; }
		public string? ATTRIBUTE_1 { get; set; }
		public string? ATTRIBUTE_2 { get; set; }
		public string? ATTRIBUTE_3 { get; set; }
		public string? ATTRIBUTE_4 { get; set; }
		public string? ATTRIBUTE_5 { get; set; }
		public string? ATTRIBUTE_6 { get; set; }
		public string? ATTRIBUTE_7 { get; set; }
		public string? ATTRIBUTE_8 { get; set; }
		public string? ATTRIBUTE_9 { get; set; }
		public string? ATTRIBUTE_10 { get; set; }
		public string? ATTRIBUTE_11 { get; set; }
		public string? ATTRIBUTE_12 { get; set; }
		public string? ATTRIBUTE_13 { get; set; }
		public string? ATTRIBUTE_14 { get; set; }
		public string? ATTRIBUTE_15 { get; set; }
		public string? ATTRIBUTE_16 { get; set; }
		public string? ATTRIBUTE_17 { get; set; }
		public string? ATTRIBUTE_18 { get; set; }
		public string? ATTRIBUTE_19 { get; set; }
		public string? ATTRIBUTE_20 { get; set; }
		public string? ATTRIBUTE_21 { get; set; }
		public string? ATTRIBUTE_22 { get; set; }
		public string? ATTRIBUTE_23 { get; set; }
		public string? ATTRIBUTE_24 { get; set; }
		public string? ATTRIBUTE_25 { get; set; }
		public string? ATTRIBUTE_26 { get; set; }
		public string? ATTRIBUTE_27 { get; set; }
		public string? ATTRIBUTE_28 { get; set; }
		public string? ATTRIBUTE_29 { get; set; }
		public string? ATTRIBUTE_30 { get; set; }
	}
}
