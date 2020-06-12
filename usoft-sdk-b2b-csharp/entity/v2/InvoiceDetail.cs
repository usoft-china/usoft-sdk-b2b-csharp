using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class InvoiceDetail
	{
		/// <summary>
		/// 发票单基本信息
		/// <summary>
		public Invoice invoiceBasic { get; set; }
		/// <summary>
		/// 发票单产品
		/// <summary>
		public List<InvoiceProduct> invoiceProduct { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 开票人用户信息
		/// <summary>
		public OrderUser drawerUser { get; set; }
	}
}