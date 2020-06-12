using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderProduct
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 采购订单编号
		/// <summary>
		public string orderCode { get; set; }
		/// <summary>
		/// 订单类别(10.采购订单 20.委外订单)
		/// <summary>
		public int orderCategory { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
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
		/// 数量
		/// <summary>
		public int quantity { get; set; }
		/// <summary>
		/// 发货提醒数量
		/// <summary>
		public int quantityRemind { get; set; }
		/// <summary>
		/// 发货数量
		/// <summary>
		public int quantityDelivery { get; set; }
		/// <summary>
		/// 收货数量
		/// <summary>
		public int quantityReceive { get; set; }
		/// <summary>
		/// 验收数量
		/// <summary>
		public int quantityAccept { get; set; }
		/// <summary>
		/// 验退数量
		/// <summary>
		public int quantityReturn { get; set; }
		/// <summary>
		/// 回复数量
		/// <summary>
		public int quantityReply { get; set; }
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
		/// 状态（10.待发货 30.已发货 50.已收货 90.已结案）
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 回复状态（10.待回复 30.已回复）
		/// <summary>
		public int replyStatus { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 是否有回复历史
		/// <summary>
		public bool isReplyHistory { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
		/// <summary>
		/// 终端供应商uu
		/// <summary>
		public int endSellerEnuu { get; set; }
		/// <summary>
		/// 税收分类编码
		/// <summary>
		public string taxCategoryCode { get; set; }
		/// <summary>
		/// 开票名称
		/// <summary>
		public string invoiceName { get; set; }
		/// <summary>
		/// 开票型号
		/// <summary>
		public string invoiceModel { get; set; }
	}
}