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
    public class OrderGetSdk : BaseSdk
    {
        public OrderGetSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public OrderGetSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }

        /// <summary>
        /// 分页查询买家采购订单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderResp pagingBuyerOrder(PagingBuyerOrderReq req)
        {
            string url = baseUrl + "/open/buyer/order/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderResp resp = JsonUtil.ToObject<PagingBuyerOrderResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家采购订单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerOrderDetailResp getBuyerOrderDetail(GetBuyerOrderDetailReq req)
        {
            string url = baseUrl + "/open/buyer/order/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerOrderDetailResp resp = JsonUtil.ToObject<GetBuyerOrderDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购变更单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderChgResp PagingBuyerOrderChg(PagingBuyerOrderChgReq req)
        {
            string url = baseUrl + "/open/buyer/order/chg/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderChgResp resp = JsonUtil.ToObject<PagingBuyerOrderChgResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家采购变更单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerOrderChgDetailResp GetBuyerOrderChgDetail(GetBuyerOrderChgDetailReq req)
        {
            string url = baseUrl + "/open/buyer/order/chg/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerOrderChgDetailResp resp = JsonUtil.ToObject<GetBuyerOrderChgDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询订单产品回复
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderProductReplyResp PagingBuyerOrderProductReply(PagingBuyerOrderProductReplyReq req)
        {
            string url = baseUrl + "/open/buyer/order/product/reply/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderProductReplyResp resp = JsonUtil.ToObject<PagingBuyerOrderProductReplyResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购发货提醒单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderRemindResp PagingBuyerOrderRemind(PagingBuyerOrderRemindReq req)
        {
            string url = baseUrl + "/open/buyer/order/remind/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderRemindResp resp = JsonUtil.ToObject<PagingBuyerOrderRemindResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购发货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderDeliveryResp PagingBuyerOrderDelivery(PagingBuyerOrderDeliveryReq req)
        {
            string url = baseUrl + "/open/buyer/order/delivery/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderDeliveryResp resp = JsonUtil.ToObject<PagingBuyerOrderDeliveryResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购收货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderReceiveResp PagingBuyerOrderReceive(PagingBuyerOrderReceiveReq req)
        {
            string url = baseUrl + "/open/buyer/order/receive/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderReceiveResp resp = JsonUtil.ToObject<PagingBuyerOrderReceiveResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购验收单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderAcceptResp PagingBuyerOrderAccept(PagingBuyerOrderAcceptReq req)
        {
            string url = baseUrl + "/open/buyer/order/accept/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderAcceptResp resp = JsonUtil.ToObject<PagingBuyerOrderAcceptResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家采购验退单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerOrderReturnResp PagingBuyerOrderReturn(PagingBuyerOrderReturnReq req)
        {
            string url = baseUrl + "/open/buyer/order/return/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerOrderReturnResp resp = JsonUtil.ToObject<PagingBuyerOrderReturnResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购订单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderResp PagingSellerOrder(PagingSellerOrderReq req)
        {
            string url = baseUrl + "/open/seller/order/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderResp resp = JsonUtil.ToObject<PagingSellerOrderResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询卖家采购订单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetSellerOrderDetailResp GetSellerOrderDetail(GetSellerOrderDetailReq req)
        {
            string url = baseUrl + "/open/seller/order/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetSellerOrderDetailResp resp = JsonUtil.ToObject<GetSellerOrderDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购变更单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderChgResp PagingSellerOrderChg(PagingSellerOrderChgReq req)
        {
            string url = baseUrl + "/open/seller/order/chg/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderChgResp resp = JsonUtil.ToObject<PagingSellerOrderChgResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询卖家采购变更单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetSellerOrderChgDetailResp GetSellerOrderChgDetail(GetSellerOrderChgDetailReq req)
        {
            string url = baseUrl + "/open/seller/order/chg/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetSellerOrderChgDetailResp resp = JsonUtil.ToObject<GetSellerOrderChgDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询订单产品回复
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderProductReplyResp PagingSellerOrderProductReply(PagingSellerOrderProductReplyReq req)
        {
            string url = baseUrl + "/open/seller/order/product/reply/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderProductReplyResp resp = JsonUtil.ToObject<PagingSellerOrderProductReplyResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购发货提醒单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderRemindResp PagingSellerOrderRemind(PagingSellerOrderRemindReq req)
        {
            string url = baseUrl + "/open/seller/order/remind/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderRemindResp resp = JsonUtil.ToObject<PagingSellerOrderRemindResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购发货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderDeliveryResp PagingSellerOrderDelivery(PagingSellerOrderDeliveryReq req)
        {
            string url = baseUrl + "/open/seller/order/delivery/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderDeliveryResp resp = JsonUtil.ToObject<PagingSellerOrderDeliveryResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购收货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderReceiveResp PagingSellerOrderReceive(PagingSellerOrderReceiveReq req)
        {
            string url = baseUrl + "/open/seller/order/receive/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderReceiveResp resp = JsonUtil.ToObject<PagingSellerOrderReceiveResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购验收单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderAcceptResp PagingSellerOrderAccept(PagingSellerOrderAcceptReq req)
        {
            string url = baseUrl + "/open/seller/order/accept/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderAcceptResp resp = JsonUtil.ToObject<PagingSellerOrderAcceptResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家采购验退单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerOrderReturnResp PagingSellerOrderReturn(PagingSellerOrderReturnReq req)
        {
            string url = baseUrl + "/open/seller/order/return/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerOrderReturnResp resp = JsonUtil.ToObject<PagingSellerOrderReturnResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量查询订单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchGetOrderDetailResp BatchGetOrderDetail(BatchGetOrderDetailReq req)
        {
            string url = baseUrl + "/open/order/detail/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchGetOrderDetailResp resp = JsonUtil.ToObject<BatchGetOrderDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量查询订单产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchGetOrderProductResp BatchGetOrderProduct(BatchGetOrderProductReq req)
        {
            string url = baseUrl + "/open/order/product/get/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchGetOrderProductResp resp = JsonUtil.ToObject<BatchGetOrderProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询采购发货提醒单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetOrderRemindDetailResp GetOrderRemindDetail(GetOrderRemindDetailReq req)
        {
            string url = baseUrl + "/open/order/remind/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetOrderRemindDetailResp resp = JsonUtil.ToObject<GetOrderRemindDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询采购发货单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetOrderDeliveryDetailResp GetOrderDeliveryDetail(GetOrderDeliveryDetailReq req)
        {
            string url = baseUrl + "/open/order/delivery/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetOrderDeliveryDetailResp resp = JsonUtil.ToObject<GetOrderDeliveryDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询采购收货单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetOrderReceiveDetailResp GetOrderReceiveDetail(GetOrderReceiveDetailReq req)
        {
            string url = baseUrl + "/open/order/receive/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetOrderReceiveDetailResp resp = JsonUtil.ToObject<GetOrderReceiveDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询采购验收单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetOrderAcceptDetailResp GetOrderAcceptDetail(GetOrderAcceptDetailReq req)
        {
            string url = baseUrl + "/open/order/accept/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetOrderAcceptDetailResp resp = JsonUtil.ToObject<GetOrderAcceptDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询采购验退单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetOrderReturnDetailResp GetOrderReturnDetail(GetOrderReturnDetailReq req)
        {
            string url = baseUrl + "/open/order/return/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetOrderReturnDetailResp resp = JsonUtil.ToObject<GetOrderReturnDetailResp>(respJson);
            return resp;
        }

    }
}
