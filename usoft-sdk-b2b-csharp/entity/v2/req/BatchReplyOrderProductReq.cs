using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class BatchReplyOrderProductReq
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
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
		/// <summary>
		/// 类别(10.默认数量和交期 20.自定义交期 30.自定义回复)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 采购订单产品回复内容
		/// <summary>
		public List<ReplyOrderProductContent> replyContent { get; set; }
	}
}