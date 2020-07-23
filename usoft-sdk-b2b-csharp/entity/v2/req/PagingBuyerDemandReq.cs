using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class PagingBuyerDemandReq
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
		/// 状态（10.待报价 20.待采纳 30.已采纳 40.未采纳 50.已失效）
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 开始时间
		/// <summary>
		public string startTime { get; set; }
		/// <summary>
		/// 结束时间
		/// <summary>
		public string endTime { get; set; }
		/// <summary>
		/// 关键词（询价单号/编号/型号/品牌/名称/规格）
		/// <summary>
		public string keywords { get; set; }
		/// <summary>
		/// 类别(10.指定供应商 20.公共询价)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 买家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int buyerDataStatus { get; set; }
	}
}