using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lab
{
    class AnimalSortHelperMaxSpeedUp:IComparer<Animal>
    {
        public int Compare(Animal obj1, Animal obj2)
        {
            if (obj1.MaxSpeed > obj2.MaxSpeed)
                return 1;
            else if (obj1.MaxSpeed < obj2.MaxSpeed)
                return -1;
            else if (obj1.MaxSpeed == obj2.MaxSpeed)
            {
                return obj1.Weight.CompareTo(obj2.Weight);

            }
            else
            {
                return 0;
            }
        }

    }
}
