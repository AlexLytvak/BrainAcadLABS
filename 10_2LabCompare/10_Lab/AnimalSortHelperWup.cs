using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lab
{
    class AnimalSortHelperWup:IComparer<Animal>
    {
        public int Compare(Animal obj1, Animal obj2)
        {
            if (obj1.Weight > obj2.Weight)
                return 1;
            else if (obj1.Weight < obj2.Weight)
                return -1;
            else if (obj1.Weight == obj2.Weight)
            {
               return obj1.MaxSpeed.CompareTo(obj2.MaxSpeed);
               
            }
            else
            {
                return 0;
            }

        }


    }
}
