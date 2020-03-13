using System.Data.Common;

namespace IDataHelpDAL
{
    public interface ITransactionSupport
    {
        /// <summary>
        /// 连接事务
        /// </summary>
        /// <param name="transaction"></param>
        void JoinTransation(DbTransaction transaction);

        /// <summary>
        /// 重置处理
        /// </summary>
        void ResetTransaction();

        /// <summary>
        /// 进入事务
        /// </summary>
        bool InTransactionNow { get; }
    }
}
