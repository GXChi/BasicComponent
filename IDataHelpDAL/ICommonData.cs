
using System.Data;

namespace IDataHelpDAL
{
    public interface ICommonData : IRecordCountSupport, ITransactionSupport
    {
        void FillCommonData(string andSql, DataSet commonDataInfo, string tableName, string sortString, params object[] paramsValue);

        void FillCommonData(string andSql, DataSet commonDataInfo, string tableName, string sortString, uint pageSize, uint pageIndex, params object[] paramsValue);

        void UpdateCommonData(DataSet commonDataInfo, string tableName, string updateAndString, string deleteAndString);

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="data"></param>
        void Insert(object data);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="data"></param>
        void Update(object data);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="data"></param>
        void Delete(object data);

    }
}
