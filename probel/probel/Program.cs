using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probel
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "Hello world, retur vefv esrbgvtrsbgr svf vfevf";
            char str2 = ' ';
            for (int i = 0; i < st1.Length; i++)
            {
                if (st1[i] !=str2)
                {
                  string   ch= Convert.ToString(st1[i]);
                  Console.Write("{0}", ch);
                }
            }
            Console.ReadLine();
        }
    }
}
