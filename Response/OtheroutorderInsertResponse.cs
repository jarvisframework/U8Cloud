using Newtonsoft.Json;
using System.Collections.Generic;
using YX.Utility.Common;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 库存其他出库单新增响应
    /// </summary>
    public class OtheroutorderInsertResponse : U8CloudResponse
    {
        public List<BillVO> dataDomain { get; set; }

        public override void ParseData()
        {
            dataDomain = data.ToModel<List<BillVO>>();
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
                public string bsalecooppur { get; set; }
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
                public string dbizdate { get; set; }
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
                public string idesatype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal nbarcodenum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public decimal noutnum { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public string npricesettlebill { get; set; }
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
                public string vbatchcode { get; set; }
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
                /// 
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
                /// 
                /// </summary>
                public List<Locator> locator { get; set; }

                public class Locator
                {
                }
            }
        }
    }
}