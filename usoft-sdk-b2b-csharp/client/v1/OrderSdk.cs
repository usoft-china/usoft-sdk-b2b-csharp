
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
    /// 订单买家SDK
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
        /// 保存买家ERP主动回复的记录到平台
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SavePurchaseReplyList(List<PurchaseReply> data)
        {
            string url = baseUrl + "/erp/purchase/reply";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", JsonUtil.ToJSON(data));
            HttpUtil.DoPost(url, fromData, timeout);
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
        /// <summary>
        /// 买家结案、反结案采购单后，传到平台
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void UpdatePurchaseDetailEnd(List<PurchaseDetailEnd> data)
        {
            string url = baseUrl + "/erp/purchase/end";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", JsonUtil.ToJSON(data));
            HttpUtil.DoPost(url, fromData, timeout);
        }
        /// <summary>
        /// 买家ERP获取平台的打印状态
        /// </summary>
        /// <returns></returns>
        public List<MessageLog> GetMessageLogList()
        {
            string url = baseUrl + "/erp/purchase/print";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            List<MessageLog> result = JsonUtil.ToObject<List<MessageLog>>(respJson);
            return result;
        }
        /// <summary>
        /// 平台的打印记录传到ERP之后，修改平台里面的打印记录的传输状态
        /// </summary>
        /// <param name="idStr"></param>
        public void UpdateMessageLogStatus(string idStr)
        {
            string url = baseUrl + "/erp/purchase/print/back";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", idStr);
            HttpUtil.DoPost(url, fromData, timeout);
        }
        /// <summary>
        /// 将未上传的采购明细上传到平台
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SavePurchaseDetailList(List<PurchaseDetail> data)
        {
            string url = baseUrl + "/erp/purchase/item";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", JsonUtil.ToJSON(data));
            HttpUtil.DoPost(url, fromData, timeout);
        }
    }
}
