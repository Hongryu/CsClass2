using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{
    class Products
    {

        public void Dispose()
        {
            Console.WriteLine("Dispose() 메서드를 호출합니다.");
        }

    }
    static void Main(String[] args)
    {
        using (Product product = new Product())
        {

        }
    }
}
