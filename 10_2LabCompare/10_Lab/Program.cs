using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Animal >animals = new List<Animal>();
            animals.Add(  new Animal(4.4, "cat", 40));
            animals.Add(new Animal(40.4, "lion", 65));
            animals.Add(new Animal(19, "manky", 40));
            animals.Add(new Animal(20.4, "dog", 50));
            animals.Add(new Animal(19, "wolf", 70));
           
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }
            animals.Sort(new AnimalSortHelperWup());
            Console.WriteLine("Po zrostanyu vagu: druguy kruteriy shvudkist");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }

            animals.Sort(new AnimalSortHelperWdown());
            Console.WriteLine("Po zmenshenyu vagu:druguy kruteriy shvudkist");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }
            animals.Sort(new AnimalSortHelperMaxSpeedUp());
            Console.WriteLine("Po zrostanyu shvudkosti:druguy kruteriy vaga");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }
            animals.Sort(new AnimalSortHelperMaxSpeedDown());
            Console.WriteLine("Po zmenshenyu shvudkosti:druguy kruteriy vaga");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }

            animals.Sort(new AnimalSortHelperClassUp());
            Console.WriteLine("Po strokam:");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }
            
            animals.Sort(new AnimalSortHelperClassDown());
            Console.WriteLine("Po strokam v zvorotnyomy poryadku:");
            foreach (var anim in animals)
            {
                Console.WriteLine("{0,-4}-vaga|{1,-6}- vud|{2,-4}- shwudkist", anim.Weight, anim.Class, anim.MaxSpeed);
            }


            Console.ReadLine();

        }
    }
}
