using Newtonsoft.Json;
using System.Collections.Generic;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 库存采购入库单新增请求
    /// </summary>
    public class PurchaseinEntryorderInsertRequest : U8CloudRequest<PurchaseinEntryorderInsertResponse>
    {
        [JsonProperty("GeneralBillVO")]
        public GeneralBillVO generalBillVO { get; set; }

        public class GeneralBillVO
        {

            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("ParentVO")]
            public ParentVO parentVO { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("ChildrenVO")]
            public List<ChildrenVO> childrenVO { get; set; }

            public class ParentVO
            {
                /// <summary>
                /// 业务类型
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 操作员
                /// </summary>
                public string coperatorid { get; set; }
                /// <summary>
                /// 仓库id
                /// </summary>
                public string cwarehouseid { get; set; }
                /// <summary>
                /// 库存组织pk
                /// </summary>
                [JsonProperty("pk_calbody")]
                public string pkCalbody { get; set; }
                /// <summary>
                /// 公司
                /// </summary>
                [JsonProperty("pk_corp")]
                public string pkCorp { get; set; }
            }

            public class ChildrenVO
            {
                /// <summary>
                /// 存货id
                /// </summary>
                public string cinventoryid { get; set; }
                /// <summary>
                /// 实收数量
                /// </summary>
                public string ninnum { get; set; }
                /// <summary>
                /// 单价
                /// </summary>
                public string nprice { get; set; }
                /// <summary>
                /// 金额
                /// </summary>
                public string nmny { get; set; }
                /// <summary>
                /// 批次号
                /// </summary>
                public string vbatchcode { get; set; }
                /// <summary>
                /// 来源单据类型（请购单：20,采购订单：21，到货单：23）
                /// </summary>
                public string csourcetype { get; set; }
                /// <summary>
                /// 来源单据行号
                /// </summary>
                public string vsourcerowno { get; set; }
                /// <summary>
                /// 来源单据号
                /// </summary>
                public string vsourcebillcode { get; set; }
                /// <summary>
                /// 对应入库单号
                /// </summary>
                public string ccorrespondcode { get; set; }               
                public List<Locator> locator { get; set; }

                public class Locator { }
            }
        }
        public override string GetServerName()
        {
            return "/u8cloud/api/ic/purchasein/insert";
        }

        public override string GetTranType()
        {
            return "code";
        }
    }
}