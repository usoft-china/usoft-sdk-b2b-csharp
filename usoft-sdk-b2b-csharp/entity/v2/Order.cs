using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class Order
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 业务号
		/// <summary>
		public string bizCode { get; set; }
		/// <summary>
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
		/// <summary>
		/// 卖家联系人uu
		/// <summary>
		public int sellerLinkmanUu { get; set; }
		/// <summary>
		/// 买家enuu
		/// <summary>
		public int buyerEnuu { get; set; }
		/// <summary>
		/// 买家输入人enuu
		/// <summary>
		public int buyerTypeInUu { get; set; }
		/// <summary>
		/// 订单类别(10.采购订单 20.委外订单)
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// 付款方式
		/// <summary>
		public string paymentMethod { get; set; }
		/// <summary>
		/// 币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currency { get; set; }
		/// <summary>
		/// 汇率
		/// <summary>
		public double exchangeRate { get; set; }
		/// <summary>
		/// 总金额
		/// <summary>
		public double totalAmount { get; set; }
		/// <summary>
		/// 录入时间
		/// <summary>
		public string createdTime { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 加工开始日期（yyyy-MM-dd）
		/// <summary>
		public string processStart { get; set; }
		/// <summary>
		/// 加工结束日期（yyyy-MM-dd）
		/// <summary>
		public string processEnd { get; set; }
		/// <summary>
		/// 委外类型
		/// <summary>
		public string outsourceType { get; set; }
		/// <summary>
		/// 送货工厂
		/// <summary>
		public string deliveryFactory { get; set; }
		/// <summary>
		/// 卖家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int sellerDataStatus { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 应付供应商编号
		/// <summary>
		public string paySellerCode { get; set; }
		/// <summary>
		/// 应付供应商名称
		/// <summary>
		public string paySellerName { get; set; }
	}
}