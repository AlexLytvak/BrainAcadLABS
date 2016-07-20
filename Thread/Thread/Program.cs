using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Thread
{
    class Program
    {
        public static int incrementField;
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Increment);
            
        }

        public static void Increment()
        {
            for(int i=0;i<20;i++)
            incrementField++;
            Console.WriteLine("icrfield {0}, {1}", incrementField, Thread.CurrentThread.ManagedThreadID);
        }

    }
}
