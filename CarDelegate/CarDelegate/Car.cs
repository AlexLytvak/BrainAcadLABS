using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_EventLab
{
    class Car
    {
        public int CurrwntSpeed { get; set; }
        public int Maxspeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        public Car()
        {
            Maxspeed = 100;
        }
        public Car(string name, int MaxSp, int currSp)
        {
            CurrwntSpeed = currSp;
            Maxspeed = MaxSp;
            PetName = name;
        }
        //
        public delegate void CarEngHendler(string msg);
        public event CarEngHendler Exploded;
        public event CarEngHendler AboutToBlow;

        //public void RegisterWithCarengine(CarEngHendler methodToCall)
        //{
        //    listOfhandlers = methodToCall;
        //}
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded("Sorry,this car is dead");
            }
            else
            {
                CurrwntSpeed += delta;
                if (10 == Maxspeed - CurrwntSpeed && AboutToBlow != null)
                {
                    AboutToBlow("Carefull boddy! Gonna blow!");
                }
                if (CurrwntSpeed >= Maxspeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed={0}", CurrwntSpeed);
            }
        }

             
    }
}
