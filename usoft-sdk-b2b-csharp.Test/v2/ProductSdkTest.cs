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

namespace usoft_sdk_b2b_csharp.Test.v2 {
    [TestClass]
    public class ProductSdkTest {
        private readonly ProductSdk productSdk = new ProductSdk("https://b2btraderest.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");
        //private readonly ProductSdk productSdk = new ProductSdk("http://127.0.0.1:27320", "10050624", "c49f7be6a861461ab951e55030055a5c");
        
        [TestMethod]
        public void CreateOrUpdateProduct() {
            CreateOrUpdateProductReq req = new CreateOrUpdateProductReq();
            CreateOrUpdateProduct product = new CreateOrUpdateProduct();
            product.code = "PD200526046405638900";
            product.materialCode = "mc";
            product.model = "model";
            product.brand = "brand";
            product.name = "name";
            product.spec = "spec";
            product.unit = "KPCS";
            product.mpq = 1;
            product.moq = 1;
            product.deliveryTime = 5;
            req.product = product;
            req.uu = 1000027480;
            CreateOrUpdateProductResp resp = productSdk.CreateOrUpdateProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void GetProduct() {
            GetProductReq req = new GetProductReq();
            req.code = "PD200526046405638900";
            GetProductResp resp = productSdk.GetProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void pagingProduct()
        {
            PagingProductReq req = new PagingProductReq();
            req.pageSize = 1;
            req.pageNumber = 10;
            PagingProductResp resp = productSdk.PagingProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void batchCreateOrUpdateProduct()
        {
            BatchCreateOrUpdateProductReq req = new BatchCreateOrUpdateProductReq();
            CreateOrUpdateProduct product = new CreateOrUpdateProduct();
            req.product = new List<CreateOrUpdateProduct>();
            product.code = "PD200526046405638900";
            product.materialCode = "mc2";
            product.model = "model2";
            product.brand = "brand2";
            product.name = "name2";
            product.spec = "spec2";
            product.unit = "KPCS2";
            product.mpq = 1;
            product.moq = 1;
            product.deliveryTime = 5;
            req.product.Add(product);
            req.uu = 1000027480;
            BatchCreateOrUpdateProductResp resp = productSdk.BatchCreateOrUpdateProduct(req);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }
    }
}
