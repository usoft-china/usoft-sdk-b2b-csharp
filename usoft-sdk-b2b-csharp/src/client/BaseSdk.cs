using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client
{
    public class BaseSdk
    {
        /// <summary>
        /// 默认超时时间
        /// </summary>
        protected static int DEFAULT_TIMEOUT = 60000;

        /// <summary>
        /// 域名地址
        /// </summary>
        public string baseUrl = "";
        /// <summary>
        /// 超时时间，单位毫秒
        /// </summary>
        protected int timeout = DEFAULT_TIMEOUT;
        /// <summary>
        /// 企业UU号
        /// </summary>
        protected string secretId = "";
        /// <summary>
        /// 密钥
        /// </summary>
        protected string secretKey = "";

        public BaseSdk(string baseUrl, string secretId, string secretKey)
            : this(baseUrl, secretId, secretKey, DEFAULT_TIMEOUT)
        {

        }

        public BaseSdk(string baseUrl, string secretId, string secretKey, int timeout)
        {
            this.baseUrl = baseUrl;
            this.secretId = secretId;
            this.secretKey = secretKey;
            this.timeout = timeout;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="url"></param>
        /// <param name="map"></param>
        /// <returns></returns>
        protected Dictionary<string, string> GenerateSignature(string url, Dictionary<string, string> map)
        {
            if (map == null)
            {
                map = new Dictionary<string, string>();
            }
            map.Add("access_id", secretId);
            string path = HttpUtil.GetPath(url, map);
            string signature = HmacUtil.Encode(path, secretKey);
            map.Add("_signature", signature);
            return map;
        }
    }
}
