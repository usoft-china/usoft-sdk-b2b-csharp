using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class PagingBuyerReconcileReq
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
		/// 每页条数
		/// <summary>
		public int pageSize { get; set; }
		/// <summary>
		/// 当前页码
		/// <summary>
		public int pageNumber { get; set; }
		/// <summary>
		/// 开始时间
		/// <summary>
		public string startTime { get; set; }
		/// <summary>
		/// 结束时间
		/// <summary>
		public string endTime { get; set; }
		/// <summary>
		/// 数据修改时间 时间戳(单位：毫秒)
		/// <summary>
		public long updateTime { get; set; }
	}
}