using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    internal class Shoes
    {
        public string VendorCode;
        public string Name;
        public int Count;
        public int Cost;
        public Shoes(string vendorCode, string name, int count, int cost)
        {
            VendorCode = vendorCode;
            Name = name;
            Count = count;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{VendorCode}    {Name}    {Count}    {Cost}";
        }
    }
}
