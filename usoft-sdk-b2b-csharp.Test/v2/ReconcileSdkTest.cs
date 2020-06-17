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
    public class ReconcileSdkTest
    {
        private readonly ReconcileSdk reconcileSdk = new ReconcileSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly ReconcileSdk reconcileSdk = new ReconcileSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c");

        [TestMethod]
        public void pagingBuyerReconcile()
        {
            PagingBuyerReconcileReq req = new PagingBuyerReconcileReq();
            req.pageSize = 1;
            req.pageNumber = 10;
            PagingBuyerReconcileResp resp = reconcileSdk.pagingBuyerReconcile(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getBuyerReconcileDetail()
        {
            GetBuyerReconcileDetailReq req = new GetBuyerReconcileDetailReq();
            req.code = "TR200526047454719711";
            GetBuyerReconcileDetailResp resp = reconcileSdk.getBuyerReconcileDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void confirmBuyerReconcile()
        {
            ConfirmBuyerReconcileReq req = new ConfirmBuyerReconcileReq();
            req.reconcileCode = "TR200617235885919601";
            req.status = 20;
            req.uu = 200040196;
            ConfirmBuyerReconcileResp resp = reconcileSdk.confirmBuyerReconcile(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerReconcile()
        {
            PagingSellerReconcileReq req = new PagingSellerReconcileReq();
            req.pageSize = 1;
            req.pageNumber = 10;
            PagingSellerReconcileResp resp = reconcileSdk.pagingSellerReconcile(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getSellerReconcileDetail()
        {
            GetSellerReconcileDetailReq req = new GetSellerReconcileDetailReq();
            req.code = "TR200526047454719711";
            GetSellerReconcileDetailResp resp = reconcileSdk.getSellerReconcileDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void confirmSellerReconcile()
        {
            ConfirmSellerReconcileReq req = new ConfirmSellerReconcileReq();
            ConfirmSellerReconcileProduct builder = new ConfirmSellerReconcileProduct();
            builder.category = 10;
            builder.categoryCode = "AP200616229560001108";
            builder.ordinal = 1;
            req.startTime = "2020-03-09 16:14:56";
            req.endTime = "2020-07-09 16:14:56";
            req.uu = 200040196;
            req.reconcileProduct = new List<ConfirmSellerReconcileProduct>();
            req.reconcileProduct.Add(builder);
            ConfirmSellerReconcileResp resp = reconcileSdk.confirmSellerReconcile(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
