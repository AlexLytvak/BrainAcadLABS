using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Ellipse : Circle //, IShape
    {
        //public Point p1;
        //public Point p2;
        public Point p3;

         public Ellipse(Point p1, Point p2,Point p3):base(p1,p2)
        {
            //this.p1 = p1;
            //this.p2 = p2;
            this.p3 = p3;
            
            
        }
        //S=pi*R*r  /де R і r -велика і мала полуосі
        public override double Area()
        {
            double area = distance(this.p1, this.p2) * distance(this.p1, this.p3) * 3.14;

            return area;
        }

        public override double Perimeter()
        {
            //P=4(pi*R*r+(R-r))/(R+r)
            double perimetr =4*(3.14* distance(this.p1, this.p2) * distance(this.p1, this.p3)+(distance(this.p1, this.p2) - distance(this.p1, this.p3)))
                /(distance(this.p1,this.p2) + distance(this.p1,this.p3));

            return perimetr;
        }

        public override bool inspection()
        {
            if ((distance(this.p1, this.p2) > 0) && //перевірка відношення малої і великої осі за теоремою піфагора
                (Math.Round(distance(this.p2, this.p3) * distance(this.p2, this.p3),3) == Math.Round(distance(this.p1, this.p3) * distance(this.p1, this.p3) + distance(this.p1, this.p2) * distance(this.p1, this.p2),3)))
                return true;
            else
                Console.WriteLine("Koordunatu ne vidpovidayut' figyri elips");
                return false;

        }
              

    }
}
