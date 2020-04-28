using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.order
{
    public class MessageLog
    {
        /// <summary>
        /// id
        /// </summary>
        public int ml_id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public long ml_date { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string ml_man { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string ml_content { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public string ml_result { get; set; }
        /// <summary>
        /// 查找条件
        /// </summary>
        public string ml_search { get; set; }
        /// <summary>
        /// 对应单据编号
        /// </summary>
        public string code { get; set; }
    }
}
