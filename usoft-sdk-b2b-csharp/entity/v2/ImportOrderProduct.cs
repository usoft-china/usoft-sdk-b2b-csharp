using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ImportOrderProduct
	{
		/// <summary>
		/// 物料编号
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
		/// 单位
		/// <summary>
		public string unit { get; set; }
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
		/// 交期
		/// <summary>
		public string deliveryTime { get; set; }
		/// <summary>
		/// 备注
		/// <summary>
		public string remark { get; set; }
		/// <summary>
		/// 序号
		/// <summary>
		public int ordinal { get; set; }
		/// <summary>
		/// 来源ID
		/// <summary>
		public string sourceId { get; set; }
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
		/// <summary>
		/// 附件列表
		/// <summary>
		public List<AttachFile> attachFile { get; set; }
		/// <summary>
		/// 送货工厂
		/// <summary>
		public string factory { get; set; }
		/// <summary>
		/// 备品数量
		/// <summary>
		public int quantitySpare { get; set; }
		/// <summary>
		/// 替代料号
		/// <summary>
		public string replaceMaterialCode { get; set; }
		/// <summary>
		/// 替代料名称
		/// <summary>
		public string replaceMaterialName { get; set; }
		/// <summary>
		/// 替代料规格
		/// <summary>
		public string replaceMaterialSpec { get; set; }
		/// <summary>
		/// 旧料编号
		/// <summary>
		public string oldMaterialCode { get; set; }
		/// <summary>
		/// 旧料名称
		/// <summary>
		public string oldMaterialName { get; set; }
		/// <summary>
		/// 旧料规格
		/// <summary>
		public string oldMaterialSpec { get; set; }
		/// <summary>
		/// 物料承认状态
		/// <summary>
		public string materialAdmitStatus { get; set; }
		/// <summary>
		/// 顶层物料编码
		/// <summary>
		public string topMaterialCode { get; set; }
	}
}