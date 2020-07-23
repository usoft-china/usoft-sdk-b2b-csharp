using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req
{
	public class OfferDemandProductReq
	{
		/// <summary>
		/// 请求参数签名,（GET KV：K1=V2&K2=V2 ; POST JSON: {"K1":"V1","K2":"V2",signature:""}）
		/// <summary>
		public string signature { get; set; }
		/// <summary>
		/// 秘密身份ID
		/// <summary>
		public string secretId { get; set; }
		/// <summary>
		/// 询价单产品编号
		/// <summary>
		public string demandProductCode { get; set; }
		/// <summary>
		/// 询价单产品报价编号
		/// <summary>
		public string demandProductOfferCode { get; set; }
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
		/// 阶梯价格
		/// <summary>
		public List<LadderPrice> ladderP { get; set; }
		/// <summary>
		/// 物料品牌
		/// <summary>
		public string materialBrand { get; set; }
		/// <summary>
		/// 物料编号
		/// <summary>
		public string materialCode { get; set; }
		/// <summary>
		/// 附件
		/// <summary>
		public AttachFile attachFile { get; set; }
		/// <summary>
		/// 操作人uu
		/// <summary>
		public int uu { get; set; }
		/// <summary>
		/// 报价时间
		/// <summary>
		public string offerTime { get; set; }
	}
}