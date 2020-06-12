using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class Reconcile
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 开始期间（yyyy-MM-dd）
		/// <summary>
		public string periodStart { get; set; }
		/// <summary>
		/// 结束期间（yyyy-MM-dd）
		/// <summary>
		public string periodEnd { get; set; }
		/// <summary>
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
		/// <summary>
		/// 卖家对账人uu
		/// <summary>
		public int sellerReconcileUu { get; set; }
		/// <summary>
		/// 卖家对账时间/录单时间
		/// <summary>
		public string sellerReconcileTime { get; set; }
		/// <summary>
		/// 买家enuu
		/// <summary>
		public int buyerEnuu { get; set; }
		/// <summary>
		/// 买家对账人uu
		/// <summary>
		public int buyerReconcileUu { get; set; }
		/// <summary>
		/// 买家对账时间
		/// <summary>
		public string buyerReconcileTime { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 总金额
		/// <summary>
		public double totalAmount { get; set; }
		/// <summary>
		/// 状态(10.待确认 20.已确认 30.已作废)
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 作废原因
		/// <summary>
		public string invalidReason { get; set; }
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