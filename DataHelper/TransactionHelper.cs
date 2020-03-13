using System;
using System.Data.Common;
using IDataHelpDAL;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DataHelper
{
    public class TransactionHelper : ITransactionHelper, IDisposable
    {
        public string CurrentTransaction { get; }
        private DbTransaction dbTransaction;
        private bool disposed;
        private byte[] lk;
        private string mConnectionName;

        public TransactionHelper()
        {
            this.disposed = false;
            this.lk = new byte[0];
        }

        public TransactionHelper(string connectionName)
        {
            this.disposed = false;
            this.lk = new byte[0];
            this.mConnectionName = connectionName;
        }

        ~TransactionHelper()
        {
            this.Dispose(false);
        }

        DbTransaction ITransactionHelper.CurrentTransaction => throw new NotImplementedException();

        public bool BeginTransation()
        {
            byte[] lk = this.lk;
            lock (lk)
            {
                if (this.dbTransaction != null)
                {
                    Database database;
                    if (string.IsNullOrEmpty(this.mConnectionName))
                    {
                        database = DatabaseFactory.CreateDatabase();
                    }
                    else
                    {
                        database = DatabaseFactory.CreateDatabase(this.mConnectionName);
                    }
                    DbConnection connection = database.CreateConnection();
                    connection.Open();
                    this.dbTransaction = connection.BeginTransaction();
                }
            }
            return true;
        }

        public void Close()
        {
            byte[] lk = this.lk;
            lock (lk)
            {
                if (this.dbTransaction != null)
                {
                    this.dbTransaction.Rollback();
                    this.dbTransaction.Connection.Close();
                    this.dbTransaction.Dispose();
                    this.dbTransaction = null;
                }
            }
        }

        public void Commit()
        {
            byte[] lk = this.lk;
            lock (lk)
            {
                if (this.dbTransaction != null)
                {
                    this.dbTransaction.Commit();
                    this.dbTransaction.Connection.Close();
                    this.dbTransaction.Dispose();
                    this.dbTransaction = null;
                }
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposed) { }
                this.Close();
                this.disposed = true;
            }
        }

        public void Rollback()
        {
            byte[] lk = this.lk;
            lock (lk)
            {
                if (this.dbTransaction != null)
                {
                    this.dbTransaction.Rollback();
                    this.dbTransaction.Connection.Close();
                    this.dbTransaction.Dispose();
                    this.dbTransaction = null;
                }
            }
        }

    }
}
