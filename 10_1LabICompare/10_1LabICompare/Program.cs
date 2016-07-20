using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1LabICompare
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(4.4, "cat", 40));
            animals.Add(new Animal(40.4, "lion", 65));
            animals.Add(new Animal(20.4, "dog", 60));
            animals.Add(new Animal(16, "wolf", 85));
            foreach (var anim in animals)
            {
                Console.WriteLine("{0}-vaga  |{1}- vud  |{2}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }
            animals.Sort();
            Console.WriteLine("Pislya sortuvannya");

            foreach (var anim in animals)
            {
                Console.WriteLine("{0}-vaga  |{1}- vud  |{2}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }

            Console.ReadLine();
        }
    }
}
