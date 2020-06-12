using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderReturnList
	{
		/// <summary>
		/// 验退单基本信息
		/// <summary>
		public OrderBizBasic orderReturnBasic { get; set; }
		/// <summary>
		/// 验退单产品
		/// <summary>
		public List<OrderReturnProduct> orderReturnProduct { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 验退人用户信息
		/// <summary>
		public OrderUser returnUser { get; set; }
	}
}