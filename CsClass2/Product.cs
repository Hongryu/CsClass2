using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            int result = 0;
            if(this.Price < other.Price)
            {
                result = -1;
            }else if(this.Price > other.Price)
            {
                result = 1;
            }
            return result;
        }
        public override string ToString()
        {
            return Name + " : " + "원";
        }
    }
}
