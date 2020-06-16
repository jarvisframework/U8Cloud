using Newtonsoft.Json;
using System.Collections.Generic;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 库存销售出库单新增请求
    /// </summary>
    public class SaleoutorderInsertRequest : U8CloudRequest<SaleoutorderInsertResponse>
    {
        public GeneralBillVO billvo { get; set; }

        public class GeneralBillVO
        {
            public ParentVO parentvo { get; set; }

            public List<ChildrenVO> childrenvo { get; set; }

            public class ParentVO
            {
                /// <summary>
                /// 业务类型ID
                /// </summary>
                public string cbiztype { get; set; }
                /// <summary>
                /// 客户
                /// </summary>
                public string ccustomerid { get; set; }
                /// <summary>
                /// 制单人
                /// </summary>
                public string coperatorid { get; set; }
                /// <summary>
                /// 仓库ID
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
            }

            public class ChildrenVO
            {

                /// <summary>
                /// 存货ID
                /// </summary>
                public string cinventoryid { get; set; }

                /// <summary>
                /// 来源单据号
                /// </summary>
                public string vsourcebillcode { get; set; }

                /// <summary>
                /// 实出数量
                /// </summary>
                public string noutnum { get; set; }

                /// <summary>
                /// 批次号
                /// </summary>
                public string vbatchcode { get; set; }
                /// <summary>
                /// 来源单据行号
                /// </summary>
                public string vsourcerowno { get; set; }
                /// <summary>
                /// 来源单据类型（发货单：4331，销售订单 ：30）
                /// </summary>
                public string csourcetype { get; set; }
                /// <summary>
                /// 
                /// </summary>
                public List<Locator> locator { get; set; }

                public class Locator { }
            }
        }

        public override string GetServerName()
        {
            return "/u8cloud/api/ic/saleout/insert";
        }

        public override string GetTranType()
        {
            return "code";
        }
    }
}