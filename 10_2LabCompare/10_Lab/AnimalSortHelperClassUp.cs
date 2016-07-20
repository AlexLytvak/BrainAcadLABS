using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lab
{
    class AnimalSortHelperClassUp : IComparer<Animal>
    {
        public int Compare(Animal obj1, Animal obj2)
        {
            return (obj1.Class.CompareTo(obj2.Class));

        }
    }
}
