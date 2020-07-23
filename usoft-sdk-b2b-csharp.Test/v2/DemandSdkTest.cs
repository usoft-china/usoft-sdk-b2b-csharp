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
    public class DemandSdkTest
    {
        private readonly DemandSdk demandSdk = new DemandSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly DemandSdk demandSdk = new DemandSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c");

        [TestMethod]
        public void pagingBuyerInvoice()
        {
            CreateDemandReq req = new CreateDemandReq();
            req.category = 20;
            req.currency = "RMB";
            req.offerDeadline = "2020-05-09";
            ImportDemandProduct op1 = new ImportDemandProduct();
            op1.productModel = "Model1";
            op1.productBrand = "Brand1";
            op1.productName = "Name1";
            op1.productSpec = "Spec1";
            op1.quantity = 10;
            op1.unit = "KPCS";
            op1.offerDeadline = "2020-05-09";
            req.demandProduct.Add(op1);

            ImportDemandProduct op2 = new ImportDemandProduct();
            op2.productMaterialCode = "MaterialCode";
            op2.productModel = "Model2";
            op2.productBrand = "Brand2";
            op2.productName = "Name2";
            op2.productSpec = "Spec2";
            op2.quantity = 20;
            op2.offerDeadline = "2020-05-09";
            req.demandProduct.Add(op2);
            AttachFile file1 = new AttachFile();
            file1.code = "11200618246794932149";
            AttachFile file2 = new AttachFile();
            file2.url = "https://static.uuzcc.cn/appmall/12200604123893460688.jpg";
            file2.name = "测试.jpg";
            req.attachFile.Add(file1);
            req.attachFile.Add(file2);
            req.sourceId = "123";
            req.bizCode = "666666";
            req.demandTime = "2020-06-19 08:08:08";
            req.uu = 200040196;
            CreateDemandResp resp = demandSdk.createDemand(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingBuyerDemand()
        {
            PagingBuyerDemandReq req = new PagingBuyerDemandReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            PagingBuyerDemandResp resp = demandSdk.pagingBuyerDemand(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getBuyerDemandDetail()
        {
            GetBuyerDemandDetailReq req = new GetBuyerDemandDetailReq();
            req.code = "DD200619255039749100";
            GetBuyerDemandDetailResp resp = demandSdk.getBuyerDemandDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void replyDemandProductOffer()
        {
            ReplyDemandProductOfferReq req = new ReplyDemandProductOfferReq();
            req.demandProductOfferCode = "PO200509900506414803";
            req.category = 20;
            ReplyDemandProductOfferResp resp = demandSdk.replyDemandProductOffer(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getBuyerDemandList()
        {
            GetBuyerDemandListReq req = new GetBuyerDemandListReq();
            req.bizCode = "777777";
            GetBuyerDemandListResp resp = demandSdk.getBuyerDemandList(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerDemand()
        {
            PagingSellerDemandReq req = new PagingSellerDemandReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            PagingSellerDemandResp resp = demandSdk.pagingSellerDemand(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getSellerDemandDetail()
        {
            GetSellerDemandDetailReq req = new GetSellerDemandDetailReq();
            req.code = "DD200509900416450200";
            GetSellerDemandDetailResp resp = demandSdk.getSellerDemandDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void offerDemandProduct()
        {
            OfferDemandProductReq req = new OfferDemandProductReq();
            req.demandProductCode = "MP200619254984927037";
            req.demandProductOfferCode = "PO200619255294707203";
            req.deliveryTime = 1;
            req.taxRate = 1;
            req.mpq = 2;
            req.moq = 2;
            req.materialBrand = "MaterialBrand";
            req.materialCode = "MaterialCode";
            //		req.setAttachFileCode = "";
            req.uu = 200040196;
            LadderPrice ladderPrice = new LadderPrice();
            ladderPrice.start = 1;
            ladderPrice.price = 1.0;
            LadderPrice ladderPrice2 = new LadderPrice();
            ladderPrice2.start = 10;
            ladderPrice2.price = 10.0;
            req.ladderP.Add(ladderPrice);
            req.ladderP.Add(ladderPrice2);
            AttachFile file2 = new AttachFile();
            file2.url = "https://static.uuzcc.cn/appmall/12200604123893460688.jpg";
            file2.name = "test1.jpg";
            req.attachFile = file2;
            OfferDemandProductResp resp = demandSdk.offerDemandProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchInvalidDemandProduct()
        {
            BatchInvalidDemandProductReq req = new BatchInvalidDemandProductReq();
            req.code.Add("MP200619254984927037");
            req.code.Add("MP200619254984927238");
            BatchInvalidDemandProductResp resp = demandSdk.batchInvalidDemandProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
