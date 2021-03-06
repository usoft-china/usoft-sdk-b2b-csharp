using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderAcceptList
	{
		/// <summary>
		/// 验收单基本信息
		/// <summary>
		public OrderBizBasic orderAcceptBasic { get; set; }
		/// <summary>
		/// 验收单产品
		/// <summary>
		public List<OrderAcceptProduct> orderAcceptProduct { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 验收人用户信息
		/// <summary>
		public OrderUser acceptUser { get; set; }
	}
}