using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Rectangle:Square,IShape
    {
        //public Point p1;//точка поєднання суміжних сторін
        //public Point p2;
        public Point p3;

         public Rectangle(Point p1, Point p2, Point p3):base(p1,p2)
        {
            //this.p1 = p1;
            //this.p2 = p2;
            this.p3 = p3;
        }
        public  double Area()
        {   //S=a*b
            double area = distance(this.p1, this.p2) * distance(this.p1, this.p3);

            return area;
        }

        public  double Perimeter()
        {   //P=2a+2b -периметр ромба і паралелограма
            double perimetr = 2*distance(this.p1, this.p2) + 2*distance(this.p1, this.p3);

            return perimetr;
        }

        public override bool inspection()
        {
            if              //перевірка на прямий кут між діагоналями
                (Math.Round(distance(this.p2, this.p3) * distance(this.p2, this.p3),2) == Math.Round(distance(this.p1, this.p3) * distance(this.p1, this.p3) + distance(this.p1, this.p2) * distance(this.p1, this.p2),2))
                return true;
            else
                Console.WriteLine("Koordunatu ne vidpovidayut' figyri pryamokutnuk ");
                return false;

        }

    }
}
