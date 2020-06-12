using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class PagingSellerOrderProductReplyResp
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
		/// 订单产品回复
		/// <summary>
		public List<OrderProductReplyList> orderProductReply { get; set; }
	}
}