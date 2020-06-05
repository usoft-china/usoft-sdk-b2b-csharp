using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// 客户采购订单
    /// </summary>
    public class SaleDown
    {
        /// <summary>
        /// 平台采购订单id
        /// </summary>
        public long b2b_pu_id { get; set; }
        /// <summary>
        /// 采购单单号
        /// </summary>
        public string sa_code { get; set; }
        /// <summary>
        /// 采购单单号
        /// </summary>
        public string sa_pocode { get; set; }
        /// <summary>
        /// 客户UU(采购企业UU)
        /// </summary>
        public long sa_customeruu { get; set; }
        /// <summary>
        /// 客户名称(采购企业名称)
        /// </summary>
        public string sa_custname { get; set; }
        /// <summary>
        ///  客户联系人(采购企业联系人)
        /// </summary>
        public string sa_custcontact { get; set; }
        /// <summary>
        /// 客户联系人UU(采购企业联系人uu)
        /// </summary>
        public long sa_custcontactuu { get; set; }
        /// <summary>
        /// 客户联系人手机号(采购企业联系人手机号)
        /// </summary>
        public string sa_custmobile { get; set; }
        /// <summary>
        /// 企业业务员UU（供应商联系人uu）
        /// </summary>
        public long sa_useruu { get; set; }
        /// <summary>
        /// 单据归属日期(时间戳)
        /// </summary>
        public long sa_date { get; set; }
        /// <summary>
        /// new Date()(时间戳)
        /// </summary>
        public long sa_recorddate { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string sa_payments { get; set; }
        /// <summary>
        /// 付款币种
        /// </summary>
        public string sa_currency { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public float sa_rate { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string sa_shipby { get; set; }
        /// <summary>
        /// 应付供应商名称
        /// </summary>
        public string sa_receivename { get; set; }
        /// <summary>
        /// 应付供应商编号
        /// </summary>
        public string sa_receivecode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string sa_remark { get; set; }
        public List<SaleDownDetail> saleDownDetails { get; set; }
    }
}
