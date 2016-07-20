using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Lab_GetNumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Palitra pal = new Palitra();
            foreach (Color c in pal)
            {
                Console.WriteLine("{0}-{1}", c.ColoR, c.Number.ToString());
            }
            Console.ReadLine();
        }
    }
}
