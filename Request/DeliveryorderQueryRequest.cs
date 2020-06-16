using Newtonsoft.Json;
using YX.Utility.U8Cloud.Response;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 发货单查询请求
    /// </summary>
    public class DeliveryorderQueryRequest : U8CloudRequest<DeliveryorderQueryResponse>
    {
        /// <summary>
        /// 公司编码
        /// </summary>
        public string corp { get; set; }

        /// <summary>
        /// 单据日期开始
        /// </summary>
        [JsonProperty("date_begin")]
        public string dateBegin { get; set; }

        /// <summary>
        /// 单据日期结束
        /// </summary>
        [JsonProperty("date_end")]
        public string dateEnd { get; set; }

        /// <summary>
        /// 开始ts
        /// </summary>
        [JsonProperty("ts_begin")]
        public string tsBegin { get; set; }

        /// <summary>
        /// 结束ts
        /// </summary>
        [JsonProperty("ts_end")]
        public string tsEnd { get; set; }

        /// <summary>
        /// 单据状态（0：审批不通过，1：审批通过，8：自由态，3：提交态，2：审批进行中）
        /// </summary>
        [JsonProperty("fstatus")]
        public string fStatus { get; set; }       

        public override string GetServerName()
        {
            return "/u8cloud/api/so/salereceive/query";
        }

        public override string GetTranType()
        {
            return "code";
        }
    }
}