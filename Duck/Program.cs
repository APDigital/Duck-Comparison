using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Duck, string> dictionary = new Dictionary<Duck, string>
            {
                { new Duck("Sir Quackalot", "Mallard", 100, 17), "" },
                { new Duck("Mr Quack", "Mallard", 120, 20),"" }
            };
            var list = dictionary.ToList();
            list.Sort();

            Console.WriteLine(list);
        }
    }
}
