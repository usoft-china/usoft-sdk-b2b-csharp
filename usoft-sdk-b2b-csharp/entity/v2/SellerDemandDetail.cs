using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class SellerDemandDetail
	{
		/// <summary>
		/// 询价单基本信息
		/// <summary>
		public Demand demandBasic { get; set; }
		/// <summary>
		/// 询价单产品
		/// <summary>
		public List<SellerDemandProductDetail> demandProduct { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public DemandEnt buyerEnt { get; set; }
	}
}