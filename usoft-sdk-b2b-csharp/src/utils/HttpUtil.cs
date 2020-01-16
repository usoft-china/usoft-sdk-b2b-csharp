﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.utils
{
    class HttpUtil
    {

        private static readonly HttpClient client = new HttpClient();

        public static string DoGet(string url, Dictionary<string, string> dic, int timeout)
        {
            return DoGet(GetPath(url, dic), timeout).Result;
        }

        /// <summary>
        /// 获取请求全路径
        /// </summary>
        /// <param name="url"></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static string GetPath(string url, Dictionary<string, string> dic)
        {
            String path = url;
            if (url != null && url.Length > 0 && dic != null && dic.Count > 0)
            {
                StringBuilder sb = new StringBuilder(url);
                sb.Append("?");
                foreach (KeyValuePair<string, string> kv in dic)
                {
                    sb.Append(kv.Key).Append("=").Append(kv.Value).Append("&");
                }
                path = sb.ToString().Substring(0, sb.ToString().Length - 1);
            }
            return path;
        }
        /// <summary>
        /// 发起GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout">超时时间，单位毫秒</param>
        /// <returns></returns>
        public static async Task<string> DoGet(string url, int timeout)
        {
            if (url == null || url.Length <= 0)
            {
                throw new Exception("url不能为空");
            }
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }

        /// <summary>
        /// 发起POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="dic"></param>
        /// <param name="timeout">超时时间，单位毫秒</param>
        /// <returns></returns>
        public static string DoPost(string url, Dictionary<string, string> dic, int timeout)
        {
            List<KeyValuePair<string, string>> keyValuePairs = new List<KeyValuePair<string, string>>();
            if (dic != null && dic.Count > 0)
            {
                foreach (KeyValuePair<string, string> kv in dic)
                {
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
        private static async Task<string> DoPostAsync(string url, HttpContent httpContent, int timeout)
        {
            if (url == null || url.Length <= 0)
            {
                throw new Exception("url不能为空");
            }
            client.Timeout = TimeSpan.FromMilliseconds(timeout);
            HttpResponseMessage response = await client.PostAsync(url, httpContent);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
