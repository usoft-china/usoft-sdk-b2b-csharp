using com.usoft.sdk.b2b.entity.v2.req;
using com.usoft.sdk.b2b.entity.v2.resp;
using com.usoft.sdk.b2b.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.usoft.sdk.b2b.client.v2 {
    public class ProductSdk : BaseSdk {
        public ProductSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey) {
        }

        public ProductSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout) {
        }

        /// <summary>
        /// 新增或修改产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateOrUpdateProductResp CreateOrUpdateProduct(CreateOrUpdateProductReq req) {
            string url = baseUrl + "/open/product/createorupdate";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CreateOrUpdateProductResp resp = JsonUtil.ToObject<CreateOrUpdateProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 获取产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetProductResp GetProduct(GetProductReq req) {
            string url = baseUrl + "/open/product/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetProductResp resp = JsonUtil.ToObject<GetProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量新增或修改产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchCreateOrUpdateProductResp BatchCreateOrUpdateProduct(BatchCreateOrUpdateProductReq req)
        {
            string url = baseUrl + "/open/product/createorupdate/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchCreateOrUpdateProductResp resp = JsonUtil.ToObject<BatchCreateOrUpdateProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingProductResp PagingProduct(PagingProductReq req)
        {
            string url = baseUrl + "/open/product/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingProductResp resp = JsonUtil.ToObject<PagingProductResp>(respJson);
            return resp;
        }
    }
}
