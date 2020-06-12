using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class OrderChg
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
		/// 订单编号
		/// <summary>
		public string orderCode { get; set; }
		/// <summary>
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
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
		/// 原先付款方式
		/// <summary>
		public string paymentMethodOrg { get; set; }
		/// <summary>
		/// 当前付款方式
		/// <summary>
		public string paymentMethodCur { get; set; }
		/// <summary>
		/// 原先币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currencyOrg { get; set; }
		/// <summary>
		/// 当前币别(人民币.RMB,美元.USD,港元.HKD,英镑.GBP,欧元.EUR,日元.JPY)
		/// <summary>
		public string currencyCur { get; set; }
		/// <summary>
		/// 原先汇率
		/// <summary>
		public double exchangeRateOrg { get; set; }
		/// <summary>
		/// 当前汇率
		/// <summary>
		public double exchangeRateCur { get; set; }
		/// <summary>
		/// 原先加工开始日期（yyyy-MM-dd）
		/// <summary>
		public string processStartOrg { get; set; }
		/// <summary>
		/// 当前加工开始日期（yyyy-MM-dd）
		/// <summary>
		public string processStartCur { get; set; }
		/// <summary>
		/// 原先加工结束日期（yyyy-MM-dd）
		/// <summary>
		public string processEndOrg { get; set; }
		/// <summary>
		/// 当前加工结束日期（yyyy-MM-dd）
		/// <summary>
		public string processEndCur { get; set; }
		/// <summary>
		/// 原先委外类型
		/// <summary>
		public string outsourceTypeOrg { get; set; }
		/// <summary>
		/// 当前委外类型
		/// <summary>
		public string outsourceTypeCur { get; set; }
		/// <summary>
		/// 原先送货工厂
		/// <summary>
		public string deliveryFactoryOrg { get; set; }
		/// <summary>
		/// 当前送货工厂
		/// <summary>
		public string deliveryFactoryCur { get; set; }
		/// <summary>
		/// 录入时间
		/// <summary>
		public string createdTime { get; set; }
		/// <summary>
		/// 是否卖家确认
		/// <summary>
		public bool isSellerConfirm { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 状态(10.待处理 20.已处理 30.无需确认)
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 回复备注
		/// <summary>
		public string replyRemark { get; set; }
		/// <summary>
		/// 回复状态(10.同意 20.不同意)
		/// <summary>
		public int replyStatus { get; set; }
		/// <summary>
		/// 卖家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int sellerDataStatus { get; set; }
		/// <summary>
		/// 买家数据状态（10.待下载  20.已下载）
		/// <summary>
		public int buyerDataStatus { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
		/// <summary>
		/// 采购订单业务号
		/// <summary>
		public string orderBizCode { get; set; }
		/// <summary>
		/// 原先应付供应商编号
		/// <summary>
		public string paySellerCodeOrg { get; set; }
		/// <summary>
		/// 当前应付供应商编号
		/// <summary>
		public string paySellerCodeCur { get; set; }
		/// <summary>
		/// 原先应付供应商名称
		/// <summary>
		public string paySellerNameOrg { get; set; }
		/// <summary>
		/// 当前应付供应商名称
		/// <summary>
		public string paySellerNameCur { get; set; }
	}
}