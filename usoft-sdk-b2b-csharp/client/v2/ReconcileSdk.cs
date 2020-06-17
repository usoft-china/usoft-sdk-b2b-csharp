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
    public class ReconcileSdk : BaseSdk
    {
        public ReconcileSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey) {
        }

        public ReconcileSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout) {
        }

        /// <summary>
        /// 分页查询买家对账单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerReconcileResp pagingBuyerReconcile(PagingBuyerReconcileReq req)
        {
            string url = baseUrl + "/open/buyer/reconcile/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerReconcileResp resp = JsonUtil.ToObject<PagingBuyerReconcileResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家对账单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerReconcileDetailResp getBuyerReconcileDetail(GetBuyerReconcileDetailReq req)
        {
            string url = baseUrl + "/open/buyer/reconcile/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerReconcileDetailResp resp = JsonUtil.ToObject<GetBuyerReconcileDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 买家确认对账
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ConfirmBuyerReconcileResp confirmBuyerReconcile(ConfirmBuyerReconcileReq req)
        {
            string url = baseUrl + "/open/buyer/reconcile/confirm";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ConfirmBuyerReconcileResp resp = JsonUtil.ToObject<ConfirmBuyerReconcileResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家对账单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerReconcileResp pagingSellerReconcile(PagingSellerReconcileReq req)
        {
            string url = baseUrl + "/open/seller/reconcile/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerReconcileResp resp = JsonUtil.ToObject<PagingSellerReconcileResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询卖家对账单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetSellerReconcileDetailResp getSellerReconcileDetail(GetSellerReconcileDetailReq req)
        {
            string url = baseUrl + "/open/seller/reconcile/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetSellerReconcileDetailResp resp = JsonUtil.ToObject<GetSellerReconcileDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 卖家确认对账
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ConfirmSellerReconcileResp confirmSellerReconcile(ConfirmSellerReconcileReq req)
        {
            string url = baseUrl + "/open/seller/reconcile/confirm";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ConfirmSellerReconcileResp resp = JsonUtil.ToObject<ConfirmSellerReconcileResp>(respJson);
            return resp;
        }

    }
}
