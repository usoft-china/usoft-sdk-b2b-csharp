using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils {
    /// <summary>
    /// Open Api 签名 工具类
    /// </summary>
    public class OpenApiSignUtil {
        public static readonly string SIGNATURE_KEY = "signature";

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="src">待签名字符串</param>
        /// <param name="secretKey">密钥</param>
        /// <returns></returns>
        public static string Sign(string src, string secretKey) {
            if (string.IsNullOrWhiteSpace(src)) {
                throw new Exception("待签名字符串为空");
            }
            if (string.IsNullOrWhiteSpace(secretKey)) {
                throw new Exception("密钥为空");
            }
            return HmacUtil.Sign(src, secretKey);
        }
    }
}
