using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
    public class CreateOrUpdateProduct
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// 物料编号
        /// </summary>
        public string materialCode { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string brand { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 最小包装数
        /// </summary>
        public int mpq { get; set; }
        /// <summary>
        /// 最小起订量
        /// </summary>
        public int moq { get; set; }
        /// <summary>
        /// 交期
        /// </summary>
        public int deliveryTime { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public string createdTime { get; set; }
        /// <summary>
        /// 来源ID
        /// </summary>
        public string sourceId { get; set; }
    }
}
