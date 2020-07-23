using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class CreateDemandReq
	{
		/// <summary>
		/// 请求参数签名,（GET KV：K1=V2&K2=V2 ; POST JSON: {"K1":"V1","K2":"V2",signature:""}）
		/// <summary>
		public string signature { get; set; }
		/// <summary>
		/// 秘密身份ID
		/// <summary>
		public string secretId { get; set; }
		/// <summary>
		/// 订单类别(10.指定供应商 20.公共询价)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 供应商Enuu列表
		/// <summary>
		public List<int> sellerEnuu { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 报价截止日期（yyyy-MM-dd）
		/// <summary>
		public string offerDeadline { get; set; }
		/// <summary>
		/// 附件列表
		/// <summary>
		public List<AttachFile> attachFile { get; set; }
		/// <summary>
		/// 询价单产品
		/// <summary>
		public List<ImportDemandProduct> demandProduct { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
		/// <summary>
		/// 订单业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 询价时间
		/// <summary>
		public string demandTime { get; set; }
	}
}