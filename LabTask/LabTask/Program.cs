using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabTask
{
    
    class Program
    {
        public static CancellationTokenSource cts = new CancellationTokenSource(); 
        public  static ConsoleKey key;
        static void Main(string[] args)
        {

            Task task1 = new Task(() => factorial(10));
            task1.Start();
            Cancel();
            //async await
            Task t = MyGetFactorialAsync(12);
            
           
            //ContinueWith
            Task<int> task3 = new Task<int>(() => Factorial(10));
            task3.Start();
            Cancel();
            t.Wait();
          
          
            Console.ReadLine();
        }
        public static void Cancel()
        {
            key = Console.ReadKey().Key;
            if (key == ConsoleKey.A)
                cts.Cancel();

        }

        static void factorial(object obj)
        {
            CancellationToken token = cts.Token;
            int res = 1;
            int k = (int)obj;

            for (int i = 1; i <= k; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операцiя пeрервана");
                    break;
                }
                Thread.Sleep(300);
                res *= i;
                Console.WriteLine("Factorial Task1 {0} --{1}",i, res);
            }


        }



        //async
        #region async
        public static async Task MyGetFactorialAsync(int x)
        {
            CancellationToken token2 = cts.Token;
            try
            {
                Task<int> task2Factorial = GetFactorialAsync(x, token2);
               
                int result = await task2Factorial;
                Console.WriteLine("Факториал Task2-{0} = {1}", x, result);
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cts.Dispose();
            }
        }

        public static async Task<int> GetFactorialAsync(int x, CancellationToken token2)
        {
            int result = 1;
            return await Task.Run(() =>
            {
                for (int i = 1; i <= x; i++)
                {
                    if (token2.IsCancellationRequested)
                    {
                        Console.WriteLine("Task2 vidmineno");
                        
                    }
                    result *= i;
                    Thread.Sleep(300);
                    Console.WriteLine("Factorial Task2-{0} - {1}", i, result);
                }
                return result;
            },token2);
        #endregion

        }
        //ContinueWith

        static int  Factorial(int k)
        {
            CancellationToken token3 = cts.Token;
            int res = 1;
            

            for (int i = 1; i <= k; i++)
            {
                if (token3.IsCancellationRequested)
                {
                    Console.WriteLine("Операцiя пeрервана");
                    break;
                }
                Thread.Sleep(100);
                res *= i;
                Console.WriteLine("Factorial Task3 {0} --{1}", i, res);
            }
            return res;
        }
      
       public static void ShowResult(Task<int> task3)
       {
           var result = task3.Result;
           Console.WriteLine("Factorial task3 ={0}", result);
       }


      
    }
}
