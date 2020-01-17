using com.usoft.sdk.b2b.client;
using com.usoft.sdk.b2b.entity.product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoft_sdk_b2b_csharp.Test
{
    [TestClass]
    public class ProductSdkTest
    {
        private readonly ProductSdk productSdk = new ProductSdk("http://test-product.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");

        [TestMethod]
        public void UpdateProducts()
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.pr_id = 1236;
            product.pr_code = "PdProdcode3";
            product.pr_detail = "PrDetail3";
            product.pr_enuu = 10050624;
            products.Add(product);
            productSdk.UpdateProducts(products);

        }
    }
}
