using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_EventLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("SlugBug", 100, 10);
            c1.Exploded += new Car.CarEngHendler(OnCarEngineEvent);
            c1.AboutToBlow    += new Car.CarEngHendler(OnCarEngineEvent);
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

     

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n******mesage From Car Obgect*******");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("************************\n");
        }
    }
}
