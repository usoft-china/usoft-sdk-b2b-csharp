using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderProductReply
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 类别(1.确认 -1.撤销)
		/// <summary>
		public int category { get; set; }
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
		/// 回复人uu
		/// <summary>
		public int replyerUu { get; set; }
		/// <summary>
		/// 回复时间
		/// <summary>
		public string replyerTime { get; set; }
		/// <summary>
		/// 买家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int buyerDataStatus { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}