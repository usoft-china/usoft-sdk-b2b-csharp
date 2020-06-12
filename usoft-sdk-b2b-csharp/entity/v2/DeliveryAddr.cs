using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class DeliveryAddr
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 省
		/// <summary>
		public string province { get; set; }
		/// <summary>
		/// 市
		/// <summary>
		public string city { get; set; }
		/// <summary>
		/// 区
		/// <summary>
		public string district { get; set; }
		/// <summary>
		/// 地址
		/// <summary>
		public string addr { get; set; }
		/// <summary>
		/// 收货人姓名
		/// <summary>
		public string buyerName { get; set; }
		/// <summary>
		/// 电话
		/// <summary>
		public string phone { get; set; }
		/// <summary>
		/// 默认选项
		/// <summary>
		public bool defaultOption { get; set; }
	}
}