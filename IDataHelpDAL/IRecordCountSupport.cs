namespace IDataHelpDAL
{
    public interface IRecordCountSupport
    {
        /// <summary>
        /// 获取执行数量
        /// </summary>
        /// <param name="andSql">sql条件语句</param>
        /// <param name="paramsValue">查询字符</param>
        /// <returns>执行数量</returns>
        uint GetRecordCount(string andSql, params object[] paramsValue);
    }
}
