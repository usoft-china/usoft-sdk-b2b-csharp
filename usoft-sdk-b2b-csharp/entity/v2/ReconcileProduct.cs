using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ReconcileProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 对账单编号
		/// <summary>
		public string reconcileCode { get; set; }
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
		/// 采购订单编号
		/// <summary>
		public string orderCode { get; set; }
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 对账数量
		/// <summary>
		public int quantityReconcile { get; set; }
		/// <summary>
		/// 小计
		/// <summary>
		public double subtotalAmount { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 采购验收单产品
		/// <summary>
		public OrderAcceptProduct orderAcceptProduct { get; set; }
		/// <summary>
		/// 采购验退单产品
		/// <summary>
		public OrderReturnProduct orderReturnProduct { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
		/// <summary>
		/// 类别单据业务编号（例如：验收单业务号/验退单业务号）
		/// <summary>
		public string categoryBizCode { get; set; }
	}
}