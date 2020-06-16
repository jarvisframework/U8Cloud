using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 采购订单查询响应
    /// </summary>
    public class PurchaseinorderQueryResponse : U8CloudResponse
    {
        public DataDomain<BillVO> dataDomain { get; set; }

        public override void ParseData()
        {
            dataDomain = data.ToModel<DataDomain<BillVO>>();
        }

        /// <summary>
        /// 判断是否存在下一页
        /// </summary>
        /// <param name="pageNow"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public bool IsExistNextPage(int pageNow, int pageSize)
        {
            return (pageNow * pageSize) < dataDomain.allcount;
        }
        public class BillVO
        {
            /// <summary>
            /// 
            /// </summary>
            public ParentVO parentvo { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ChildrenVO> childrenvo { get; set; }

            public class ParentVO
            {
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_corp")]
                public string pkCorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string unitcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_name")]
                public string corpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string busicode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cbiztype_name")]
                public string cbiztypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cpurorganization { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cpurorganization_name")]
                public string cpurorganizationName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cdeptid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string deptcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cdept_name")]
                public string cdeptName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cgiveinvoicevendor { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string custcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cgiveinvoicevendor_name")]
                public string cgiveinvoicevendorName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cauditpsn { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("user_code")]
                public string userCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cauditpsn_name")]
                public string cauditpsnName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string coperator { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("coperator_name")]
                public string coperatorName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string corderid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dauditdate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dorderdate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string forderstatus { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vordercode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string nversion { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string taudittime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tlastmaketime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tmaketime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string breturn { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bsocooptome { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bislatest { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cvendormangid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cvendormang_name")]
                public string cvendormangName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bcooptoso { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bisreplenish { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cvendorbaseid { get; set; }
                /// <summary>
                /// 发件人
                /// </summary>
                [JsonProperty("vdef10")]
                public string senderName { get; set; }
                /// <summary>
                /// 发件人移动电话
                /// </summary>
                [JsonProperty("vdef11")]
                public string senderMobile { get; set; }
                /// <summary>
                /// 发件人省
                /// </summary>
                [JsonProperty("vdef12")]
                public string senderProvince { get; set; }
                /// <summary>
                /// 发件人市
                /// </summary>
                [JsonProperty("vdef13")]
                public string senderCity { get; set; }
                /// <summary>
                /// 发件人区
                /// </summary>
                [JsonProperty("vdef14")]
                public string senderArea { get; set; }
                /// <summary>
                /// 发件人详细地址  
                /// </summary>
                [JsonProperty("vdef15")]
                public string senderDetailAddress { get; set; }
            }

            public class ChildrenVO
            {
                /// <summary>
                /// 
                /// </summary>
                public string ccurrencytypeid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string termid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("ccurrencytype_name")]
                public string ccurrencytypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cmangid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string invcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cmang_name")]
                public string cmangName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string invtype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_invoicecorp")]
                public string pkInvoicecorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string unitcode { get; set; }
                /// <summary>
                /// 集辉股份有限公司
                /// </summary>
                [JsonProperty("invoicecorp_name")]
                public string invoicecorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_arrvcorp")]
                public string pkArrvcorp { get; set; }
                /// <summary>
                /// 集辉股份有限公司
                /// </summary>
                [JsonProperty("arrvcorp_name")]
                public string arrvcorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_reqcorp")]
                public string pkReqcorp { get; set; }
                /// <summary>
                /// 集辉股份有限公司
                /// </summary>
                [JsonProperty("reqcorp_name")]
                public string reqcorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string coperator { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("user_code")]
                public string userCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("coperate_name")]
                public string coperateName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_corp")]
                public string pkCorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_name")]
                public string corpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corder_bid")]
                public string corderBid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string corderid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string crowno { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int naccumarrvnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int naccumstorenum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int naccumwastnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nbackarrvnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nexchangeotobrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nmoney { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nordernum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal norgnettaxprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal norgtaxprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalnetprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginaltaxmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginaltaxpricemny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ntaxmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ntaxpricemny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ntaxrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ndiscountrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string iisreplenish { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string iisactive { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string idiscounttaxtype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string forderrowstatus { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbaseid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string breceiveplan { get; set; }
            }
        }
    }
}