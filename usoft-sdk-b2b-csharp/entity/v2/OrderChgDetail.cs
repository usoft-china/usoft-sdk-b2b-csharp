using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderChgDetail
	{
		/// <summary>
		/// 变更单基本信息
		/// <summary>
		public OrderChg orderChgBasic { get; set; }
		/// <summary>
		/// 变更单产品
		/// <summary>
		public List<OrderChgProduct> orderChgProduct { get; set; }
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
	}
}