using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
	public class ReconcileDetail
	{
		/// <summary>
		/// 对账单基本信息
		/// <summary>
		public Reconcile reconcileBasic { get; set; }
		/// <summary>
		/// 对账单产品
		/// <summary>
		public List<ReconcileProduct> reconcileProduct { get; set; }
		/// <summary>
		/// 卖家企业信息
		/// <summary>
		public OrderEnt sellerEnt { get; set; }
		/// <summary>
		/// 卖家对账人用户信息
		/// <summary>
		public OrderUser sellerReconcileUser { get; set; }
		/// <summary>
		/// 买家企业信息
		/// <summary>
		public OrderEnt buyerEnt { get; set; }
		/// <summary>
		/// 买家对账人用户信息
		/// <summary>
		public OrderUser buyerReconcileUser { get; set; }
	}
}