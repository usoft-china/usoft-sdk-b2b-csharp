using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils {
    class HttpUtil {

        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// 获取请求全路径
        /// </summary>
        /// <param name="url"></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static string GetPath(string url, Dictionary<string, string> dic) {
            string path = url;
            if (url != null && url.Length > 0 && dic != null && dic.Count > 0) {
                path = url + "?" + GetParamStr(dic);
            }
            return path;
        }
        /// <summary>
        /// 获取请求参数
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static string GetParamStr(Dictionary<string, string> dic) {
            string str = string.Empty;
            if (dic != null && dic.Count > 0) {
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<string, string> kv in dic) {
                    sb.Append(kv.Key).Append("=").Append(kv.Value).Append("&");
                }
                str = sb.ToString().Substring(0, sb.ToString().Length - 1);
            }
            return str;
        }

        public static string DoGet(string url, Dictionary<string, string> dic, int timeout) {
            return DoGet(GetPath(url, dic), timeout).Result;
        }

        /// <summary>
        /// 发起GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout">超时时间，单位毫秒</param>
        /// <returns></returns>
        public static async Task<string> DoGet(string url, int timeout) {
            if (url == null || url.Length <= 0) {
                throw new Exception("url不能为空");
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            httpClient.Timeout = TimeSpan.FromMilliseconds(timeout);
            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
        /// <summary>
        /// 发起POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="json"></param>
        /// <param name="timeout">超时时间，单位毫秒</param>
        /// <returns></returns>
        public static string DoPost(string url, string json, int timeout) {
            StringContent httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return DoPostAsync(url, httpContent, timeout).Result;
        }

        /// <summary>
        /// 发起POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dic"></param>
        /// <param name="timeout">超时时间，单位毫秒</param>
        /// <returns></returns>
        public static string DoPost(string url, Dictionary<string, string> dic, int timeout) {
            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            if (dic != null && dic.Count > 0) {
                foreach (KeyValuePair<string, string> kv in dic) {
                    keyValuePairs.Add(new KeyValuePair<string, string>(kv.Key, kv.Value));
                }
            }
            FormUrlEncodedContent httpContent = new FormUrlEncodedContent(keyValuePairs);
            return DoPostAsync(url, httpContent, timeout).Result;
        }

        /// <summary>
        /// 发起POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="httpContent"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        private static async Task<string> DoPostAsync(string url, HttpContent httpContent, int timeout) {
            if (url == null || url.Length <= 0) {
                throw new Exception("url不能为空");
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            httpClient.Timeout = TimeSpan.FromMilliseconds(timeout);
            //ExpectContinue必需为false,否则连接会被关闭
            //参考：c# - NET4.5中异步POST方法的HttpResponseMessage中的异常(https://www.ojit.com/article/1774331)
            //参考：HTTP之put/post请求头中的Expect:100-continue(https://blog.csdn.net/Swallow_he/article/details/94444766)
            httpClient.DefaultRequestHeaders.ExpectContinue = false;
            HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
