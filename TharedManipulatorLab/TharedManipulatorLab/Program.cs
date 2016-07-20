using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TharedManipulatorLab
{
    //Cстворити класс TreadManipulyator - key consolekey
    //буду містити 3 метода  -ADOOne- виводить цикл 50 раз, шукае число що ділиться без остатку в тілі
    //використовувати ThreadSleep(2000)
    //AdoCustom виводить цикл 200 ми передаемо туди крок . Два метода зупиняються по буквам Q-для першої ф W-другої фун  Для цього консоль клас використовувати
    //Stop    key=Console.ReadKey().Key  
    // властивість ISBackground= true
    //   створити поле кеу  
    // в маін  запустити 2 потоки для Ado   1- для соstum  1 -для стоп 

    class Program
    {
        public static string key;
        static bool stopThread1 = false;
        static bool stopThread2 = false;
        static void Main(string[] args)
        {

            Thread ThreadOne1 = new Thread(new ThreadStart(ThreadManipulyator.AdoOne));
            Thread ThreadOne2 = new Thread(new ThreadStart(ThreadManipulyator.AdoOne));
            Thread ThreadCustom1 = new Thread(new ParameterizedThreadStart(ThreadManipulyator.AdoCustom));
            Thread ThreadStop = new Thread(ThreadManipulyator.Stop);
            ThreadStop.IsBackground = true;
            Console.WriteLine("Для перериварня 'Q''W'");
            ThreadStop.Start();
            ThreadOne1.Start();
            ThreadOne2.Start();
            ThreadCustom1.Start(4);


            Console.ReadLine();
            Console.ReadLine();
        }


        public class ThreadManipulyator
        {
            static object locker = new object();

            public static void AdoOne()
            {



                for (int i = 0; i < 50; i++)
                {

                   
                    if (stopThread1)
                    {
                        Console.WriteLine("potic perervano");
                        break;
                    }




                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0}+  ", i);
                    }
                    Thread.Sleep(300);

                }


            }
            public static void AdoCustom(object step)
            {
                int st = Convert.ToInt32(step);
                for (int i = 0; i < 200; i += st)
                {
                    if (stopThread2)
                    {
                        Console.WriteLine("potic 2 perervano");
                        break;
                    }




                    if (i % 2 == 0)
                    {
                        Console.WriteLine("{0}/  ", i);
                    }
                    Thread.Sleep(500);
                }
            }


            public static void Stop()
            {
                while (true)
                {

                  key=  Console.ReadLine();

                    if (key == "q" )
                        stopThread1 = true;
                    if (key =="w")
                        stopThread2 = true;
                    Thread.Sleep(500);
                }


            }


            
        }
    }
}
