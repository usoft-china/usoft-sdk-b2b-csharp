using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderDetail
	{
		/// <summary>
		/// 订单基本信息
		/// <summary>
		public Order orderBasic { get; set; }
		/// <summary>
		/// 订单产品
		/// <summary>
		public List<OrderProduct> orderProduct { get; set; }
		/// <summary>
		/// 订单收货信息
		/// <summary>
		public OrderDeliveryAddr orderDeliveryAddr { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 买家输入人用户信息
		/// <summary>
		public OrderUser buyerTypeInUser { get; set; }
		/// <summary>
		/// 卖家联系人用户信息
		/// <summary>
		public OrderUser sellerLinkmanUser { get; set; }
	}
}