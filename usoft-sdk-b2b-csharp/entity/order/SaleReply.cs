using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// SaleDown明细回复记录
    /// </summary>
    public class SaleReply
    {
        /// <summary>
        /// erpid
        /// </summary>
        public long sr_id { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double sr_qty { get; set; }
        /// <summary>
        /// 交货日期(时间戳)
        /// </summary>
        public long sr_delivery { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string sr_remark { get; set; }
        /// <summary>
        /// 采购单单号
        /// </summary>
        public string sr_sacode { get; set; }
        /// <summary>
        /// 采购明细序号
        /// </summary>
        public int sr_sddetno { get; set; }
        /// <summary>
        /// 回复日期(时间戳)
        /// </summary>
        public long sr_date { get; set; }
        /// <summary>
        /// 回复人
        /// </summary>
        public string sr_recorder { get; set; }
        public long cu_uu { get; set; }
        /// <summary>
        /// 明细id
        /// </summary>
        public long b2b_pd_id { get; set; }
        /// <summary>
        /// 回复id
        /// </summary>
        public long b2b_pr_id { get; set; }
        /// <summary>
        /// 类型{供应商ERP回复、供应商平台回复、采购主动回复}
        /// </summary>
        public string sr_type { get; set; }
    }
}
