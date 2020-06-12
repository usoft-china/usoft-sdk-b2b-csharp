using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class GetOrderAcceptDetailResp
	{
		/// <summary>
		/// 响应头信息
		/// <summary>
		public RespHeader respHeader { get; set; }
		/// <summary>
		/// 采购验收单
		/// <summary>
		public OrderAcceptList orderAccept { get; set; }
	}
}