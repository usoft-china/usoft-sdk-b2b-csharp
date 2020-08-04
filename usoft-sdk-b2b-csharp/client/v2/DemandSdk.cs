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
    public class DemandSdk : BaseSdk
    {
        public DemandSdk(string baseUrl, string secretId, string secretKey) : base(baseUrl, secretId, secretKey)
        {
        }

        public DemandSdk(string baseUrl, string secretId, string secretKey, int timeout) : base(baseUrl, secretId, secretKey, timeout)
        {
        }

        /// <summary>
        /// 新增询价单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public CreateDemandResp CreateDemand(CreateDemandReq req)
        {
            string url = baseUrl + "/open/demand/create";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            CreateDemandResp resp = JsonUtil.ToObject<CreateDemandResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询买家询价单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingBuyerDemandResp PagingBuyerDemand(PagingBuyerDemandReq req)
        {
            string url = baseUrl + "/open/buyer/demand/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingBuyerDemandResp resp = JsonUtil.ToObject<PagingBuyerDemandResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家询价单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerDemandDetailResp GetBuyerDemandDetail(GetBuyerDemandDetailReq req)
        {
            string url = baseUrl + "/open/buyer/demand/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerDemandDetailResp resp = JsonUtil.ToObject<GetBuyerDemandDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 回复询价单产品报价 采纳或拒绝
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public ReplyDemandProductOfferResp ReplyDemandProductOffer(ReplyDemandProductOfferReq req)
        {
            string url = baseUrl + "/open/demand/product/offer/reply";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            ReplyDemandProductOfferResp resp = JsonUtil.ToObject<ReplyDemandProductOfferResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询买家询价单详情列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetBuyerDemandListResp GetBuyerDemandList(GetBuyerDemandListReq req)
        {
            string url = baseUrl + "/open/buyer/demand/list/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetBuyerDemandListResp resp = JsonUtil.ToObject<GetBuyerDemandListResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 分页查询卖家询价单
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public PagingSellerDemandResp PagingSellerDemand(PagingSellerDemandReq req)
        {
            string url = baseUrl + "/open/seller/demand/paging";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            PagingSellerDemandResp resp = JsonUtil.ToObject<PagingSellerDemandResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 查询卖家询价单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public GetSellerDemandDetailResp GetSellerDemandDetail(GetSellerDemandDetailReq req)
        {
            string url = baseUrl + "/open/seller/demand/detail/get";
            Dictionary<string, string> dic = GenSignToMap(req);
            string respJson = HttpUtil.DoGet(url, dic, timeout);
            GetSellerDemandDetailResp resp = JsonUtil.ToObject<GetSellerDemandDetailResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 询价单产品报价与修改
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public OfferDemandProductResp OfferDemandProduct(OfferDemandProductReq req)
        {
            string url = baseUrl + "/open/demand/product/offer";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            OfferDemandProductResp resp = JsonUtil.ToObject<OfferDemandProductResp>(respJson);
            return resp;
        }

        /// <summary>
        /// 批量失效询价单产品
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public BatchInvalidDemandProductResp BatchInvalidDemandProduct(BatchInvalidDemandProductReq req)
        {
            string url = baseUrl + "/open/demand/product/invalid/batch";
            string paramJson = GenSignToJson(req);
            string respJson = HttpUtil.DoPost(url, paramJson, timeout);
            BatchInvalidDemandProductResp resp = JsonUtil.ToObject<BatchInvalidDemandProductResp>(respJson);
            return resp;
        }
    }
}
