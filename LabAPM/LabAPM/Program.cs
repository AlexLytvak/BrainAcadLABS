using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LabAPM
{
    public delegate int  delfactorial(object obj);
 
    class Program
    {

        static void Main(string[] args)
        {
            delfactorial delfac=new delfactorial(GetFactorual);
            IAsyncResult beginres = Program.BeginFakt(10,delfac);
            Console.WriteLine("Main prodovjue roboty");
            int res = Program.EndFakt(beginres, delfac);
            Console.WriteLine("rezultat :{0}", res);
            Console.ReadLine();
        }         
         
         public   static  IAsyncResult BeginFakt(int i,delfactorial delfact1)
       {

           IAsyncResult resultObj = delfact1.BeginInvoke(i, new AsyncCallback(AsyncDel), "metod BeginInvoke");
           Console.WriteLine("BeginInvoke vukonavsya");
           return resultObj;
       }
        public static  int  EndFakt(IAsyncResult asyncResult,delfactorial d)
        {
            int res = d.EndInvoke(asyncResult);
            Console.WriteLine("EndInvoke vukonavsya");
            return res;
        }
        static int  GetFactorual(object  obj)
        {

            int a = (int)obj;
            int result = 1;
            for (int i = 1; i <=a; i++)
            {
                result *= i;
            }
            Thread.Sleep(400);
           
            Console.WriteLine("GetFactorial vukonavsya");
            return result;
        }
 
        static void AsyncDel(IAsyncResult resObj)
        {
            string mes = (string)resObj.AsyncState;
            Console.WriteLine(mes);
            Console.WriteLine("Asunhronuy delegat vuconavsya");
        }
    }

   

 //Cстворити класс TreadManipulyator - key consolekey
        //буду містити 3 метода  -ADOOne- виводить цикл 50 раз, шукае число що ділиться без остатку в тілі
        //використовувати ThreadSleep(2000)
        //AdoCustom виводить цикл 200 ми передаемо туди крок . Два метода зупиняються по буквам Q-для першої ф W-другої фун  Для цього консоль клас використовувати
      //Stop    key=Console.ReadKey().Key  
        // властивість ISBackground= true
//   створити поле кеу  
// в маін  запустити 2 потоки для Ado   1- для соstum  1 -для стоп 


    }

