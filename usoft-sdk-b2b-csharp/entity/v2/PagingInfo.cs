using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class PagingInfo
	{
		/// <summary>
		/// 总页数
		/// <summary>
		public int totalPage { get; set; }
		/// <summary>
		/// 总条数
		/// <summary>
		public int totalCount { get; set; }
		/// <summary>
		/// 每页条数
		/// <summary>
		public int pageSize { get; set; }
		/// <summary>
		/// 当前页码
		/// <summary>
		public int pageNumber { get; set; }
	}
}