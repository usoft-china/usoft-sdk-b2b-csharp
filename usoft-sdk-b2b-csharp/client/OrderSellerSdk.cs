
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
    /// 订单卖家SDK
    /// </summary>
    public class OrderSellerSdk : BaseSdk
    {
        public OrderSellerSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public OrderSellerSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }

        /// <summary>
        /// 获取所有待上传到卖家erp的订单
        /// </summary>
        /// <returns></returns>
        public List<SaleDown> GetSaleDownList()
        {
            string url = baseUrl + "/erp/sale";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            List<SaleDown> result = JsonUtil.ToObject<List<SaleDown>>(respJson);
            return result;
        }

        /// <summary>
        /// 平台的订单传到卖方ERP之后，修改平台里面的订单的上传状态
        /// </summary>
        /// <param name="idStr"></param>
        public void UpdateSaleDownStatus(string idStr)
        {
            string url = baseUrl + "/erp/sale";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", idStr);
            HttpUtil.DoPost(url, fromData, timeout);
        }

        /// <summary>
        /// 卖家ERP从平台获取在平台回复的记录
        /// </summary>
        /// <returns></returns>
        public List<SaleReply> GetSaleReplyList()
        {
            string url = baseUrl + "/erp/sale/reply";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            List<SaleReply> result = JsonUtil.ToObject<List<SaleReply>>(respJson);
            return result;
        }

        /// <summary>
        /// 将卖家ERP的订单回复写到平台
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SaleReply(List<SaleReply> data)
        {
            string url = baseUrl + "/erp/sale/reply";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", JsonUtil.ToJSON(data));
            HttpUtil.DoPost(url, fromData, timeout);
        }
        /// <summary>
        /// 平台的回复记录传到供应商ERP之后，修改平台里面的回复记录的上传状态
        /// </summary>
        /// <param name="idStr"></param>
        public void UpdateSaleReplyStatus(string idStr)
        {
            string url = baseUrl + "/erp/sale/reply/back";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", idStr);
            HttpUtil.DoPost(url, fromData, timeout);
        }
        /// <summary>
        /// 卖家ERP从平台获取结案、反结案客户采购单
        /// </summary>
        /// <returns></returns>
        public List<SaleDownDetailEnd> GetSaleDownDetailEnd()
        {
            string url = baseUrl + "/erp/sale/end";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            List<SaleDownDetailEnd> result = JsonUtil.ToObject<List<SaleDownDetailEnd>>(respJson);
            return result;
        }
        /// <summary>
        /// 平台的结案、反结案客户采购单传到供应商ERP之后，修改平台里面的上传状态
        /// </summary>
        /// <param name="idStr"></param>
        public void UpdateSaleDownDetailEnd(string idStr)
        {
            string url = baseUrl + "/erp/sale/end/back";
            Dictionary<string, string> dic = GenerateSignature(url, null);
            url = HttpUtil.GetPath(url, dic);
            Dictionary<string, string> fromData = new Dictionary<string, string>(1);
            fromData.Add("data", idStr);
            HttpUtil.DoPost(url, fromData, timeout);
        }
    }
}
