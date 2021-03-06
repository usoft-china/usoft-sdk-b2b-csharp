using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderEnt
	{
		/// <summary>
		/// 企业Enuu号
		/// <summary>
		public int enuu { get; set; }
		/// <summary>
		/// 企业名
		/// <summary>
		public string name { get; set; }
		/// <summary>
		/// 省
		/// <summary>
		public string province { get; set; }
		/// <summary>
		/// 市
		/// <summary>
		public string city { get; set; }
		/// <summary>
		/// 区
		/// <summary>
		public string district { get; set; }
		/// <summary>
		/// 地址
		/// <summary>
		public string addr { get; set; }
	}
}