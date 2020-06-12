using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class InvoiceProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 发票单编号
		/// <summary>
		public string invoiceCode { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
		/// <summary>
		/// 类别(10.验收单产品 20.验退单产品)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 类别编号（类别所对应业务的编号）
		/// <summary>
		public string categoryCode { get; set; }
		/// <summary>
		/// 类别单据业务编号（例如：验收单业务号/验退单业务号）
		/// <summary>
		public string categoryBizCode { get; set; }
		/// <summary>
		/// 采购订单编号
		/// <summary>
		public string orderCode { get; set; }
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 采购订单产品序号
		/// <summary>
		public int orderProductOrdinal { get; set; }
		/// <summary>
		/// 产品编号
		/// <summary>
		public string productCode { get; set; }
		/// <summary>
		/// 产品物料编号
		/// <summary>
		public string productMaterialCode { get; set; }
		/// <summary>
		/// 产品型号
		/// <summary>
		public string productModel { get; set; }
		/// <summary>
		/// 产品品牌
		/// <summary>
		public string productBrand { get; set; }
		/// <summary>
		/// 产品名称
		/// <summary>
		public string productName { get; set; }
		/// <summary>
		/// 产品规格
		/// <summary>
		public string productSpec { get; set; }
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
		/// 小计
		/// <summary>
		public double subtotalAmount { get; set; }
		/// <summary>
		/// 税金小计
		/// <summary>
		public double subtotalTaxes { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
	}
}