using com.usoft.sdk.b2b.entity.product;
using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client
{
    /// <summary>
    /// 产品SDK
    /// </summary>
    public class ProductSdk : BaseSdk
    {
        public ProductSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public ProductSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }
        /// <summary>
        /// 定时任务更新物料信息
        /// </summary>
        /// <param name="products"></param>
        public void UpdateProducts(List<Product> products)
        {
            string url = baseUrl + "/product/cycleupdate";
            Dictionary<string, string> fromData = new Dictionary<string, string>(2);
            fromData.Add("data", JsonUtil.ToJSON(products));
            fromData.Add("enUU", secretId);
            HttpUtil.DoPost(url, fromData, timeout);
        }
    }
}
