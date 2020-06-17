using com.usoft.sdk.b2b.client.v2;
using com.usoft.sdk.b2b.entity.v2.req;
using com.usoft.sdk.b2b.entity.v2.resp;
using com.usoft.sdk.b2b.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoft_sdk_b2b_csharp.Test.v2
{
    [TestClass]
    public class OrderGetSdkTest
    {
        private readonly OrderGetSdk orderGetSdk = new OrderGetSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly OrderGetSdk orderGetSdk = new OrderGetSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c";

        [TestMethod]
        public void pagingBuyerOrder()
        {
            PagingBuyerOrderReq req = new PagingBuyerOrderReq();
            req.pageSize = 1;
            req.pageNumber = 10;
            PagingBuyerOrderResp resp = orderGetSdk.pagingBuyerOrder(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }


        [TestMethod]
        public void getBuyerOrderDetail()
        {
            GetBuyerOrderDetailReq req = new GetBuyerOrderDetailReq();
            req.orderCode = "OR200526046405671102";
            GetBuyerOrderDetailResp resp = orderGetSdk.getBuyerOrderDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderChg()
        {
            PagingBuyerOrderChgReq req = new PagingBuyerOrderChgReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderChgResp resp = orderGetSdk.pagingBuyerOrderChg(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getBuyerOrderChgDetail()
        {
            GetBuyerOrderChgDetailReq req = new GetBuyerOrderChgDetailReq();
            req.code = "CO200526046475222302";
            GetBuyerOrderChgDetailResp resp = orderGetSdk.getBuyerOrderChgDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderRemind()
        {
            PagingBuyerOrderRemindReq req = new PagingBuyerOrderRemindReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderRemindResp resp = orderGetSdk.pagingBuyerOrderRemind(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderDelivery()
        {
            PagingBuyerOrderDeliveryReq req = new PagingBuyerOrderDeliveryReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderDeliveryResp resp = orderGetSdk.pagingBuyerOrderDelivery(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderReceive()
        {
            PagingBuyerOrderReceiveReq req = new PagingBuyerOrderReceiveReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderReceiveResp resp = orderGetSdk.pagingBuyerOrderReceive(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderAccept()
        {
            PagingBuyerOrderAcceptReq req = new PagingBuyerOrderAcceptReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderAcceptResp resp = orderGetSdk.pagingBuyerOrderAccept(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerOrderReturn()
        {
            PagingBuyerOrderReturnReq req = new PagingBuyerOrderReturnReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingBuyerOrderReturnResp resp = orderGetSdk.pagingBuyerOrderReturn(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }



        [TestMethod]
        public void pagingSellerOrder()
        {
            PagingSellerOrderReq req = new PagingSellerOrderReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderResp resp = orderGetSdk.pagingSellerOrder(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getSellerOrderDetail()
        {
            GetSellerOrderDetailReq req = new GetSellerOrderDetailReq();
            req.orderCode = "OR200526046405671102";
            GetSellerOrderDetailResp resp = orderGetSdk.getSellerOrderDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderChg()
        {
            PagingSellerOrderChgReq req = new PagingSellerOrderChgReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderChgResp resp = orderGetSdk.pagingSellerOrderChg(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getSellerOrderChgDetail()
        {
            GetSellerOrderChgDetailReq req = new GetSellerOrderChgDetailReq();
            req.code = "CO200526046475222302";
            GetSellerOrderChgDetailResp resp = orderGetSdk.getSellerOrderChgDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderRemind()
        {
            PagingSellerOrderRemindReq req = new PagingSellerOrderRemindReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderRemindResp resp = orderGetSdk.pagingSellerOrderRemind(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderDelivery()
        {
            PagingSellerOrderDeliveryReq req = new PagingSellerOrderDeliveryReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderDeliveryResp resp = orderGetSdk.pagingSellerOrderDelivery(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderReceive()
        {
            PagingSellerOrderReceiveReq req = new PagingSellerOrderReceiveReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderReceiveResp resp = orderGetSdk.pagingSellerOrderReceive(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderAccept()
        {
            PagingSellerOrderAcceptReq req = new PagingSellerOrderAcceptReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderAcceptResp resp = orderGetSdk.pagingSellerOrderAccept(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerOrderReturn()
        {
            PagingSellerOrderReturnReq req = new PagingSellerOrderReturnReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            req.keywords = "wc";
            req.startTime = "2020-03-24";
            req.endTime = "2020-07-24";
            PagingSellerOrderReturnResp resp = orderGetSdk.pagingSellerOrderReturn(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchGetOrderDetail()
        {
            BatchGetOrderDetailReq req = new BatchGetOrderDetailReq();
            req.code = new List<string>();
            req.code.Add("OR200508892251984128");
            req.code.Add("OR200506875276648009");
            BatchGetOrderDetailResp resp = orderGetSdk.batchGetOrderDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchGetOrderProduct()
        {
            BatchGetOrderProductReq req = new BatchGetOrderProductReq();
            req.code = new List<string>();
            req.code.Add("OR200508892251984128");
            req.code.Add("OR200506875276648009");
            BatchGetOrderProductResp resp = orderGetSdk.batchGetOrderProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getOrderRemindDetail()
        {
            GetOrderRemindDetailReq req = new GetOrderRemindDetailReq();
            req.orderRemindCode = "OR200508892251984128";
            GetOrderRemindDetailResp resp = orderGetSdk.getOrderRemindDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getOrderDeliveryDetail()
        {
            GetOrderDeliveryDetailReq req = new GetOrderDeliveryDetailReq();
            req.orderDeliveryCode = "OR200508892251984128";
            GetOrderDeliveryDetailResp resp = orderGetSdk.getOrderDeliveryDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getOrderReceiveDetail()
        {
            GetOrderReceiveDetailReq req = new GetOrderReceiveDetailReq();
            req.orderReceiveCode = "OR200508892251984128";
            GetOrderReceiveDetailResp resp = orderGetSdk.getOrderReceiveDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getOrderAcceptDetail()
        {
            GetOrderAcceptDetailReq req = new GetOrderAcceptDetailReq();
            req.orderAcceptCode = "OR200508892251984128";
            GetOrderAcceptDetailResp resp = orderGetSdk.getOrderAcceptDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getOrderReturnDetail()
        {
            GetOrderReturnDetailReq req = new GetOrderReturnDetailReq();
            req.orderReturnCode = "OR200508892251984128";
            GetOrderReturnDetailResp resp = orderGetSdk.getOrderReturnDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
