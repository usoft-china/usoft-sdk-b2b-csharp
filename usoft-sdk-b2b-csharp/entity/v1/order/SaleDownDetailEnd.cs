using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// 卖家ERP系统的客户采购订单明细（针对结案、反结案）
    /// </summary>
    public class SaleDownDetailEnd
    {
        /// <summary>
        /// 订单明细id
        /// </summary>
        public long b2b_pd_id { get; set; }
        /// <summary>
        /// 采购单所属企业UU
        /// </summary>
        public long cu_uu { get; set; }
        /// <summary>
        /// 采购单号
        /// </summary>
        public string sd_code { get; set; }
        /// <summary>
        /// 明细序号
        /// </summary>
        public int sd_detno { get; set; }
        /// <summary>
        /// 结案状态（是否已结案）
        /// </summary>
        public int sd_ended { get; set; }
    }
}
