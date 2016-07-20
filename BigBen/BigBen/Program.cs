using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBen
{
    class ClockEventArgs : EventArgs
    {
        public int Time;
    }

    class BigBen
    {
        public delegate void Clock();
        public event Clock ClockHandler;
        public void ClockSeventAM()
        {
            Console.WriteLine("Big Ben 7 am");
            ClockEventArgs args = new ClockEventArgs();
            args.Time = 18;

            ClockHandler(this,args);
        }
        public void ClockSixtPM()
        {
            ClockHandler();
        }
    }

    class Person
    {
        public string name;
        public BigBen ben;
        public Person(string name,BigBen ben)
        {
            this.name = name;
            this.ben = ben;
            this.ben.ClockHandler += BenClockHandler;
        }
        public void BenClockHandler(object sender, ClockEventArgs args)
        {
            if (args.Time == 7)
            {
            }
            else if (args.Time == 18)
            {
            }
                
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BigBen bigben = new BigBen();
            Person vasya =new Person("Vasya",bigben);
           
            bigben.ClockSeventAM();
        }
    }
}
