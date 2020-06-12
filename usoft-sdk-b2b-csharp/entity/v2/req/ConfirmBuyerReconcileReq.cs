using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class ConfirmBuyerReconcileReq
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
		/// 对账单编号
		/// <summary>
		public string reconcileCode { get; set; }
		/// <summary>
		/// 状态(20.确认 30.作废)
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 作废原因
		/// <summary>
		public string invalidReason { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
	}
}