using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class SellerDemandProductDetail
	{
		/// <summary>
		/// 询价单产品基本信息
		/// <summary>
		public DemandProduct demandProductBasic { get; set; }
		/// <summary>
		/// 询价单产品报价
		/// <summary>
		public DemandProductOffer demandProductOffer { get; set; }
	}
}