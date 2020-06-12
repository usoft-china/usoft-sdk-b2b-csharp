using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderRemindList
	{
		/// <summary>
		/// 提醒单基本信息
		/// <summary>
		public OrderBizBasic orderRemindBasic { get; set; }
		/// <summary>
		/// 提醒单产品
		/// <summary>
		public List<OrderRemindProduct> orderRemindProduct { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 录单人用户信息
		/// <summary>
		public OrderUser typeInUser { get; set; }
	}
}