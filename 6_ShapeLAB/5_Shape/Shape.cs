using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5_Shape
{
    abstract class Shape
    {
        public struct Point
        {
            public  int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
          
        }
        public static double  distance(Point p1, Point p2)
        {
            double   distan;
          return   distan = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
        }
         public abstract bool inspection();
      
            
        
    }
}
