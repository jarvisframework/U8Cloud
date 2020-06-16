using System.Collections.Generic;

namespace YX.Utility
{
    /// <summary>
    /// 数据域对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataDomain<T> 
    {
        /// <summary>
        /// 总数量
        /// </summary>
        public int allcount { get; set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int retcount { get; set; }
        /// <summary>
        /// 数据列表
        /// </summary>
        public List<T> datas { get; set; }
    }
}
