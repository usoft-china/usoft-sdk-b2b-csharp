using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderChgProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 采购变更单编号
		/// <summary>
		public string orderChgCode { get; set; }
		/// <summary>
		/// 订单类别(10.采购订单 20.委外订单)
		/// <summary>
		public int orderCategory { get; set; }
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 原先单价
		/// <summary>
		public double unitPriceOrg { get; set; }
		/// <summary>
		/// 当前单价
		/// <summary>
		public double unitPriceCur { get; set; }
		/// <summary>
		/// 原先税率(%)
		/// <summary>
		public double taxRateOrg { get; set; }
		/// <summary>
		/// 当前税率(%)
		/// <summary>
		public double taxRateCur { get; set; }
		/// <summary>
		/// 原先数量
		/// <summary>
		public int quantityOrg { get; set; }
		/// <summary>
		/// 当前数量
		/// <summary>
		public int quantityCur { get; set; }
		/// <summary>
		/// 原先单位
		/// <summary>
		public string unitOrg { get; set; }
		/// <summary>
		/// 当前单位
		/// <summary>
		public string unitCur { get; set; }
		/// <summary>
		/// 原先交期
		/// <summary>
		public string deliveryTimeOrg { get; set; }
		/// <summary>
		/// 当前交期
		/// <summary>
		public string deliveryTimeCur { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 采购订单产品
		/// <summary>
		public OrderProduct orderProduct { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
	}
}