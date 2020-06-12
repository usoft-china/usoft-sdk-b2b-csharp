using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class ConfirmSellerReconcileReq
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
		/// 开始时间
		/// <summary>
		public string startTime { get; set; }
		/// <summary>
		/// 结束时间
		/// <summary>
		public string endTime { get; set; }
		/// <summary>
		/// 卖家确认对账产品
		/// <summary>
		public List<ConfirmSellerReconcileProduct> reconcileProduct { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
		/// <summary>
		/// 业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 卖家对账时间/录单时间
		/// <summary>
		public string sellerReconcileTime { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}