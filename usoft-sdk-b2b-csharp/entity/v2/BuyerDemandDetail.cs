using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class BuyerDemandDetail
	{
		/// <summary>
		/// 询价单基本信息
		/// <summary>
		public Demand demandBasic { get; set; }
		/// <summary>
		/// 询价单产品
		/// <summary>
		public List<BuyerDemandProductDetail> demandProduct { get; set; }
	}
}