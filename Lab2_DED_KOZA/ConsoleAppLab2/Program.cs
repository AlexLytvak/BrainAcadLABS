using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "ded";
            string dv = "ded+volk";
            string dkap = "ded+kap";
            string dkoz = "ded+koza";

            Console.WriteLine(d);
            Console.WriteLine(dv);
            Console.WriteLine(dkap);
            Console.WriteLine(dkoz);
            Console.WriteLine("Vvedite stroky :");

            string v = Console.ReadLine();
            bool umova = true;
            while (umova)
            {
                if (v == dkoz)
                {
                    string v1 = Console.ReadLine();
                    if (v1 == d)
                    {
                        string v2 = Console.ReadLine();
                        if (v2 == dv)
                        {
                            string v3 = Console.ReadLine();
                            if (v3 == dkoz)
                            {
                                string v4 = Console.ReadLine();
                                if (v4 == dkap)
                                {
                                    string v5 = Console.ReadLine();
                                    if (v5 == d)
                                    {
                                        string v6 = Console.ReadLine();
                                        if (v6 == dkoz)
                                        {
                                            Console.WriteLine("Peremoga");
                                        }
                                        else
                                            umova = false;
                                    }
                                }
                                else
                                    umova = false;
                            }
                            else
                                umova = true;
                        }
                        else
                            umova = false;
                    }
                    else
                        umova = false;
                }
                else
                    umova = false;

            }

            Console.WriteLine("proigrash");
            Console.ReadLine();
        }
    }
}