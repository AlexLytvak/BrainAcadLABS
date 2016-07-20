using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] mas = new char[5] { 'p', 'i', 'l', 'i', 'p' };
           // char temp;
            bool flag = false;
            for (int i = 0; i < mas.Length / 2; i++)
            {

                
                //temp = mas[mas.Length - 1 - i];
              //  mas[mas.Length - 1 - i] = mas[i];
               // mas[i] = temp;
                if (mas[mas.Length - 1 - i] == mas[i])
                {
                    flag = true;
                    Console.WriteLine("+");

                }
                else
                {
                    flag = false;
                    Console.WriteLine("-");
                }
                if (flag )
                    Console.WriteLine("polindrom");

            }
            Console.ReadLine();
        }
    }
}
