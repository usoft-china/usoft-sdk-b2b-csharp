
using com.usoft.sdk.b2b.entity.order;
using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client
{
    /// <summary>
    /// 订单SDK
    /// </summary>
    public class OrderSdk : BaseSdk
    {
        public OrderSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public OrderSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }
        /// <summary>
        /// 将ERP的采购订单写到平台
        /// </summary>
        /// <param name="purchases"></param>
        /// <returns></returns>
        public List<Purchase> SavePurchaseList(List<Purchase> purchases)
        {
            string url = baseUrl + "/erp/purchase";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", JsonUtil.ToJSON(purchases));
            string respJson = HttpUtil.DoPost(url, fromData, timeout);
            List<Purchase> result = JsonUtil.ToObject<List<Purchase>>(respJson);
            return result;
        }
        /// <summary>
        /// 买家ERP获取平台的订单回复
        /// </summary>
        /// <returns></returns>
        public List<PurchaseReply> GetPurchaseReplyList()
        {
            string url = baseUrl + "/erp/purchase/reply";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            List<PurchaseReply> result = JsonUtil.ToObject<List<PurchaseReply>>(respJson);
            return result;
        }
        /// <summary>
        /// 平台的订单回复传到ERP之后，修改平台里面的回复记录的状态
        /// </summary>
        /// <param name="idStr"></param>
        public void UpdatePurchaseReplyStatus(string idStr)
        {
            string url = baseUrl + "/erp/purchase/reply/back";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", idStr);
            HttpUtil.DoPost(url, fromData, timeout);
        }
    }
}
