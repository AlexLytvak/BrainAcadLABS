using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelBubleSort
{
    class Program
    {
        static void Main(string[] args)
        {   
            var rand=new Random(100);
            IList<Worker> listWorker=new List<Worker>();
            for (int i = 0; i < 10; i++)
            {
               
              listWorker.Add(new Worker("name"+i.ToString(),(float)rand.Next(1,100)));
              Console.WriteLine("{0} --{1}", listWorker[i].Name, listWorker[i].Salary);
            }
            Console.WriteLine();
             Func<Worker,Worker,bool>func=Worker.compare;

             DelSort.Sort(listWorker, func);
             foreach (var worker in listWorker)
             {
                 Console.WriteLine("{0} --{1}", worker.Name, worker.Salary);
             }
             Console.ReadLine();
        }
    }
}
