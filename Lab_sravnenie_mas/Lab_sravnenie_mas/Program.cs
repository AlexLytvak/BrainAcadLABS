using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sravnenie_mas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VVedite mas1 ");
            int[,] mas1 = new int[3, 3];
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for(int y=0;y<mas1.GetLength(1);y++)
                {
                int x = Convert.ToInt32(Console.ReadLine());
                mas1[i, y] = x;
                sum1 += mas1[i, y];
                }
            }
             Console.WriteLine("VVedite mas2 ");
            int[,] mas2 = new int[3, 3];
            for (int i = 0; i < mas2.GetLength(0); i++)
            {
                for (int y = 0; y < mas2.GetLength(1); y++)
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    mas2[i, y] = x;
                    sum2 += mas2[i, y];
                }
            }
            Console.WriteLine("sum mas1={0} , sum mas2={1}",sum1,sum2);
            if (sum1 > sum2)
            {
                Console.WriteLine("Sum mas1 bolshe ");
            }
            if (sum1 < sum2)
            {
                Console.WriteLine("Sum mas2 bolshe ");
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Rovnu ");
            }
            Console.ReadLine();
        }
    }
}
