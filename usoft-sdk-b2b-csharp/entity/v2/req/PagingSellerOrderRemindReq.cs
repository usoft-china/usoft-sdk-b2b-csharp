using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class PagingSellerOrderRemindReq
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
		/// 状态（10.待发货 30.已发货 90.已结案）
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
		/// 关键词（订单号/提醒单号/客户/编号/型号/品牌/名称/规格）
		/// <summary>
		public string keywords { get; set; }
		/// <summary>
		/// 数据修改时间 时间戳(单位：毫秒)
		/// <summary>
		public long updateTime { get; set; }
		/// <summary>
		/// 订单类别(10.采购订单 20.委外订单)
		/// <summary>
		public int category { get; set; }
	}
}