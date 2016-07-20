using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DelegateLab
{
    class Calculator
    {
        public delegate double operation(double a, double b);

        public void calculaited(operation del, double a, double b)
        {
            double s = del(a, b);
            Console.WriteLine("rezultat= {0}", s);
        }
        public double sum(double a, double b)
        {

            return a + b;
        }
        public double minus(double a, double b)
        {

            return a - b;
        }
        public double mnojn(double a, double b)
        {

            return b * a;
        }
        public double dil(double a, double b)
        {

            return a / b;
        }
    }
}
