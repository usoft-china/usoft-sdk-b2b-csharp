using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.product
{
    /// <summary>
    /// ERP系统的产品
    /// </summary>
    public class Product
    {
        /// <summary>
        /// erp物料id
        /// </summary>
        public long pr_id { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string pr_code { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string pr_detail { get; set; }
        /// <summary>
        /// ERP空闲库存
        /// </summary>
        public double pr_reserve { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double price { get; set; }
        /// <summary>
        /// 产品生产日期
        /// </summary>
        public string manufactureDate { get; set; }
        /// <summary>
        /// 物料规格
        /// </summary>
        public string pr_spec { get; set; }
        /// <summary>
        /// 物料单位
        /// </summary>
        public string pr_unit { get; set; }
        /// <summary>
        /// 最新包装数
        /// </summary>
        public double pr_zxbzs { get; set; }
        /// <summary>
        /// 最新订货量
        /// </summary>
        public double pr_zxdhl { get; set; }
        /// <summary>
        /// 采购提前期,天数
        /// </summary>
        public double pr_leadtime { get; set; }
        /// <summary>
        /// 备料提前期，天数
        /// </summary>
        public double pr_ltinstock { get; set; }
        /// <summary>
        /// 物料品牌
        /// </summary>
        public string pr_brand { get; set; }
        /// <summary>
        /// 原厂型号
        /// </summary>
        public string pr_orispeccode { get; set; }
        /// <summary>
        /// 标准料号
        /// </summary>
        public string pr_uuid { get; set; }
        /// <summary>
        /// 状态： ‘已审核’->有效；‘已禁用’->失效
        /// </summary>
        public string pr_status { get; set; }
        /// <summary>
        /// 销售状态
        /// </summary>
        public int pr_issale { get; set; }
        /// <summary>
        /// 采购状态
        /// </summary>
        public int pr_ispurchase { get; set; }
        /// <summary>
        /// 开放采购状态
        /// </summary>
        public int pr_isshow { get; set; }
        /// <summary>
        /// 开放销售状态
        /// </summary>
        public int pr_ispubsale { get; set; }
        /// <summary>
        /// 平台物料id（现在对应也是公共物料库的id）
        /// </summary>
        public long b2b_id { get; set; }
        /// <summary>
        /// 类目（平台）
        /// </summary>
        public string kind { get; set; }
        /// <summary>
        /// 品牌（平台）
        /// </summary>
        public string pbrand { get; set; }
        /// <summary>
        /// 型号（平台）
        /// </summary>
        public string pcmpcode { get; set; }
        /// <summary>
        /// 类目英文
        /// </summary>
        public string kinden { get; set; }
        /// <summary>
        /// 品牌英文
        /// </summary>
        public string pbranden { get; set; }
        /// <summary>
        /// 是否是标准；1： 标准， 0： 非标准
        /// </summary>
        public int standard { get; set; }
        /// <summary>
        /// 物料所属企业UU（需要在erp调用接口时，设置到product实体）
        /// </summary>
        public long pr_enuu { get; set; }

    }
}
