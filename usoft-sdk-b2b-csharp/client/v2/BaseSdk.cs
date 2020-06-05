using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client.v2 {
    public class BaseSdk {
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
        /// <summary>
        /// 身份ID，Key
        /// </summary>
        private readonly string SECRET_ID_KEY = "secretId";

        public BaseSdk(string baseUrl, string secretId, string secretKey)
            : this(baseUrl, secretId, secretKey, DEFAULT_TIMEOUT) {

        }

        public BaseSdk(string baseUrl, string secretId, string secretKey, int timeout) {
            if (string.IsNullOrWhiteSpace(baseUrl)) {
                throw new Exception("baseUrl 不能为空");
            }
            if (string.IsNullOrWhiteSpace(secretId)) {
                throw new Exception("secretId 不能为空");
            }
            if (string.IsNullOrWhiteSpace(secretKey)) {
                throw new Exception("secretKey 不能为空");
            }
            this.baseUrl = baseUrl;
            this.secretId = secretId;
            this.secretKey = secretKey;
            this.timeout = timeout;
        }
        /// <summary>
        /// 实体 转换 字典 并签名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="req"></param>
        /// <returns></returns>
        protected Dictionary<string, string> GenSignToMap<T>(T req) {
            Dictionary<string, string> dic = ToDic(req);
            //统一设置身份ID
            if (dic.ContainsKey(SECRET_ID_KEY)) {
                //清空身份ID
                dic.Remove(SECRET_ID_KEY);
            }
            dic.Add(SECRET_ID_KEY, secretId);
            if (dic.ContainsKey(OpenApiSignUtil.SIGNATURE_KEY)) {
                //清空签名
                dic.Remove(OpenApiSignUtil.SIGNATURE_KEY);
            }
            string paramStr = HttpUtil.GetParamStr(dic);
            string signatureValue = OpenApiSignUtil.Sign(paramStr, secretKey);
            signatureValue = WebUtility.UrlEncode(signatureValue);
            //设置签名
            dic.Add(OpenApiSignUtil.SIGNATURE_KEY, signatureValue);
            return dic;
        }

        /// <summary>
        /// 实体 转换 字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="req"></param>
        /// <returns></returns>
        private Dictionary<string, string> ToDic<T>(T req) {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Type reqType = typeof(T);
            PropertyInfo[] propertyInfos = reqType.GetProperties();
            foreach (PropertyInfo propertyInfo in propertyInfos) {
                if (propertyInfo.PropertyType.IsArray || propertyInfo.PropertyType.IsEnum) {
                    continue;
                }
                object value = propertyInfo.GetValue(req);
                if (value == null) {
                    value = string.Empty;
                }
                dic.Add(propertyInfo.Name, value.ToString());
            }
            return dic;
        }

        /// <summary>
        /// 生成签名
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        protected string GenSignToJson<T>(T req) {
            Type reqType = typeof(T);
            PropertyInfo secretIdInfo = reqType.GetProperty(SECRET_ID_KEY);
            if (secretIdInfo != null) {
                secretIdInfo.SetValue(req, secretId);
            }
            PropertyInfo signatureInfo = reqType.GetProperty(OpenApiSignUtil.SIGNATURE_KEY);
            if (signatureInfo != null) {
                signatureInfo.SetValue(req, string.Empty);
            }
            string paramJson = JsonUtil.ToJSON(req);
            string signatureValue = OpenApiSignUtil.Sign(paramJson, secretKey);
            if (signatureInfo != null) {
                signatureInfo.SetValue(req, signatureValue);
            }
            return JsonUtil.ToJSON(req);
        }
    }
}
