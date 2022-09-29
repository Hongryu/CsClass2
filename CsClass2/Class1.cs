using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T Value)
        {
            this.Value = Value;
        }
    }


    class Class1
    {

        public int this[int i]
        {
            get { return i; }
            set { Console.WriteLine(i + "번째 상품 설명"); }
        }

    }

}
