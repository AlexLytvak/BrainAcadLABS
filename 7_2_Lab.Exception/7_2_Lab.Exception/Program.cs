using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_Lab.Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vvedit kilkist' elementiv masuve:");
                int Max = Convert.ToInt32(Console.ReadLine());
                int[] mas = new int[Max];
                if (Max < 1)
                {
                    throw new MyException2();
                }
                int sum = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Enter();
                    sum += mas[i];
                    OpenInner();
                    if (sum > 100)
                        throw new MyException3();
                }
            }
            catch (MyException1 )
            {
                Console.WriteLine("Element ne povunrn bytu -0 ");
               
            }
            catch (MyException2 )
            {

                Console.WriteLine("Masuv povunen bytu bil'she nij 0");
            }
            catch (MyException3 e)
            {
                Console.WriteLine("Pomulka zovnishnay");
                if (e.InnerException != null)
                Console.WriteLine("Inner exception: {0}", e.InnerException);
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0}", e.Message);
            }

            Console.ReadLine();
        }

        public static int Enter()
        {
            Console.WriteLine("Vvedit chuslo:");
            int i=Convert.ToInt32(Console.ReadLine());
            if (i ==0)
                throw new MyException1();
            else
                return i;
        }

        public static void MakeInner()//генеруємо помилку
        {
            throw new MyException3("Zgenerovana pomulka.");
        }

        public static  void OpenInner()//ловимо помилку
        {
            try
            {
                MakeInner();
            }
            catch (MyException3 ex)
            {
                throw new MyException3("Pomulka v metodi MakeInner", ex);
            }
        }

    }
}
