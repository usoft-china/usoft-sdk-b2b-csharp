using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2
{
    public class RespHeader
    {
        /// <summary>
        /// 状态码 0.正常 非0.异常
        /// </summary>
        public int code { get; set; }
        /// <summary>
        ///  错误信息 code!=0时,有值
        /// </summary>
        public string msg { get; set; }
    }
}
