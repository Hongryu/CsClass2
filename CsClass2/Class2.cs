using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClass2
{
     class Class2 : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(object obj)
        {
            return this.Price.CompareTo((obj as Class2).Price);
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";

        }
    }
    static void Main(string[] args)
    {
        List<Class2> list = new List<Class2>
        {
            new Class2() {Name="고구마", Price=1500 },
            new Class2() {Name="사과", Price=2400 },
            new Class2() {Name="바나나", Price=1000 },
            new Class2() {Name="배", Price=3000 }
        };

        list.Sort();

        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
    }
}


