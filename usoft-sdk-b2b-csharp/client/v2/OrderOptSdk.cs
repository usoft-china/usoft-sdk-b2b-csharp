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
    public class OrderOptSdk : BaseSdk
    {
        public OrderOptSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public OrderOptSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }

        /// <summary>
        /// 新增采购订单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateOrderResp CreateOrder(CreateOrderReq req)
        {
            string url = baseUrl + "/open/order/create";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CreateOrderResp resp = JsonUtil.ToObject<CreateOrderResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 新增采购变更单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateOrderChgResp CreateOrderChg(CreateOrderChgReq req)
        {
            string url = baseUrl + "/open/order/chg/create";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CreateOrderChgResp resp = JsonUtil.ToObject<CreateOrderChgResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 新增采购发货提醒单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateOrderRemindResp CreateOrderRemind(CreateOrderRemindReq req)
        {
            string url = baseUrl + "/open/order/remind/create";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CreateOrderRemindResp resp = JsonUtil.ToObject<CreateOrderRemindResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 收货采购发货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ReceiveOrderDeliveryResp ReceiveOrderDelivery(ReceiveOrderDeliveryReq req)
        {
            string url = baseUrl + "/open/order/delivery/receive";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ReceiveOrderDeliveryResp resp = JsonUtil.ToObject<ReceiveOrderDeliveryResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 验收采购收货单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public AcceptOrderReceiveResp AcceptOrderReceive(AcceptOrderReceiveReq req)
        {
            string url = baseUrl + "/open/order/receive/accept";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            AcceptOrderReceiveResp resp = JsonUtil.ToObject<AcceptOrderReceiveResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 验退采购验收单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ReturnOrderAcceptResp ReturnOrderAccept(ReturnOrderAcceptReq req)
        {
            string url = baseUrl + "/open/order/accept/return";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ReturnOrderAcceptResp resp = JsonUtil.ToObject<ReturnOrderAcceptResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 订单结案（反结案）
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CloseOrderResp CloseOrder(CloseOrderReq req)
        {
            string url = baseUrl + "/open/order/close";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CloseOrderResp resp = JsonUtil.ToObject<CloseOrderResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 发货提醒单结案（反结案）
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CloseOrderRemindResp CloseOrderRemind(CloseOrderRemindReq req)
        {
            string url = baseUrl + "/open/order/remind/close";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CloseOrderRemindResp resp = JsonUtil.ToObject<CloseOrderRemindResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 回复采购变更单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ReplyOrderChgResp ReplyOrderChg(ReplyOrderChgReq req)
        {
            string url = baseUrl + "/open/order/chg/reply";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ReplyOrderChgResp resp = JsonUtil.ToObject<ReplyOrderChgResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 采购发货提醒单 发货
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public DeliverOrderRemindResp DeliverOrderRemind(DeliverOrderRemindReq req)
        {
            string url = baseUrl + "/open/order/remind/deliver";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            DeliverOrderRemindResp resp = JsonUtil.ToObject<DeliverOrderRemindResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 采购订单产品 确认或撤销回复
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ReplyOrderProductResp ReplyOrderProduct(ReplyOrderProductReq req)
        {
            string url = baseUrl + "/open/order/product/reply";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ReplyOrderProductResp resp = JsonUtil.ToObject<ReplyOrderProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 采购订单产品 批量回复
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchReplyOrderProductResp BatchReplyOrderProduct(BatchReplyOrderProductReq req)
        {
            string url = baseUrl + "/open/order/product/reply/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchReplyOrderProductResp resp = JsonUtil.ToObject<BatchReplyOrderProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量更新验收单产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchUpdateAcceptProductResp BatchUpdateAcceptProduct(BatchUpdateAcceptProductReq req)
        {
            string url = baseUrl + "/open/order/accept/product/update/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchUpdateAcceptProductResp resp = JsonUtil.ToObject<BatchUpdateAcceptProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量更新验退单产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchUpdateReturnProductResp BatchUpdateReturnProduct(BatchUpdateReturnProductReq req)
        {
            string url = baseUrl + "/open/order/return/product/update/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchUpdateReturnProductResp resp = JsonUtil.ToObject<BatchUpdateReturnProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量删除验收单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchDeleteOrderAcceptResp BatchDeleteOrderAccept(BatchDeleteOrderAcceptReq req)
        {
            string url = baseUrl + "/open/order/accept/delete/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchDeleteOrderAcceptResp resp = JsonUtil.ToObject<BatchDeleteOrderAcceptResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量删除验退单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchDeleteOrderReturnResp BatchDeleteOrderReturn(BatchDeleteOrderReturnReq req)
        {
            string url = baseUrl + "/open/order/return/delete/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchDeleteOrderReturnResp resp = JsonUtil.ToObject<BatchDeleteOrderReturnResp>(respJson);
            return resp;
        }
    }
}
