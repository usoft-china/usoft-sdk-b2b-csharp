using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class PrintConfig
	{
		/// <summary>
		/// 编号;
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 企业uu;
		/// <summary>
		public int enuu { get; set; }
		/// <summary>
		/// 别名/英文名
		/// <summary>
		public string alias { get; set; }
		/// <summary>
		/// 电话;
		/// <summary>
		public string mobile { get; set; }
		/// <summary>
		/// 传真;
		/// <summary>
		public string fax { get; set; }
		/// <summary>
		/// 地址;
		/// <summary>
		public string addr { get; set; }
		/// <summary>
		/// 附属内容A;
		/// <summary>
		public string contentA { get; set; }
		/// <summary>
		/// 附属内容B;
		/// <summary>
		public string contentB { get; set; }
		/// <summary>
		/// 附属内容C;
		/// <summary>
		public string contentC { get; set; }
		/// <summary>
		/// 模板类型（10：采购订单模板，20：委外订单模板，30：卖家送货单模板，40：卖家对账单模板）
		/// <summary>
		public int category { get; set; }
		/// <summary>
		/// logo文件编号;
		/// <summary>
		public string logoFileCode { get; set; }
		/// <summary>
		/// 公章文件编号;
		/// <summary>
		public string signetFileCode { get; set; }
		/// <summary>
		/// logo文件地址;
		/// <summary>
		public string logoFilePath { get; set; }
		/// <summary>
		/// 公章文件地址;
		/// <summary>
		public string signetFilePath { get; set; }
	}
}