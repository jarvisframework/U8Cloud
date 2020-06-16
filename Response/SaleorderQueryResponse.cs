using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 销售订单查询响应
    /// </summary>
    public class SaleorderQueryResponse : U8CloudResponse
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
                public string ccustomerid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("customer_code")]
                public string customerCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("customer_name")]
                public string customerName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csalecorpid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("salecorp_code")]
                public string salecorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("salecorp_name")]
                public string salecorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ccalbodyid { get; set; }
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
                public string coperatorid { get; set; }
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
                public string vreceiptcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dbilldate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dmakedate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dbilltime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dapprovedate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string daudittime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string capproveid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("approver_code")]
                public string approverCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("approver_name")]
                public string approverName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceiptcustomerid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("receiptcustomer_code")]
                public string receiptcustomerCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("receiptcustomer_name")]
                public string receiptcustomerName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceiptcorpid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("receiptcorp_code")]
                public string receiptcorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("receiptcorp_name")]
                public string receiptcorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ndiscountrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csaleid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal fstatus { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bretinvflag { get; set; }
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
                public string cinventoryid { get; set; }
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
                public decimal nnumber { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcursummny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cunitid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("unit_code")]
                public string unitCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("unit_name")]
                public string unitName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceiptcorpid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cadvisecalbodyid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("advisecalbody_code")]
                public string advisecalbodyCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("advisecalbody_name")]
                public string advisecalbodyName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cconsigncorpid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("consigncorp_code")]
                public string consigncorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("consigncorp_name")]
                public string consigncorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string blargessflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string crowno { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ntaxrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurtaxprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurtaxmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal ndiscountrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nitemdiscountrate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurnetprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurtaxnetprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noriginalcurdiscountmny { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dconsigndate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ddeliverdate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cquoteunitid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cquoteunit_code")]
                public string cquoteunitCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cquoteunit_name")]
                public string cquoteunitName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csaleid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("corder_bid")]
                public string corderBid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
            }
        }
    }
}