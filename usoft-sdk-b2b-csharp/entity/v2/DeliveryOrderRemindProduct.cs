using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class DeliveryOrderRemindProduct
	{
		/// <summary>
		/// 采购发货提醒单产品编号
		/// <summary>
		public string orderRemindProductCode { get; set; }
		/// <summary>
		/// 订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 发货数量
		/// <summary>
		public int quantityDelivery { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}