using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class Invoice
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
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
		/// <summary>
		/// 买家enuu
		/// <summary>
		public int buyerEnuu { get; set; }
		/// <summary>
		/// 开票人uu
		/// <summary>
		public int drawerUu { get; set; }
		/// <summary>
		/// 开票时间
		/// <summary>
		public string drawerTime { get; set; }
		/// <summary>
		/// 发票编号
		/// <summary>
		public string invCode { get; set; }
		/// <summary>
		/// 付款方式
		/// <summary>
		public string paymentMethod { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 总金额
		/// <summary>
		public double totalAmount { get; set; }
		/// <summary>
		/// 总税金
		/// <summary>
		public double totalTaxes { get; set; }
		/// <summary>
		/// 卖家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int sellerDataStatus { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}