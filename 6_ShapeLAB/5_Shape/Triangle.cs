using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Triangle:Shape,IShape
    {
        public Point p1;
        public Point p2;
        public Point p3;
        public Triangle(Point p1,Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        
        public  double Area()
        {   //півпериметр трикутника для визначення площі за формулою Герона
            //p=(a+b+c)/2;    s=Sqrt(p*(p-a)*(p-b)*(p-c)
            double p = (distance(this.p1, this.p2) + distance(this.p2, this.p3) + distance(this.p3, this.p1)) / 2;
            double area =Math.Sqrt( p * (p-distance(this.p1, this.p2))*(p-distance(this.p2, this.p3))*(p-distance(this.p3, this.p1)));

            return area;
        }

        public  double Perimeter()
        {   //P=a+b+c
            double perimetr = distance(this.p1, this.p2) + distance(this.p2, this.p3) + distance(this.p3, this.p1); 

            return perimetr;
        }

        public override bool inspection()
        {   //сума двох сторін трикутника повина бути більша за третю сторону
            if (Math.Round(distance(this.p1, this.p2) + distance(this.p2, this.p3),3)>Math.Round(distance(this.p3, this.p1),3))
                return true;
            else
                Console.WriteLine("Koordunatu ne vidpovidayut' figyri trukytnuk");
                return false;
        }

    }
}
