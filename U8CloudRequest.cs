namespace YX.Utility.U8Cloud
{
    /// <summary>
    /// U8Cloud请求基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class U8CloudRequest<T> where T : U8CloudResponse
    {

        /// <summary>
        /// 获取服务名称
        /// </summary>
        /// <returns></returns>
        public abstract string GetServerName();

        /// <summary>
        /// 翻译类型
        /// </summary>
        /// <returns></returns>
        public abstract string GetTranType();
    }
}