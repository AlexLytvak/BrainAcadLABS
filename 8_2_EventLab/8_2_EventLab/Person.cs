using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_EventLab
{
    
    class Person
    {
        private string name;
        public string Name { get{return name;} set { name = value; } }


        public Person(string name)
        {
            Name = name;
        }
        public void Mesage(string str)
        {
            
            if (this.name == "Ivan" && str == "milk")
            {
              
            }
            else
                Console.WriteLine("{0}!!! " + str + "- in the shop", this.Name);

        }
       
    }
}
