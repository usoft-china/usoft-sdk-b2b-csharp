using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderProductReplyList
	{
		/// <summary>
		/// 采购订单产品回复基本信息
		/// <summary>
		public OrderProductReply orderProductReplyBasic { get; set; }
		/// <summary>
		/// 回复人用户信息
		/// <summary>
		public OrderUser replyerUser { get; set; }
		/// <summary>
		/// 采购订单产品
		/// <summary>
		public OrderProduct orderProduct { get; set; }
	}
}