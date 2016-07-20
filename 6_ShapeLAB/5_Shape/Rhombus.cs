using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Rhombus:Square,IShape
    {
       //public  Point p1; //точка перетину діагоналей ромба 
       //public  Point p2; //вершина ромбу
       public  Point p3; //вершина ромбу
         public Rhombus(Point p1, Point p2,Point p3):base(p1,p2)
        {
            //this.p1 = p1;
            //this.p2 = p2;
            this.p3 = p3;
        }
      
       public  double Area()
       {   //S=(d1*d2)/2   d1,d2 діагоналі
           double area = 2*distance(this.p1, this.p2) * distance(this.p1, this.p3);//ф-ла для напівдіагоналей

           return area;
       }

       public  double Perimeter()
       {   //P=4a -периметр ромба 
           double perimetr =4* distance(this.p2, this.p3) ;

           return perimetr;
       }

       public override bool inspection()
       {
           if              //перевірка на прямий кут між діагоналями
               (Math.Round(distance(this.p2, this.p3) * distance(this.p2, this.p3),3) == Math.Round(distance(this.p1, this.p3) * distance(this.p1, this.p3) + distance(this.p1, this.p2) * distance(this.p1, this.p2),3))
               return true;
           else
               Console.WriteLine("Koordunatu ne vidpovidayut' figyri romb ");
               return false;

       }

    }
}
