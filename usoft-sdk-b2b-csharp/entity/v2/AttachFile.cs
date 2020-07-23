using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class AttachFile
	{
		/// <summary>
		/// 文件编号
		/// <summary>
		public string code { get; set; }
		/// <summary>
		/// 文件名称
		/// <summary>
		public string name { get; set; }
		/// <summary>
		/// 文件地址
		/// <summary>
		public string url { get; set; }
		/// <summary>
		/// 文件大小
		/// <summary>
		public int size { get; set; }
	}
}