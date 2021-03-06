using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class OpenInvoiceReq
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
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 开票产品
		/// <summary>
		public List<OpenInvoiceProduct> invoiceProduct { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
		/// <summary>
		/// 付款方式
		/// <summary>
		public string paymentMethod { get; set; }
		/// <summary>
		/// 发票编号
		/// <summary>
		public string invCode { get; set; }
		/// <summary>
		/// 业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 开票时间
		/// <summary>
		public string drawerTime { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}