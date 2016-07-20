using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10_1LabICompare
{
    class Animal:IComparable<Animal>
    {
       public  double Weight;
       public  string Class;
       public  double MaxSpeed;

        public Animal(double w, string C, double MS)
        {
            Weight = w;
            Class = C;
            MaxSpeed = MS;
        }

        public int CompareTo(Animal obj)
        {
            if (this.Weight > obj.Weight)
                return 1;
            if (this.Weight < obj.Weight)
                return -1;
            else
                return 0;
        }

    }
}
