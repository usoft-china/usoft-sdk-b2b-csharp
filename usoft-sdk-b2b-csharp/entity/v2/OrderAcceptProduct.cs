using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderAcceptProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 采购验收单编号
		/// <summary>
		public string orderAcceptCode { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
		/// <summary>
		/// 采购订单编号
		/// <summary>
		public string orderCode { get; set; }
		/// <summary>
		/// 采购订单产品编号
		/// <summary>
		public string orderProductCode { get; set; }
		/// <summary>
		/// 采购发货单产品编号
		/// <summary>
		public string orderDeliveryProductCode { get; set; }
		/// <summary>
		/// 采购收货单产品编号
		/// <summary>
		public string orderReceiveProductCode { get; set; }
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
		/// 批号
		/// <summary>
		public string batchNo { get; set; }
		/// <summary>
		/// 验收数量
		/// <summary>
		public int quantityAccept { get; set; }
		/// <summary>
		/// 验退数量
		/// <summary>
		public int quantityReturn { get; set; }
		/// <summary>
		/// 小计
		/// <summary>
		public double subtotalAmount { get; set; }
		/// <summary>
		/// 单位
		/// <summary>
		public string unit { get; set; }
		/// <summary>
		/// 交期
		/// <summary>
		public string deliveryTime { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 卖家对账状态(10.未对账 20.已对账)
		/// <summary>
		public int sellerReconcileStatus { get; set; }
		/// <summary>
		/// 卖家对账人uu
		/// <summary>
		public int sellerReconcileUu { get; set; }
		/// <summary>
		/// 卖家对账时间/录单时间
		/// <summary>
		public string sellerReconcileTime { get; set; }
		/// <summary>
		/// 买家对账状态(10.未对账 20.已对账)
		/// <summary>
		public int buyerReconcileStatus { get; set; }
		/// <summary>
		/// 买家对账人uu
		/// <summary>
		public int buyerReconcileUu { get; set; }
		/// <summary>
		/// 买家对账时间
		/// <summary>
		public string buyerReconcileTime { get; set; }
		/// <summary>
		/// 开票状态(10.未开票 20.已开票)
		/// <summary>
		public int invoiceStatus { get; set; }
		/// <summary>
		/// 开票人uu
		/// <summary>
		public int drawerUu { get; set; }
		/// <summary>
		/// 开票时间
		/// <summary>
		public string drawerTime { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 收货数量
		/// <summary>
		public int quantityReceive { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
	}
}