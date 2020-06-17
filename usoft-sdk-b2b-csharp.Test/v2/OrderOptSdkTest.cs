using com.usoft.sdk.b2b.client.v2;
using com.usoft.sdk.b2b.entity.v2;
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
    public class OrderOptSdkTest
    {
        private readonly OrderOptSdk orderOptSdk = new OrderOptSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly OrderOptSdk orderOptSdk = new OrderOptSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c";
        [TestMethod]
        public void createOrder()
        {
            CreateOrderReq req = new CreateOrderReq();
            req.uu = 200040196;
            req.sellerEnuu = 10050624;
            req.sellerLinkmanUu = 1000027480;
            req.category = 10;
            req.paymentMethod = "现结";
            req.currency = "RMB";
    //		req.exchangeRate = 1.1;
            req.remark = "Remarksd中";
            DeliveryAddr deliveryAddr = new DeliveryAddr();
            deliveryAddr.code = "DA200226268678882100";
            req.deliveryAddr = deliveryAddr;
            CreateOrderResp resp = orderOptSdk.createOrder(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void createOrderChg()
        {
            CreateOrderChgReq req = new CreateOrderChgReq();
            req.orderCode = "OR200616229460235201";
            req.category = 10;
            req.paymentMethod = "月结30天";
            req.currency = "RMB";
            req.exchangeRate = 2.2;
            req.isSellerConfirm = true;
            req.remark = "Remarksd中";
            //		req.processStart = "2020-03-16";
            //		req.processEnd = "2020-04-16";
            //		req.outsourceType = "OutsourceTypeDss";
            //		req.deliveryFactory = "DeliveryFactoryDsdf";

            CreateOrderChgProduct op1 = new CreateOrderChgProduct();
            op1.orderProductCode = "OP200616229460235502";
            op1.unitPrice = 0.3;
            op1.taxRate = 0.3;
            op1.quantity = 30;
            op1.unit = "KPCS";
            op1.deliveryTime = "2020-07-15";
            req.orderChgProduct = new List<CreateOrderChgProduct>();
            req.orderChgProduct.Add(op1);
            req.uu = 200040196;
            CreateOrderChgResp resp = orderOptSdk.createOrderChg(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void createOrderRemind()
        {
            CreateOrderRemindReq req = new CreateOrderRemindReq();

            RemindOrderProduct rop = new RemindOrderProduct();
            rop.orderProductCode = "OP200616229460235502";
            rop.quantityRemind = 5;
            req.remindOP = new List<RemindOrderProduct>();
            req.remindOP.Add(rop);
            req.uu = 200040196;
            CreateOrderRemindResp resp = orderOptSdk.createOrderRemind(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void receiveOrderDelivery()
        {
            ReceiveOrderDeliveryReq req = new ReceiveOrderDeliveryReq();
            ReceiveOrderDeliveryProduct rodp = new ReceiveOrderDeliveryProduct();
            rodp.orderDeliveryProductCode = "DP200616229549287104";
            rodp.quantityReceive = 5;
            req.receiveODP = new List<ReceiveOrderDeliveryProduct>();
            req.receiveODP.Add(rodp);
            req.uu = 200040196;
            ReceiveOrderDeliveryResp resp = orderOptSdk.receiveOrderDelivery(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void acceptOrderReceive()
        {
            AcceptOrderReceiveReq req = new AcceptOrderReceiveReq();
            AcceptOrderReceiveProduct acceptORP = new AcceptOrderReceiveProduct();
            acceptORP.orderReceiveProductCode = "VP200616229554312806";
            acceptORP.quantityAccept = 5;
            req.acceptORP = new List<AcceptOrderReceiveProduct>();
            req.acceptORP.Add(acceptORP);
            req.uu = 200040196;
            AcceptOrderReceiveResp resp = orderOptSdk.acceptOrderReceive(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void returnOrderAccept()
        {
            ReturnOrderAcceptReq req = new ReturnOrderAcceptReq();
            ReturnOrderAcceptProduct returnOAP = new ReturnOrderAcceptProduct();
            returnOAP.orderAcceptProductCode = "AP200616229560001108";
            returnOAP.quantityReturn = 2;
            req.returnOAP = new List<ReturnOrderAcceptProduct>();
            req.returnOAP.Add(returnOAP);
            req.uu = 200040196;
            ReturnOrderAcceptResp resp = orderOptSdk.returnOrderAccept(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void closeOrder()
        {
            CloseOrderReq req = new CloseOrderReq();
            req.orderProductCode = new List<string>();
            req.orderProductCode.Add("");
            req.uu = 200040196;
            CloseOrderResp resp = orderOptSdk.closeOrder(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void closeOrderRemind()
        {
            CloseOrderRemindReq req = new CloseOrderRemindReq();
            req.orderRemindProductCode = new List<string>();
            req.orderRemindProductCode.Add("");
            req.uu = 200040196;
            CloseOrderRemindResp resp = orderOptSdk.closeOrderRemind(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void replyOrderChg()
        {
            ReplyOrderChgReq req = new ReplyOrderChgReq();
            req.orderChgCode = "CO200526046475222302";
            req.replyRemark = "ReplyRemarksd";
            req.replyStatus = 10;
            ReplyOrderChgResp resp = orderOptSdk.replyOrderChg(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void deliverOrderRemind()
        {
            DeliverOrderRemindReq req = new DeliverOrderRemindReq();
            DeliveryOrderRemindProduct dorp = new DeliveryOrderRemindProduct();
            dorp.orderRemindProductCode = "RP200616229527104201";
            dorp.quantityDelivery = 5;
            req.deliveryORP = new List<DeliveryOrderRemindProduct>();
            req.deliveryORP.Add(dorp);
            req.uu = 200040196;
            DeliverOrderRemindResp resp = orderOptSdk.deliverOrderRemind(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void replyOrderProduct()
        {
            ReplyOrderProductReq req = new ReplyOrderProductReq();
            ReplyOrderProductContent builder = new ReplyOrderProductContent();
            req.category = 1;
            builder.orderProductCode = "OP200616229460249003";
            builder.quantity = 10;
            builder.deliveryTime = "2020-07-18";
            builder.remark = "测试";
            req.replyContent = builder;
            req.uu = 200040196;
            ReplyOrderProductResp resp = orderOptSdk.replyOrderProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchReplyOrderProduct()
        {
            BatchReplyOrderProductReq req = new BatchReplyOrderProductReq();
            ReplyOrderProductContent builder = new ReplyOrderProductContent();
            req.category = 10;
            builder.orderProductCode = "OP200526046405671403";
            builder.quantity = 10;
            builder.deliveryTime = "2020-05-18";
            builder.remark = "测试";
            req.uu = 200040196;
            req.replyContent = new List<ReplyOrderProductContent>();
            req.replyContent.Add(builder);
            BatchReplyOrderProductResp resp = orderOptSdk.batchReplyOrderProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchUpdateAcceptProduct()
        {
            BatchUpdateAcceptProductReq req = new BatchUpdateAcceptProductReq();
            UpdateReq builder = new UpdateReq();
            builder.code = "AP200616229151040746";
            builder.taxRate = 1;
            builder.unitPrice = 20;
            req.updateReq = new List<UpdateReq>();
            req.updateReq.Add(builder);
            BatchUpdateAcceptProductResp resp = orderOptSdk.batchUpdateAcceptProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchUpdateReturnProduct()
        {
            BatchUpdateReturnProductReq req = new BatchUpdateReturnProductReq();
            UpdateReq builder = new UpdateReq();
            builder.code = "OP200526046405671403";
            builder.taxRate = 1;
            builder.unitPrice = 1;
            req.updateReq = new List<UpdateReq>();
            req.updateReq.Add(builder);
            BatchUpdateReturnProductResp resp = orderOptSdk.batchUpdateReturnProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchDeleteOrderAccept()
        {
            BatchDeleteOrderAcceptReq req = new BatchDeleteOrderAcceptReq();
            req.code = new List<string>();
            req.code.Add("OA200616229559969107");
            BatchDeleteOrderAcceptResp resp = orderOptSdk.batchDeleteOrderAccept(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchDeleteOrderReturn()
        {
            BatchDeleteOrderReturnReq req = new BatchDeleteOrderReturnReq();
            req.code = new List<string>();
            req.code.Add("OT200616229641056523");
            BatchDeleteOrderReturnResp resp = orderOptSdk.batchDeleteOrderReturn(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
