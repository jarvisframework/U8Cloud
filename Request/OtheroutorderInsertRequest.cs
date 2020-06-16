using Newtonsoft.Json;
using System.Collections.Generic;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 库存其他出库单新增请求
    /// </summary>
    public class OtheroutorderInsertRequest : U8CloudRequest<OtheroutorderInsertResponse>
    {
        [JsonProperty("GeneralBillVO_4I")]
        public GeneralBillVO billvo { get; set; }

        public class GeneralBillVO
        {
            public ParentVO parentvo { get; set; }

            public List<ChildrenVO> childrenvo { get; set; }

            public class ParentVO
            {
                /// <summary>
                /// 制单人
                /// </summary>
                public string coperatorid { get; set; }
                /// <summary>
                /// 仓库
                /// </summary>
                public string cwarehouseid { get; set; }
                /// <summary>
                /// 库存组织PK
                /// </summary>
                [JsonProperty("pk_calbody")]
                public string pkCalbody { get; set; }
                /// <summary>
                /// 公司
                /// </summary>
                [JsonProperty("pk_corp")]
                public string pkCorp { get; set; }
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
                /// <summary>
                /// 原单据PK
                /// </summary>
                [JsonProperty("pk_defdoc1")]
                public string pkDefdoc1 { get; set; }
                /// <summary>
                /// /原单据号
                /// </summary>
                [JsonProperty("pk_defdoc2")]
                public string pkDefdoc2 { get; set; }
                /// <summary>
                /// 客户
                /// </summary>
                public string ccustomerid { get; set; }
                /// <summary>
                /// 业务员
                /// </summary>
                public string cbizid { get; set; }
                /// <summary>
                /// 部门
                /// </summary>
                public string cdptid { get; set; }
                /// <summary>
                /// 收发类型
                /// </summary>
                public string cdispatcherid { get; set; }
            }

            public class ChildrenVO
            {
                /// <summary>
                /// 存货ID
                /// </summary>
                public string cinventoryid { get; set; }
                /// <summary>
                /// 实出数量
                /// </summary>
                public string noutnum { get; set; }
                /// <summary>
                /// 批次号
                /// </summary>
                public string vbatchcode { get; set; }
                /// <summary>
                /// 表体Pk
                /// </summary>
                [JsonProperty("pk_defdoc1")]
                public string pkDefdoc1 { get; set; }
                /// <summary>
                /// 单据号
                /// </summary>
                [JsonProperty("pk_defdoc2")]
                public string pkDefdoc2 { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<Locator> locator { get; set; }

                public class Locator { }
            }
        }

        public override string GetServerName()
        {
            return "/u8cloud/api/ic/otherout/insert";
        }

        public override string GetTranType()
        {
            return "code";
        }
    }
}