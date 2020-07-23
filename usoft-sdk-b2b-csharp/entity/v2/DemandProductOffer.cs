using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class DemandProductOffer
	{
		/// <summary>
		/// 编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 卖家enuu
		/// <summary>
		public int sellerEnuu { get; set; }
		/// <summary>
		/// 询价单产品编号
		/// <summary>
		public string demandProductCode { get; set; }
		/// <summary>
		/// 交期
		/// <summary>
		public int deliveryTime { get; set; }
		/// <summary>
		/// 税率(%)
		/// <summary>
		public double taxRate { get; set; }
		/// <summary>
		/// 最小包装数
		/// <summary>
		public int mpq { get; set; }
		/// <summary>
		/// 最小起订量
		/// <summary>
		public int moq { get; set; }
		/// <summary>
		/// 物料品牌
		/// <summary>
		public string materialBrand { get; set; }
		/// <summary>
		/// 物料编号
		/// <summary>
		public string materialCode { get; set; }
		/// <summary>
		/// 附件编号
		/// <summary>
		public string attachFileCode { get; set; }
		/// <summary>
		/// 报价人enuu
		/// <summary>
		public int offerUu { get; set; }
		/// <summary>
		/// 报价时间
		/// <summary>
		public string offerTime { get; set; }
		/// <summary>
		/// 状态（10.待报价 20.待采纳 30.已采纳 40.未采纳 50.已失效）
		/// <summary>
		public int status { get; set; }
		/// <summary>
		/// 阶梯价格
		/// <summary>
		public List<LadderPrice> ladderP { get; set; }
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
		/// 附件
		/// <summary>
		public AttachFile attachFile { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public DemandEnt sellerEnt { get; set; }
	}
}