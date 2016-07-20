using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_pr
{
    class Rectangle
    {
       public static int row; //смещение по строкам
       public  static int col; //смещение по столбцам
       public int h;
       public int w;
       private string st;
       public string ST
       {
           get { return st; }
           set { st = value; }
       }
       
        
        public  Rectangle(int H, int W,string ST)
        {
            this.h = H;
            this.w = W;
            this.ST = ST;
        }
     public    void DrowHoriz( int w)
        {
            for (int i = 0; i <= w; i++)
            {

                Console.Write("*");
            }
            Console.WriteLine();
                   
            
        }
        public  void DrowVertical(int w)
        {
            for (int i = 0; i <= w; i++)
            {
                if (i == 0 || i == w)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }





        


    }
}
