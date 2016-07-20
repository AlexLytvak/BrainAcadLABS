using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Rect_square:Square,IShape
    {
        //public Point p1;
        //public  Point p2;
        public Rect_square(Point p1, Point p2):base(p1,p2)
        {
           
        }
        
        public  double  Area()
        {   //S=a*a;
            double area = distance(this.p1, this.p2) * distance(this.p1, this.p2);

            return area;
        }

        public  double Perimeter()
        {   //P=4a  -периметр квадрата
            double perimetr = 4*distance(this.p1, this.p2);

            return perimetr;
        }

        public override bool inspection()
        {
            if (distance(this.p1, this.p2)> 0.0)
                return true;
            else
            {
                Console.WriteLine("Koordunatu ne vidpovidayut' figyri kvadrat ");
                return false;
            }
        }
    }
}
