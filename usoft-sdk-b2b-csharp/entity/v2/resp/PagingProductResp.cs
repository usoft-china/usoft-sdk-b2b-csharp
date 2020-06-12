using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.resp
{
	public class PagingProductResp
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
		/// 产品
		/// <summary>
		public List<Product> product { get; set; }
	}
}