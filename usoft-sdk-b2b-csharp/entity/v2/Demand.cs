using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class Demand
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
		/// 买家enuu
		/// <summary>
		public int buyerEnuu { get; set; }
		/// <summary>
		/// 询价人enuu
		/// <summary>
		public int demandUu { get; set; }
		/// <summary>
		/// 订单类别(10.指定供应商 20.公共询价)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 报价截止日期（yyyy-MM-dd）
		/// <summary>
		public string offerDeadline { get; set; }
		/// <summary>
		/// 询价时间
		/// <summary>
		public string demandTime { get; set; }
		/// <summary>
		/// 多附件编号列表
		/// <summary>
		public List<string> attachFC { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 附件列表
		/// <summary>
		public List<AttachFile> attachFile { get; set; }
	}
}