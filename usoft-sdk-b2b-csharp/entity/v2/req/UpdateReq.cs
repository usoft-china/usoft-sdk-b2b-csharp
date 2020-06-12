using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class UpdateReq
	{
		/// <summary>
		/// 编号(验收单产品或验退单产品编号)
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 单价
		/// <summary>
		public double unitPrice { get; set; }
		/// <summary>
		/// 税率(%)
		/// <summary>
		public double taxRate { get; set; }
	}
}