using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Shape
{
    class Square:Shape
    {
        public Point p1;
        public  Point p2;
        public Square(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }



        public override bool inspection()
        {
            Console.WriteLine("base function");
                return true;
          
        }

         
    }
}
