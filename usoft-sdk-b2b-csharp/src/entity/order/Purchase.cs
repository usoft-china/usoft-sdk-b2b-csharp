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
    /// 订单明细
    /// </summary>
    public class PurchaseDetail
    {
        /// <summary>
        /// 采购单号
        /// </summary>
        public string pd_code { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string pd_prodcode { get; set; }
        /// <summary>
        /// 采购数量
        /// </summary>
        public double pd_qty { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public double pd_price { get; set; }
        /// <summary>
        /// 交货日期(时间戳)
        /// </summary>
        public long pd_delivery { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string pd_remark { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public float pd_rate { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int pd_detno { get; set; }
        /// <summary>
        /// 送货工厂
        /// </summary>
        public string pd_factory { get; set; }
        /// <summary>
        /// 供应商规格
        /// </summary>
        public string pd_vendspec { get; set; }
        /// <summary>
        /// 备品数量
        /// </summary>
        public int pd_beipin { get; set; }
        /// <summary>
        /// 终端供应商名称
        /// </summary>
        public string pd_purcvendname { get; set; }
        /// <summary>
        /// 终端供应商uu
        /// </summary>
        public long pd_purcvenduu { get; set; }
        /// <summary>
        /// 客户采购订单号
        /// </summary>
        public string pd_custpurchasecode { get; set; }
        /// <summary>
        /// 客户采购订单序号
        /// </summary>
        public int pd_custpurchasedetno { get; set; }
        /// <summary>
        /// 收货客户
        /// </summary>
        public string pd_acceptcustname { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string pd_acceptcustaddress { get; set; }
        /// <summary>
        /// 收货客户uu
        /// </summary>
        public long pd_acceptcustuu { get; set; }
        /// <summary>
        /// 是否能发货
        /// </summary>
        public string pd_hasissued { get; set; }
        /// <summary>
        /// 终端价格
        /// </summary>
        public float pd_purcprice { get; set; }
        /// <summary>
        /// 终端税率
        /// </summary>
        public float pd_purctaxrate { get; set; }
        /// <summary>
        /// 终端币别
        /// </summary>
        public string pd_purccurrency { get; set; }
        /// <summary>
        /// 税收分类编码
        /// </summary>
        public string pd_taxcode { get; set; }
        /// <summary>
        /// 开票名称
        /// </summary>
        public string pd_billname { get; set; }
        /// <summary>
        /// 开票型号
        /// </summary>
        public string pd_orispeccode { get; set; }
        /// <summary>
        /// 附件
        /// </summary>
        public List<Attach> attaches { get; set; }
        /// <summary>
        /// 替代料号
        /// </summary>
        public string pd_repprodcode { get; set; }
        /// <summary>
        /// 替代料名称
        /// </summary>
        public string pd_repdetail { get; set; }
        /// <summary>
        /// 替代料规格
        /// </summary>
        public string pd_repspec { get; set; }
        /// <summary>
        /// 旧料编号
        /// </summary>
        public string pr_oldcode { get; set; }
        /// <summary>
        /// 旧料名称
        /// </summary>
        public string pr_oldname { get; set; }
        /// <summary>
        /// 旧料规格
        /// </summary>
        public string pr_oldspec { get; set; }
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
