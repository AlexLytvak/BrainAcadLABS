using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_labs
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] mas = new int[4];
               // mas = null;  розблокувати для згенерування виключення
                if (mas==null)
                {
                    throw new ArgumentNullException(String.Format("Masuv ne stvoreno"));
                }

                try
                {
                   
                    for (int i = 0; i <= mas.Length; i++)
                    {
                        mas[i] = Enter();
                        if (mas[i]==0)
                            throw new Exception(String.Format("{1}  v masuvi z indexsom {0}", i,mas[i]));
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Eror: {0}", e.Message);
                   
                    Main();

                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Eror2:{0}", ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Pervopruchuna {0}", ex.InnerException);
                    }
                    Main();

                }
                catch (OverflowException exc)
                {
                    Console.WriteLine("Eror3:{0}", exc.Message);
                    Main();
                }
               
            }
            catch (Exception exception)
            {
                Console.WriteLine("Method:{0}; /n Mesage: {1}; /n Source:{2};", exception.TargetSite, exception.Message, exception.Source);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner exception: {0}", exception.InnerException.Message);
                }
              

            }



            Console.ReadLine();


        }

        public static  int  Enter()
        {
            Console.WriteLine("Vvedit chislo:");
            int i = 0;
            i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
      }
    }

