using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Console.WriteLine("Enter value1:");
            box1.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value2:");
            int y = Convert.ToInt32(Console.ReadLine());
          

            Console.WriteLine("{0} + {1} posle peregruzki(+) ={2}", box1.X, y, box1 + y);
            Console.ReadLine();
        }


      
    }
}
