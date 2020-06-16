using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Response
{
    /// <summary>
    /// 到货单查询响应
    /// </summary>
    public class ArriveorderQueryResponse : U8CloudResponse
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
                public string bisback { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string caccountyear { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string carriveorderid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbilltype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("biztype_code")]
                public string biztypeCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("biztype_name")]
                public string biztypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cdeptid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("dept_code")]
                public string deptCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("dept_name")]
                public string deptName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cemployeeid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("employee_code")]
                public string employeeCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("employee_name")]
                public string employeeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string coperator { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("operator_code")]
                public string operatorCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("operator_name")]
                public string operatorName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cstoreorganization { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("calbody_code")]
                public string calbodyCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("calbody_name")]
                public string calbodyName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cvendorbaseid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cvendormangid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("provider_code")]
                public string providerCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("provider_name")]
                public string providerName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dreceivedate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ibillstatus { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string iprintcount { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pkCorp")]
                public string pk_corp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_code")]
                public string corpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_name")]
                public string corpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_purcorp")]
                public string pkPurcorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("purcorp_code")]
                public string purcorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("purcorp_name")]
                public string purcorpName { get; set; }
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
                public string ts { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string varrordercode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vbackreasonh { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vmemo { get; set; }
            }

            public class ChildrenVO
            {
                /// <summary>
                /// 
                /// </summary>
                public string bfaflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string blargess { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string blargessuprow { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string carriveorderid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbaseid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ccurrencytypeid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("currencytype_code")]
                public string currencytypeCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("currencytype_name")]
                public string currencytypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cmangid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("inventory_code")]
                public string inventoryCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("inventory_name")]
                public string inventoryName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string invtype { get; set; }
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
                public string csourcebillid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csourcebillrowid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csourcebilltype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cupsourcebillid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cupsourcebillrowid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cupsourcebilltype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ivalidday { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int naccumchecknum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int narrvnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nelignum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nmoney { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nnotelignum { get; set; }
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
                public int nplanarrvnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int npresentnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nwastnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_corp")]
                public string pkCorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_code")]
                public string corpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corp_name")]
                public string corpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_invoicecorp")]
                public string pkInvoicecorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("invoicecorp_code")]
                public string invoicecorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("invoicecorp_name")]
                public string invoicecorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_reqcorp")]
                public string pkReqcorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("reqcorp_code")]
                public string reqcorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("reqcorp_name")]
                public string reqcorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
            }
        }
    }
}