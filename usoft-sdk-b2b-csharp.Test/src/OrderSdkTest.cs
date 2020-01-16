
using com.usoft.sdk.b2b.client;
using com.usoft.sdk.b2b.entity.order;
using com.usoft.sdk.b2b.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usoft_sdk_b2b_csharp.Test
{
    [TestClass]
    public class OrderSdkTest
    {
        //private readonly OrderSdk orderSdk = new OrderSdk("http://test-b2b.uuzcc.cn", "10041559", "2c1ea089876b796fe050007f01002ea6");
        private readonly OrderSdk orderSdk = new OrderSdk("http://test-b2b.uuzcc.cn", "10050624", "c49f7be6a861461ab951e55030055a5c");

        [TestMethod]
        public void SavePurchaseList()
        {
            List<Purchase> purchases = new List<Purchase>();
            Purchase purchase = new Purchase();
            //订单基本信息
            int random = new Random().Next(100000000);
            purchase.pu_code = "PuCode" + random;//采购单号
            //		purchase.PuDate(DateUtil.getCurrentDate="yyyy/MM/dd"));  //单据归属日期(yyyy-MM-dd HH:mm:ss)
            purchase.pu_date = GetCurrentTimeUnix();//+""  "2020/01/15"
            purchase.em_uu = 1000027480;  //ERP单据中采购员UU号
            purchase.em_name = "EmName";  //ERP单据中采购员姓名
            purchase.em_sex = "男";  //ERP单据中采购员性别
            purchase.em_mobile = "13611111111";  //ERP单据中采购员电话
            purchase.em_email = "ememail@email.com";  //ERP单据中采购员邮箱
            purchase.ve_uu = 10050624;  //供应商uu
            purchase.pu_cop = "PuCop";  //客户公司名称
            purchase.ve_contactuu = 1000027480;  //ERP中单据供应商联系人UU
            purchase.pu_currency = "RMB";//付款币种(RMB USD)
            purchase.pu_rate = 1;  //汇率
            purchase.pu_kind = "一般请购";  // 采购类型
            purchase.pu_payments = "月结30天";//付款方式
            purchase.pu_remark = "PuRemark";  //备注
            purchase.pu_recordman = "张三";  //录单人
            purchase.pu_auditman = "李四";  //审核人
            purchase.pu_shipaddresscode = "福建省漳州市南靖县万利达工业园B栋 王五收 手机:13611111111";  //收货地址
            purchase.pu_receivename = "深圳市XXX电子有限公司";  //应付供应商名称
            purchase.pu_receivecode = "1017";  //应付供应商编号
            purchase.pu_id = random;  //在ERP中采购单的id

            List<PurchaseDetail> details = new List<PurchaseDetail>();
            //订单明细
            PurchaseDetail detail = new PurchaseDetail();
            detail.pd_code = "PuCode" + random; //采购单号
            detail.pd_prodcode = "PdProdcode"; //物料编号   PdProdcode
            detail.pd_qty = 10; //采购数量
            detail.pd_price = 10.0; //单价
            //		detail.PdDelivery(DateUtil.getCurrentDate="yyyy/MM/dd")); //交货日期DateUtil.getCurrentDate(DateUtil.PATTERN_DATE_TIME)
            detail.pd_delivery = GetCurrentTimeUnix(); //交货日期
            detail.pd_remark = "PdRemark"; //备注
            detail.pd_rate = 0.01f; //税率
            detail.pd_detno = 1; //序号
            detail.pd_vendspec = "PdVendspec"; //供应商规格
            detail.pd_purcvendname = "PdPurcvendname"; //终端供应商名称
            details.Add(detail);

            purchase.purchaseDetails = details;
            purchases.Add(purchase);
            List<Purchase> resp = orderSdk.SavePurchaseList(purchases);
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void GetPurchaseReplyList()
        {
            List<PurchaseReply> resp = orderSdk.GetPurchaseReplyList();
            Console.WriteLine(JsonUtil.ToJSON(resp));
        }

        [TestMethod]
        public void UpdatePurchaseReplyStatus()
        {
            orderSdk.UpdatePurchaseReplyStatus("123");
        }



        private long GetCurrentTimeUnix()
        {
            TimeSpan cha = (DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)));
            long t = (long)cha.TotalMilliseconds;
            return t;
        }
     
    }
}
