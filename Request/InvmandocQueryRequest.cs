using Newtonsoft.Json;
using YX.Utility.U8Cloud.Response;

namespace YX.Utility.U8Cloud.Request
{
    public class InvmandocQueryRequest : U8CloudRequest<InvmandocQueryResponse>
    {
        /// <summary>
        /// 开始时间
        /// </summary>
        public string startTs { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string endTs { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("page_now")]
        public string pageNow {get;set;}
        /// <summary>
        /// 每页显示条数
        /// </summary>
        [JsonProperty("page_size")]
        public string pageSize { get; set; }

        public override string GetServerName()
        {
            return "/u8cloud/api/uapbd/invmandoc/query";
        }

        public override string GetTranType()
        {
            return "undefined";
        }
    }
}