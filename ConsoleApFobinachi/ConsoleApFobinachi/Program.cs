using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApFobinachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVedite chislo : ");
            int n = Convert.ToInt16(Console.ReadLine());                
           
          int fob1 = 0;
          int sum = 0;
          int fob2=1;
          
          for (int i = 0; i <= n; i++)
          {
              Console.Write(i+"  ");

           
                  fob1 = fob2;
                  fob2 = sum;
                  sum = fob1 + fob2;
                  Console.WriteLine(fob1 + "+" + fob2 + " = " + sum);
                  
             

          }
              Console.Read();
        }
    }
}
