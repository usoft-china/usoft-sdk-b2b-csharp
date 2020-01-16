using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// 采购订单回复记录
    /// </summary>
    public class PurchaseReply
    {
        /// <summary>
        /// erpid
        /// </summary>
        public long pr_id { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double pr_qty { get; set; }
        /// <summary>
        /// 交货日期(时间戳)
        /// </summary>
        public long pr_delivery { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string pr_remark { get; set; }
        /// <summary>
        /// 采购单单号
        /// </summary>
        public string pr_pucode { get; set; }
        /// <summary>
        /// 采购明细序号
        /// </summary>
        public short pr_pddetno { get; set; }
        /// <summary>
        /// 回复日期(时间戳)
        /// </summary>
        public long pr_date { get; set; }
        /// <summary>
        /// 回复人
        /// </summary>
        public string pr_recorder { get; set; }
        /// <summary>
        /// b2b_id
        /// </summary>
        public long b2b_pr_id { get; set; }
        /// <summary>
        /// 类型{供应商ERP回复、供应商平台回复、采购主动回复}
        /// </summary>
        public string pr_type { get; set; }
    }
}
