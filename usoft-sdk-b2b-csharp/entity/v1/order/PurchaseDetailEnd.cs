using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// ERP系统的采购订单明细（针对结案、反结案）
    /// </summary>
    public class PurchaseDetailEnd
    {
        public string pd_code { get; set; }
        public short pd_detno { get; set; }
        public short pd_ended { get; set; }
    }
}
