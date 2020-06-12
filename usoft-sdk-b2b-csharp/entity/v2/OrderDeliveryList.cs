using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderDeliveryList
	{
		/// <summary>
		/// 发货单基本信息
		/// <summary>
		public OrderBizBasic orderDeliveryBasic { get; set; }
		/// <summary>
		/// 发货单产品
		/// <summary>
		public List<OrderDeliveryProduct> orderDeliveryProduct { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
	}
}