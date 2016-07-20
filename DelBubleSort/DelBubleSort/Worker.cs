using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelBubleSort
{
    class Worker
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public Worker(string name, float sal)
        {
            Name = name;
            Salary = sal;
        }
        public static bool compare(Worker sal1, Worker sal2)
        {
            if (sal1.Salary > sal2.Salary)
                return true;
            else return false;
        }
    }
}
