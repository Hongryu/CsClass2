using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{
    class Parent { }
    class Child : Parent, IDisposable, IComparable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }

    static void Main(string[] args)
    {

    }
}
