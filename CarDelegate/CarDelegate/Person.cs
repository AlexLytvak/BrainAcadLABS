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
        public string Name{get;set;}


        public Person(string name)
        {
            Name = name;
        }
        public void Mesage(string str)
        {
            Console.WriteLine(str + "- in the shop");
        }
        public void MesageOut(string str)
        {
            Console.WriteLine(str + "- ended in the shop");
        }
    }
}
