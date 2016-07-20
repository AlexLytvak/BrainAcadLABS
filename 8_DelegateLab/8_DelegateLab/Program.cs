using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DelegateLab
{
    class Program
    {



        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Calculator.operation oper;
            Console.WriteLine("Vvedit' chuslo:");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Vvedit diyu |+|-|*|/|");
                string znak = Console.ReadLine();
                Console.WriteLine("Vvedit' chuslo:");
                double b = Convert.ToDouble(Console.ReadLine());
                switch (znak)
                {
                    case "+":
                        {
                            oper = calc.sum;
                            calc.calculaited(oper, a, b);
                            break;
                        }
                    case "-":
                        {
                            oper = calc.minus;
                            calc.calculaited(oper, a, b);
                            break;
                        }
                    case "*":
                        {
                            oper = calc.mnojn;
                            calc.calculaited(oper, a, b);
                            break;
                        }
                    case "/":
                        {
                            oper = calc.dil;
                            calc.calculaited(oper, a, b);
                            break;
                        }
                    default:
                        {
                            throw new FormatException(String.Format("Ne korectnuy vvod sumvoly matematucnoi diyi"));
                           // break;
                        }

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0}", e.Message);
            }
            
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
                

            Console.ReadLine();
        }
   
    
    
    
    
    
    
    }
}
           
        
           
           
    
    
    

    


