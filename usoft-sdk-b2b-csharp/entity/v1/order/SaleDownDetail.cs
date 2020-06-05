using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    public class SaleDownDetail
    {
        /// <summary>
        /// 平台订单明细id
        /// </summary>
        public long b2b_pd_id { get; set; }
        /// <summary>
        /// 订单单号
        /// </summary>
        public string sd_code { get; set; }
        /// <summary>
        /// 明细序号
        /// </summary>
        public long sd_detno { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string sd_custprodcode { get; set; }
        /// <summary>
        /// 物料标题
        /// </summary>
        public string sd_custproddetail { get; set; }
        /// <summary>
        /// 物料规格
        /// </summary>
        public string sd_custprodspec { get; set; }
        /// <summary>
        /// 物料单位
        /// </summary>
        public string sd_custprodunit { get; set; }
        /// <summary>
        /// 交货日期(时间戳)
        /// </summary>
        public long sd_delivery { get; set; }
        /// <summary>
        /// 回复数量
        /// </summary>
        public double sd_replyqty { get; set; }
        /// <summary>
        /// (最近一次)回复的交期(时间戳)
        /// </summary>
        public long sd_replydate { get; set; }
        /// <summary>
        /// (最近一次)回复的备注
        /// </summary>
        public string sd_replydetail { get; set; }
        /// <summary>
        /// 加工单价
        /// </summary>
        public double sd_price { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public double sd_qty { get; set; }
        /// <summary>
        /// 含税金额
        /// </summary>
        public double sd_total { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
        public float sd_taxrate { get; set; }
        /// <summary>
        /// 不含税金额
        /// </summary>
        public double sd_taxtotal { get; set; }
        /// <summary>
        /// 送货工厂
        /// </summary>
        public string sd_factory { get; set; }
        /// <summary>
        /// 物料路径来源
        /// </summary>
        public string sd_prodsource { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string sd_remark { get; set; }
        /// <summary>
        /// 终端供应商名称
        /// </summary>
        public string sd_purcvendname { get; set; }
        /// <summary>
        /// 终端供应商uu
        /// </summary>
        public long sd_purcvenduu { get; set; }
        /// <summary>
        /// 客户采购订单序号
        /// </summary>
        public int sd_purcdetno { get; set; }
        /// <summary>
        /// 收货客户
        /// </summary>
        public string sd_acceptcustname { get; set; }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string sd_acceptcustaddress { get; set; }
        /// <summary>
        /// 终端单价
        /// </summary>
        public float sd_SpecPrice { get; set; }
        /// <summary>
        /// 终端税率
        /// </summary>
        public float sd_SpecTaxRate { get; set; }
        /// <summary>
        /// 终端币别
        /// </summary>
        public string sd_SpecCurrency { get; set; }
        /// <summary>
        /// 客户物料税收分类编码
        /// </summary>
        public string sd_prodtaxcode { get; set; }
        /// <summary>
        /// 客户物料开票名称
        /// </summary>
        public string sd_prodbillname { get; set; }
        /// <summary>
        /// 客户物料开票型号
        /// </summary>
        public string sd_prodorispeccode { get; set; }
    }
}
