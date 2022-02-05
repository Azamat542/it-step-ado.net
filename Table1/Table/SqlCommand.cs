using System;

namespace Crypt.Tables
{
    internal class SqlCommand
    {
        private string sql;
        private object connect;

        public SqlCommand(string sql, object connect)
        {
            this.sql = sql;
            this.connect = connect;
        }

        public object Parameters { get; internal set; }

        internal object ExecuteReader()
        {
            throw new NotImplementedException();
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}