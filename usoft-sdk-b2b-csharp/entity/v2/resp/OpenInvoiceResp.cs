using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class OpenInvoiceResp
	{
		/// <summary>
		/// 响应体
		/// <summary>
		public RespHeader respHeader { get; set; }
		/// <summary>
		/// 发票单
		/// <summary>
		public InvoiceDetail invoice { get; set; }
	}
}