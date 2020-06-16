using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Response
{
    /// <summary>
    /// 发货单查询响应
    /// </summary>
    public class DeliveryorderQueryResponse : U8CloudResponse
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

        public class BillVO {

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
                [JsonProperty("code_name")]
                public string codeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string coperatorid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("coperator_code")]
                public string coperatorCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("coperator_name")]
                public string coperatorName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bifclose { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cbiztype_code")]
                public string cbiztypeCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cbiztype_name")]
                public string cbiztypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cmodifyid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cmodifyCode")]
                public string cmodify_code { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cmodify_name")]
                public string cmodifyName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceipttype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csalecorpid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csalecorp_code")]
                public string csalecorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csalecorp_name")]
                public string csalecorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csalereceiveid { get; set; }
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
                public string fstatus { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ntotalnumber { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ntotalvolume { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ntotalweight { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tmaketime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tmodifytime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vreceivecode { get; set; }
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

            public class ChildrenVO {
                /// <summary>
                /// 
                /// </summary>
                public string csendcalbodyid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csendcalbody_code")]
                public string csendcalbodyCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csendcalbody_name")]
                public string csendcalbodyName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_sendcorp")]
                public string pkSendcorp { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("sendcorp_code")]
                public string sendcorpCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("sendcorp_name")]
                public string sendcorpName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ccustbasdocid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceivecustbasid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cbiztype_code")]
                public string cbiztypeCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cbiztype_name")]
                public string cbiztypeName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csendwareid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csendware_code")]
                public string csendwareCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csendware_name")]
                public string csendwareName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cinvmandocid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cinvmandoc_code")]
                public string cinvmandocCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("cinvmandoc_name")]
                public string cinvmandocName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tsendtime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ccustmandocid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("ccustmandoc_code")]
                public string ccustmandocCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("ccustmandoc_name")]
                public string ccustmandocName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vsendaddress { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string blargessflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cinvbasdocid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nvolume { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nnumber { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ddeliverdate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dsenddate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string btransportcloseflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vsourcereceivecode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csourcebillbodyid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string crowno { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int ntotaltransnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tdelivertime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bifrowclose { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nweight { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vsourcerowno { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("csalereceiveid_bid")]
                public string csalereceiveidBid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string creceivecustid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("creceivecust_code")]
                public string creceivecustCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("creceivecust_name")]
                public string creceivecustName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string csourcebillid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string vsourcetype { get; set; }
                /// <summary>
                /// 收货联系人
                /// </summary>
                public string vreceiveperson { get; set; }
                /// <summary>
                /// 收货地址
                /// </summary>
                public string vreceiveaddress { get; set; }
                /// <summary>
                /// 收货联系电话	
                /// </summary>
                public string vreceivetel { get; set; }
            }
        }
    }
}