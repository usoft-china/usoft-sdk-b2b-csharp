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
    public class InvoiceSdkTest
    {
        private readonly InvoiceSdk invoiceSdk = new InvoiceSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly ProductSdk productSdk = new ProductSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c");

        [TestMethod]
        public void pagingBuyerInvoice()
        {
            PagingBuyerInvoiceReq req = new PagingBuyerInvoiceReq();
            req.pageSize = 1;
            req.pageNumber = 10;
            PagingBuyerInvoiceResp resp = invoiceSdk.pagingBuyerInvoice(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }


        [TestMethod]
        public void getBuyerInvoiceDetail()
        {
            GetBuyerInvoiceDetailReq req = new GetBuyerInvoiceDetailReq();
            req.code = "TI200605135228880002";
            GetBuyerInvoiceDetailResp resp = invoiceSdk.getBuyerInvoiceDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingSellerInvoice()
        {
            PagingSellerInvoiceReq req = new PagingSellerInvoiceReq();
            req.pageNumber = 10;
            req.pageSize = 1;
            PagingSellerInvoiceResp resp = invoiceSdk.pagingSellerInvoice(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void getSellerInvoiceDetail()
        {
            GetSellerInvoiceDetailReq req = new GetSellerInvoiceDetailReq();
            req.code = "TI200605135228880002";
            GetSellerInvoiceDetailResp resp = invoiceSdk.getSellerInvoiceDetail(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void openInvoice()
        {
            OpenInvoiceReq req = new OpenInvoiceReq();
            OpenInvoiceProduct builder = new OpenInvoiceProduct();
            req.invoiceProduct = new List<OpenInvoiceProduct>();
            req.invCode = "InvCode";
            req.sellerEnuu = 10050624;
            req.uu = 200040196;
            req.currency = "RMB";
            req.paymentMethod = "现结";
            req.bizCode = "bizcode";
            builder.category = 10;
            builder.categoryCode = "AP200526047360616108";
            builder.orderProductCode = "OP200526046405685404";
            builder.unitPrice = 0.2;
            builder.taxRate = 0.2;
            req.invoiceProduct.Add(builder);
            OpenInvoiceResp resp = invoiceSdk.openInvoice(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchDeleteInvoice()
        {
            BatchDeleteInvoiceReq req = new BatchDeleteInvoiceReq();
            req.code = new List<string>();
            req.code.Add("InvCode");
            BatchDeleteInvoiceResp resp = invoiceSdk.batchDeleteInvoice(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
