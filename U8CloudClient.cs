using System.Collections.Generic;
using YX.Utility.Common;
using YX.Utility.Log;

namespace YX.Utility.U8Cloud
{
    /// <summary>
    /// U8Cloud客户端
    /// </summary>
    public class U8CloudClient
    {
        static readonly object locker = new object();

        /// <summary>
        /// 服务名
        /// </summary>
        protected string serverUrl;
        /// <summary>
        /// 翻译类型
        /// </summary>
        protected string trantype;
        /// <summary>
        /// 系统参数
        /// </summary>
        protected string system;
        /// <summary>
        /// 用户名
        /// </summary>
        protected string usercode;
        /// <summary>
        /// 密码
        /// </summary>
        protected string password;

        public U8CloudClient(string serverUrl, string system, string usercode, string password)
        {
            this.serverUrl = serverUrl;
            this.system = system;
            this.usercode = usercode;
            this.password = Md5EncryptUtil.Get32MD5(password);
        }

        public U8CloudClient(string serverUrl, string system, string usercode, string password, string trantype)
        {
            this.serverUrl = serverUrl;
            this.trantype = trantype;
            this.system = system;
            this.usercode = usercode;
            this.password = Md5EncryptUtil.Get32MD5(password);
        }

        public T Execute<T>(U8CloudRequest<T> request) where T : U8CloudResponse
        {
            var headers = new Dictionary<string, string>
            {
                { "trantype", trantype ?? request.GetTranType() },
                { "system", system },
                { "usercode", usercode },
                { "password", password }
            };
            string fullUrl = serverUrl + request.GetServerName();
            string reqBody = request.ToJson(true);
            LogHelper.Info($"U8C服务请求：url={fullUrl}^_^header={headers.ToJson(true)}^_^body={reqBody}");
            // 同一时间只允许一个线程发送请求
            string rspBody;
            lock (locker) {
                rspBody = WebUtils.DoPost(fullUrl, headers, reqBody, ContentType.Json);
            }
            LogHelper.Info($"U8C服务响应：{rspBody}");
            var rsp = rspBody.ToModel<T>();
            if (null != rsp && rsp.IsSuccess)
            {
                rsp.ParseData();
            }
            return rsp;
        }

    }

}
