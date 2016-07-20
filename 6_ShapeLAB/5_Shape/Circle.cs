using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Circle:Shape,IShape
    {
       public  Point p1;
       public  Point p2;
        public Circle(Point p1,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;

        }


        public virtual double Area()
        {   //S=pi*R*R
            double area = distance(this.p1, this.p2) * distance(this.p1, this.p2)*3.14;

            return area;
        }
        public virtual double Perimeter()
        {   //P=2*pi*R
            double perimetr = 2 * distance(this.p1, this.p2) * 3.14;

            return perimetr;
        }
        public  override bool inspection()
        {
            if (distance(this.p1, this.p2) > 0)
                return true;
            else
                Console.WriteLine("Koordunatu ne vidpovidayut' figyri krug ");
                return false;
        }

    }
}
