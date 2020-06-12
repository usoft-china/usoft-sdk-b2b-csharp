using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ReplyOrderProductContent
	{
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 数量
		/// <summary>
		public int quantity { get; set; }
		/// <summary>
		/// 交期
		/// <summary>
		public string deliveryTime { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 回复时间
		/// <summary>
		public string replyerTime { get; set; }
	}
}