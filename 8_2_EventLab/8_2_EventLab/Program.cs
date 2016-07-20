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
            Shop produkt = new Shop();

            var Ivan = new Person("Ivan");
            var Nik = new Person("Nik");
            produkt.add+= Ivan.Mesage;
            produkt.add += Nik.Mesage;
           
            produkt.Attention(produkt.Milk);
            produkt.Attention(produkt.Bread);
            produkt.Attention(produkt.Tea);

            Console.WriteLine("vidpusatus'");
            produkt.add -= Ivan.Mesage;
            produkt.Attention(produkt.Milk);

            Console.ReadLine();
        }
    }
}
