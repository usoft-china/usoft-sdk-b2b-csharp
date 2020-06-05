using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.entity.v2.req {
    public class CreateOrUpdateProductReq {
        /// <summary>
        /// 请求参数签名,（GET KV：K1=V2&K2=V2 ; POST JSON: {"K1":"V1","K2":"V2",signature:""}）
        /// </summary>
        public string signature { get; set; }
        /// <summary>
        /// 秘密身份ID
        /// </summary>
        public string secretId { get; set; }
        /// <summary>
        /// 操作人uu
        /// </summary>
        public int uu { get; set; }
        /// <summary>
        /// 产品
        /// </summary>
        public CreateOrUpdateProduct product { get; set; }
    }
}
