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
            Dictionary<Duck, string> dictionary = new Dictionary<Duck, string>();
            dictionary.Add(new Duck("Sir Quackalot", "Mallard", 100, 17),"");
        }
    }
}
