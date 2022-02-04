using System;

namespace Crypt
{
    internal class SqlConnection
    {
        private string connectionString;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}