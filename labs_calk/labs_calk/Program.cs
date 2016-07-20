using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_calk
{
    class Program
    {
        static void Main(string[] args)
        {
            char vuhod_vhod = 'a';
            while (vuhod_vhod == 'a')
            {
                Console.WriteLine("Vvedite chislo : ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Vvedite operaciyu |+|-|*|/| : ");
                char oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(" Vvedite vtoroe chislo: ");
                double y = Convert.ToDouble(Console.ReadLine());
                switch (oper)
                {
                    case ('+'):
                        double m = x + y;
                        Console.WriteLine(" {0} + {1} = {2} ", x, y, m);
                        break;
                    case ('-'):
                        Console.WriteLine(" {0} - {1} = {2} ", x, y, x - y);
                        break;
                    case ('*'):
                        Console.WriteLine(" {0} * {1} = {2} ", x, y, x * y);
                        break;
                    case ('/'):
                        Console.WriteLine(" {0} / {1} = {2} ", x, y, x / y);
                        break;
                    default:
                        Console.WriteLine(" takoy operaciu net ");
                        break;
                }
                Console.WriteLine(" dlya prodoljeniya najmite 'a'. vuhod-'v'");
                vuhod_vhod = Convert.ToChar(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
