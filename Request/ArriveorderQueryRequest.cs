using Newtonsoft.Json;
using YX.Utility.U8Cloud.Response;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 到货单查询请求
    /// </summary>
    public class ArriveorderQueryRequest : U8CloudRequest<ArriveorderQueryResponse>
    {
        /// <summary>
        /// 公司
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
        public string beginTs { get; set; }

        /// <summary>
        /// 结束ts
        /// </summary>
        [JsonProperty("ts_end")]
        public string endTs { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("page_now")]
        public string pageNow { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("page_size")]
        public string pageSize { get; set; }        

        /// <summary>
        /// 单据状态(0：自由(缺省) 1：作废 2：正在审批 3：审批通过 4：审批未通过)
        /// </summary>
        public string forderstatus { get; set; }

        public override string GetServerName()
        {
            return "/u8cloud/api/pu/arriveorder/query";
        }

        public override string GetTranType()
        {
            return "undefined";
        }
    }
}