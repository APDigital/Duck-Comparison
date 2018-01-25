using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    public class Duck
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }
        public override bool Equals(object obj)
        {
            Duck d2 = obj as Duck;
            if (d2 == null)
            {
                return false;
            }
            return Name == d2.Name && Type == d2.Type && WeightInGrams == d2.WeightInGrams && AgeInMonths == d2.AgeInMonths;  
        }
        //followed explanation from https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 29 + (Name ?? "").GetHashCode();
                hash = hash * 29 + (Type ?? "").GetHashCode();
                hash = hash * 29 + (WeightInGrams).GetHashCode();
                hash = hash * 29 + (AgeInMonths).GetHashCode();
                return hash;
            }
        }

    }

   
}
