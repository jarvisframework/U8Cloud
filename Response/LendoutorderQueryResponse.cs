using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Response
{
    /// <summary>
    /// 库存借出单查询响应
    /// </summary>
    public class LendoutorderQueryResponse : U8CloudResponse
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
                public string cdispatcherid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("dispatcher_code")]
                public string dispatcherCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("dispatcher_name")]
                public string dispatcherName { get; set; }
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
                public string cwarehouseid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("warehouseid_code")]
                public string warehouseidCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("warehouseid_name")]
                public string warehouseidName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_calbody")]
                public string pkCalbody { get; set; }
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
                public string vbillcode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string dbilldate { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string freplenishflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bassetcard { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bdirecttranflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbilltypecode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cgeneralhid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string clastmodiid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("lastmodi_code")]
                public string lastmodiCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("lastmodi_name")]
                public string lastmodiName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string fbillflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tlastmoditime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string tmaketime { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string ts { get; set; }
                /// <summary>
                /// 收件人
                /// </summary>
                [JsonProperty("vuserdef4")]
                public string receiverName { get; set; }
                /// <summary>
                /// 收件人移动电话
                /// </summary>
                [JsonProperty("vuserdef5")]
                public string receiverMobile { get; set; }
                /// <summary>
                /// 收件人省
                /// </summary>
                [JsonProperty("vuserdef6")]
                public string receiverProvince { get; set; }
                /// <summary>
                /// 收件人市
                /// </summary>
                [JsonProperty("vuserdef7")]
                public string receiverCity { get; set; }
                /// <summary>
                /// 收件人区
                /// </summary>
                [JsonProperty("vuserdef8")]
                public string receiverArea { get; set; }
                /// <summary>
                /// 收件人详细地址  
                /// </summary>
                [JsonProperty("vuserdef9")]
                public string receiverDetailAddress { get; set; }
                public string cbizid { get; set; }//业务员

                public string ccustomerid { get; set; }//客户Id
                /// <summary>
                /// 部门
                /// </summary>
                public string cdptid { get; set; }
            }

            public class ChildrenVO
            {
                /// <summary>
                /// 
                /// </summary>
                public string bbarcodeclose { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bonroadflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string breturnprofit { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bsafeprice { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bsourcelargess { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bsupplyflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string btoinzgflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string btoouttoiaflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string btou8rm { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string bzgflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbodybilltypecode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cbodywarehouseid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("bodywarehouse_code")]
                public string bodywarehouseCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("bodywarehouse_name")]
                public string bodywarehouseName { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cgeneralbid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string cgeneralhid { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string crowno { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string fassertcardflag { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string fchecked { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string flargess { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string idesatype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string isok { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public int nbarcodenum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string npricesettlebill { get; set; }
                /// <summary>
                /// 应出数量
                /// </summary>
                public decimal nshouldoutnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_bodycalbody")]
                public string pkBodycalbody { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("bodycalbody_code")]
                public string bodycalbodyCode { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("bodycalbody_name")]
                public string bodycalbodyName { get; set; }
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
                public string ts { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("pk_measdoc")]
                public string pkMeasdoc { get; set; }
                /// <summary>
                /// 
                /// </summary>
                [JsonProperty("measdoc_code")]
                public string measdocCode { get; set; }
                /// <summary>
                /// 个
                /// </summary>
                [JsonProperty("measdoc_name")]
                public string measdocName { get; set; }
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
                /// 收货地址
                /// </summary>
                public string vreceiveaddress { get; set; }
            }
        }
    }
}