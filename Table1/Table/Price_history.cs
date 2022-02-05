using System;
using System.Collections.Generic;
using System.Text;

namespace Table1.Table
{
    class Price_history
    {
        public string CryptName { get; set; }
        public DateTime History { get; set; }

        public override string ToString() =>
       $"{CryptName} | {History} ";

        public Price_history (string crypt_name,DateTime history)
        {
            CryptName = crypt_name;
            History = history;
        }
    }
}
