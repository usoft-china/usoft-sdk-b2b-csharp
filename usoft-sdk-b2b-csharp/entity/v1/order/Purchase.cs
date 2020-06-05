using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    /// <summary>
    /// 采购单信息
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// 采购单号
        /// </summary>
        public string pu_code { get; set; }
        /// <summary>
        /// 单据归属日期(时间戳)
        /// </summary>
        public long pu_date { get; set; }
        /// <summary>
        /// ERP单据中采购员UU号
        /// </summary>
        public long em_uu { get; set; }
        /// <summary>
        ///  ERP单据中采购员姓名
        /// </summary>
        public string em_name { get; set; }
        /// <summary>
        /// ERP单据中采购员性别
        /// </summary>
        public string em_sex { get; set; }
        /// <summary>
        /// ERP单据中采购员电话
        /// </summary>
        public string em_mobile { get; set; }
        /// <summary>
        /// ERP单据中采购员邮箱
        /// </summary>
        public string em_email { get; set; }
        /// <summary>
        /// 供应商uu
        /// </summary>
        public long ve_uu { get; set; }
        /// <summary>
        /// 客户公司名称
        /// </summary>
        public string pu_cop { get; set; }
        /// <summary>
        /// ERP中单据供应商联系人UU
        /// </summary>
        public long ve_contactuu { get; set; }
        /// <summary>
        /// 付款币种(RMB USD)
        /// </summary>
        public string pu_currency { get; set; }
        /// <summary>
        /// 汇率
        /// </summary>
        public float pu_rate { get; set; }
        /// <summary>
        /// 采购类型
        /// </summary>
        public string pu_kind { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string pu_payments { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string pu_remark { get; set; }
        /// <summary>
        /// 录单人
        /// </summary>
        public string pu_recordman { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        public string pu_auditman { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string pu_shipaddresscode { get; set; }
        /// <summary>
        /// 应付供应商名称
        /// </summary>
        public string pu_receivename { get; set; }
        /// <summary>
        /// 应付供应商编号
        /// </summary>
        public string pu_receivecode { get; set; }
        /// <summary>
        /// 在ERP中采购单的id
        /// </summary>
        public long pu_id { get; set; }
        /// <summary>
        /// 用途
        /// </summary>
        public string pu_purpose { get; set; }
        /// <summary>
        /// 买家应收客户
        /// </summary>
        public string pu_arcustcode { get; set; }
        /// <summary>
        /// 收货客户
        /// </summary>
        public string pu_shcustcode { get; set; }
        /// <summary>
        /// 销售单号
        /// </summary>
        public string pu_refcode { get; set; }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string pu_custcode { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string pu_custname { get; set; }
        /// <summary>
        /// 运输方式
        /// </summary>
        public string pu_transport { get; set; }
        /// <summary>
        /// 在平台中采购单的id号
        /// </summary>
        public long pu_b2bid { get; set; }
        /// <summary>
        /// 订单明细
        /// </summary>
        public List<PurchaseDetail> purchaseDetails { get; set; }
    }

    /// <summary>
    /// 附件
    /// </summary>
    public class Attach
    {
        /// <summary>
        /// id
        /// </summary>
        public long fp_id { get; set; }
        /// <summary>
        /// 附件名称
        /// </summary>
        public string fp_name { get; set; }
        /// <summary>
        /// 附件Url
        /// </summary>
        public string fp_url { get; set; }
        /// <summary>
        /// 附件大小
        /// </summary>
        public long fp_size { get; set; }

    }
}
