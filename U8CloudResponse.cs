using Newtonsoft.Json;

namespace YX.Utility.U8Cloud
{
    /// <summary>
    /// U8Cloud响应基类
    /// </summary>
    public abstract class U8CloudResponse
    {
        /// <summary>
        /// 响应状态
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 异常信息
        /// </summary>
        public string errormsg { get; set; }
        /// <summary>
        /// 响应数据
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// 任务号
        /// </summary>
        public string taskNumber { get; set; }

        [JsonIgnore]
        public bool IsSuccess {
            get {
                return "success".Equals(status);
            }
        }

        [JsonIgnore]
        public bool IsError {
            get {
                return !IsSuccess;
            }
        }

        public abstract void ParseData();
    }
}
