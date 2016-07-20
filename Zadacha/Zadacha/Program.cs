using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int[] mas = new int[8]{ 0,1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < mas.Length/2; i++)
            {


                temp = mas[mas.Length -1-i];
                mas[mas.Length - 1 - i] = mas[i];
                mas[i] = temp;
                
            }
           

                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("{0}", mas[i]);
                }
            Console.ReadLine();
        }
    }
}
