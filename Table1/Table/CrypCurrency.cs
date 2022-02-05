using System;
using System.Collections.Generic;
using System.Text;

namespace Table1.Table
{
    class CryptCurrency
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Abv { get; set; }
        public override string ToString() =>
           $"{Name} | {Price} | {Abv}";
        public CryptCurrency( string name,int price,string abv)
        {
            Name = name;
            Price = price;
            Abv = abv;

        }
    }
}
