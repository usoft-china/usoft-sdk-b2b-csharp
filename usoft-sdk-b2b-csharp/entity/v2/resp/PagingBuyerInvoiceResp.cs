using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class PagingBuyerInvoiceResp
	{
		/// <summary>
		/// 响应头信息
		/// <summary>
		public RespHeader respHeader { get; set; }
		/// <summary>
		/// 分页信息
		/// <summary>
		public PagingInfo pagingInfo { get; set; }
		/// <summary>
		/// 发票单
		/// <summary>
		public List<InvoiceDetail> invoice { get; set; }
	}
}