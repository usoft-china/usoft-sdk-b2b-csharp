using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ReceiveOrderDeliveryProduct
	{
		/// <summary>
		/// 采购发货单产品编号
		/// <summary>
		public string orderDeliveryProductCode { get; set; }
		/// <summary>
		/// 收货数量
		/// <summary>
		public int quantityReceive { get; set; }
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