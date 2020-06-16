using Newtonsoft.Json;

namespace YX.Utility.U8Cloud.Request
{
    /// <summary>
    /// 库存其他出库单查询请求
    /// </summary>
    public class OtheroutorderQueryRequest : U8CloudRequest<OtheroutorderQueryResponse>
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
        /// 当前页
        /// </summary>
        [JsonProperty("page_now")]
        public string pageNow { get; set; }

        /// <summary>
        /// 每页显示条数
        /// </summary>
        [JsonProperty("page_size")]
        public string pageSize { get; set; }

        /// <summary>
        /// 单据状态(1：删除 2：自由(缺省) 3：库房签字 4：存货系统审核)
        /// </summary>
        [JsonProperty("fbillflag")]
        public string fBillFlag { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        public string warehouse { get; set; }

        public override string GetServerName()
        {
            return "/u8cloud/api/ic/otherout/query";
        }

        public override string GetTranType()
        {
            return "undefined";
        }
    }
}