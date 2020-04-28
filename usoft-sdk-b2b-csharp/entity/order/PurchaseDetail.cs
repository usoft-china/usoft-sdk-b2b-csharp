using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{

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
        /// <summary>
        /// 物料承认状态
        /// </summary>
        public string pd_prmaterial { get; set; }
        /// <summary>
        /// 顶层物料编码
        /// </summary>
        public string pd_topmothercode { get; set; }
    }
}
