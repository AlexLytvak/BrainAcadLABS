using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lab
{
    class AnimalSortHelperWdown:IComparer<Animal>
    {
        public int Compare(Animal obj1, Animal obj2)
        {
            if (obj1.Weight > obj2.Weight)
                return -1;
            else if (obj1.Weight < obj2.Weight)
                return 1;
            else if (obj1.Weight == obj2.Weight)
            {
                return obj2.MaxSpeed.CompareTo(obj1.MaxSpeed);

            }
            else
            {
                return 0;
            }
        }
    }
}
