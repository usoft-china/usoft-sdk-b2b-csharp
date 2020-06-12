using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class CreateOrderRemindResp
	{
		/// <summary>
		/// 响应体
		/// <summary>
		public RespHeader respHeader { get; set; }
		/// <summary>
		/// 采购发货提醒单
		/// <summary>
		public OrderRemindList orderRemind { get; set; }
	}
}