using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lab_GetNumerator
{
   public class Palitra:IEnumerable
    {
        private Color[] mascol = new Color[9];
        public Palitra()
        {
            mascol[0]=new Color("red",0);
            mascol[1] = new Color("orange", 1);
            mascol[2] = new Color("yellow", 2);
            mascol[3] = new Color("green", 3);
            mascol[4] = new Color("blue", 4);
            mascol[5] = new Color("purple", 5);
            mascol[6] = new Color("pink", 6);
            mascol[7] = new Color("black", 7);
            mascol[8] = new Color("white", 8);
                
        }
       public IEnumerator GetEnumerator()
       {
           foreach(Color c in mascol)
           {
               yield return c;
           }
       }
    }
    public class Color
    {
        public string ColoR { get; set; }
        public int Number { get; set; }
        public Color(string st,int n)
        {
            ColoR = st;
            Number = n;
        }
    }
}
