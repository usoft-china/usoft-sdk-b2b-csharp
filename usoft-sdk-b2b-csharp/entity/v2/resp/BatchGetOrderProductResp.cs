using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class BatchGetOrderProductResp
	{
		/// <summary>
		/// 响应头信息
		/// <summary>
		public RespHeader respHeader { get; set; }
		/// <summary>
		/// 采购订单产品
		/// <summary>
		public List<OrderProduct> orderProduct { get; set; }
	}
}