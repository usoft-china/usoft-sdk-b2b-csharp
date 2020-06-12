using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ReturnOrderAcceptProduct
	{
		/// <summary>
		/// 采购验收单产品编号
		/// <summary>
		public string orderAcceptProductCode { get; set; }
		/// <summary>
		/// 订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
		/// <summary>
		/// 产品编号
		/// <summary>
		public string productCode { get; set; }
		/// <summary>
		/// 单价
		/// <summary>
		public double unitPrice { get; set; }
		/// <summary>
		/// 税率(%)
		/// <summary>
		public double taxRate { get; set; }
		/// <summary>
		/// 批号
		/// <summary>
		public string batchNo { get; set; }
		/// <summary>
		/// 验退数量
		/// <summary>
		public int quantityReturn { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}