using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderDeliveryProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 采购发货单编号
		/// <summary>
		public string orderDeliveryCode { get; set; }
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
		/// 采购发货提醒单产品编号
		/// <summary>
		public string orderRemindProductCode { get; set; }
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
		/// 发货数量
		/// <summary>
		public int quantityDelivery { get; set; }
		/// <summary>
		/// 收货数量
		/// <summary>
		public int quantityReceive { get; set; }
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
		/// 状态（30待收货 50.已收货）
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 是否有收货历史
		/// <summary>
		public bool isReceiveHistory { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
	}
}