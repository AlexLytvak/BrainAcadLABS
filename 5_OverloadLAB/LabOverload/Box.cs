using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOverload
{
    class Box

    {
        private int x;
        public int X
        {
            get { return x; }
            set { this.x = value; }
        }
       
        public static int operator +( Box box1, int y)
        {
            
            return box1.x*y;
        }
     

    }
}
