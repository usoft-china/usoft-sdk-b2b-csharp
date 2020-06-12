using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class ReplyOrderChgReq
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
		/// 采购变更单编号
		/// <summary>
		public string orderChgCode { get; set; }
		/// <summary>
		/// 回复备注
		/// <summary>
		public string replyRemark { get; set; }
		/// <summary>
		/// 回复状态(10.同意 20.不同意)
		/// <summary>
		public int replyStatus { get; set; }
	}
}