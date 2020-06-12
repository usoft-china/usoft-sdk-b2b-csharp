using com.usoft.sdk.b2b.entity.v2.req;
using com.usoft.sdk.b2b.entity.v2.resp;
using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client.v2
{
    class InvoiceSdk : BaseSdk
    {
        public InvoiceSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey) {
        }

        public InvoiceSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout) {
        }

        /// <summary>
        /// 分页查询买家发票单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerInvoiceResp pagingBuyerInvoice(PagingBuyerInvoiceReq req)
        {
            string url = baseUrl + "/open/buyer/invoice/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerInvoiceResp resp = JsonUtil.ToObject<PagingBuyerInvoiceResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家发票单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerInvoiceDetailResp getBuyerInvoiceDetail(GetBuyerInvoiceDetailReq req)
        {
            string url = baseUrl + "/open/buyer/invoice/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerInvoiceDetailResp resp = JsonUtil.ToObject<GetBuyerInvoiceDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 开票
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public OpenInvoiceResp openInvoice(OpenInvoiceReq req)
        {
            string url = baseUrl + "/open/invoice/open";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            OpenInvoiceResp resp = JsonUtil.ToObject<OpenInvoiceResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家发票单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerInvoiceResp pagingSellerInvoice(PagingSellerInvoiceReq req)
        {
            string url = baseUrl + "/open/seller/invoice/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerInvoiceResp resp = JsonUtil.ToObject<PagingSellerInvoiceResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询卖家发票单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetSellerInvoiceDetailResp getSellerInvoiceDetail(GetSellerInvoiceDetailReq req)
        {
            string url = baseUrl + "/open/seller/invoice/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetSellerInvoiceDetailResp resp = JsonUtil.ToObject<GetSellerInvoiceDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量删除发票单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchDeleteInvoiceResp batchDeleteInvoice(BatchDeleteInvoiceReq req)
        {
            string url = baseUrl + "/open/invoice/delete/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchDeleteInvoiceResp resp = JsonUtil.ToObject<BatchDeleteInvoiceResp>(respJson);
            return resp;
        }
    }
}
