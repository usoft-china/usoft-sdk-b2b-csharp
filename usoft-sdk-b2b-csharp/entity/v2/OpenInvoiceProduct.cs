using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OpenInvoiceProduct
	{
		/// <summary>
		/// 类别(10.验收单产品 20.验退单产品)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 类别编号（类别所对应业务的编号）
		/// <summary>
		public string categoryCode { get; set; }
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
		/// 开票数量
		/// <summary>
		public int quantityInvoice { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
	}
}