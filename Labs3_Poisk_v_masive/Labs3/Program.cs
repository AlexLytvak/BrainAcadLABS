using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs3
{
    class Program
    {  //пошук в масиві
        static void Main(string[] args)
        {
            int[,] mas = new int[2,3];
            mas[0, 0] = 3;
            mas[0, 1] = 4;
            mas[0, 2] = 6;
            mas[1, 0] = 7;
            mas[1, 1] = 13;
            mas[1, 2] = 5;
            Console.WriteLine("Vvedite chislo:");
            int x = Convert.ToInt32(Console.ReadLine());
            bool f = true;
           
            for (int i = 0; i <mas.GetLength(0); i++)
            {
                for (int y = 0; y <mas.GetLength(1); y++)
                {
                    if (mas[i,y] == x)
                    {
                        Console.WriteLine(" {0} nahoditsya v index[{1}.{2}]",x,i,y);
                        f = false;
                       
                    }

                }
            }
            if (f == true)
            {

                Console.WriteLine(" sovpadeniy net ");
            }
            
            
            Console.ReadLine();
        }
    }
}
