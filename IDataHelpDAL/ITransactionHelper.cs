using System;
using System.Data.Common;

namespace IDataHelpDAL
{
    public interface ITransactionHelper : IDisposable
    {
        /// <summary>
        /// 事务开始
        /// </summary>
        /// <returns></returns>
        bool BeginTransation();

        /// <summary>
        /// 事务关闭
        /// </summary>
        void Close();

        /// <summary>
        /// 事务执行
        /// </summary>
        void Commit();

        /// <summary>
        /// 事务回滚
        /// </summary>
        void Rollback();

        /// <summary>
        /// 当前事务
        /// </summary>
        DbTransaction CurrentTransaction { get; }
    }
}
