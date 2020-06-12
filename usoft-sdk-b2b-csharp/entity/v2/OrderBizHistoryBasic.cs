using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderBizHistoryBasic
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 数量
		/// <summary>
		public int quantity { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int operateUu { get; set; }
		/// <summary>
		/// 操作人姓名
		/// <summary>
		public string operateName { get; set; }
		/// <summary>
		/// 操作时间
		/// <summary>
		public string operateTime { get; set; }
		/// <summary>
		/// 单位
		/// <summary>
		public string unit { get; set; }
	}
}