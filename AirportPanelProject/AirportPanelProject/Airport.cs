using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportPanelProject
{
     public  class  Airport:IAirport
    {
          public List<Price> pricelist = new List<Price>();
          public class Price
        {
              public  Port port{set;get;}
              public Aircompany aircompany { set; get; }
              public double priceEcon { set; get; }
              public double priceBusiness { set; get; }

              public Price()
              {
                  port = Port.Indefined;
                  aircompany = Aircompany.Indefended;
                  priceEcon = 0.0;
                  priceBusiness = 0.0;
              }
              public Price(int p, int ac,double prEc,double prBus)
              {
                  port = (Port)p;
                  aircompany = (Aircompany)ac;
                  priceEcon = prEc;
                  priceBusiness = prBus;
              }
             
        }
         public static int EnterInt()
         {
             bool flag = true;
             int i = -1;
             while (flag)
             {
                 try
                 {
                     i = Convert.ToInt32(Console.ReadLine());
                     flag = false;
                 }

                 catch (FormatException e)
                 {
                     Console.WriteLine("{0}", e.Message);
                     flag = true;
                 }
             }
             return i;

         }

         public static double EnterDouble()
         {
             bool flag = true;
             double i = -1;
             while (flag)
             {
                 try
                 {
                     i = Convert.ToDouble(Console.ReadLine());
                     flag = false;
                 }

                 catch (FormatException e)
                 {
                     Console.WriteLine("{0}", e.Message);
                     flag = true;
                 }
             }
             return i;
         }


         public  void EnterPrice()
         {
             
             Console.WriteLine("Vvedit napryamok:Lviv-2, Hharkiv-3, Odessa-4, Varshava-5, Rome-6, Stambul-7, Oslo-8, Kair-9, ");
             int napryamok = Airport.EnterInt();
             Console.WriteLine("Vvedit aviakompaniyu:MAY-1, GBA-2, TAI-3, OdessaAir-4, LvivAir-5");
             int company = Airport.EnterInt();
             Console.WriteLine("Vvedit vartist econom classu:");
             double econCost = Airport.EnterDouble();
             Console.WriteLine("Vvedit vartist biznes classu:");
             double bisCost = Airport.EnterDouble();
           
             pricelist.Add(new Price(napryamok, company, econCost, bisCost));
         }


         public void ShowPrice()
         {
             foreach(Price pr in pricelist)
             {
                 Console.WriteLine(" To-{0} |by {1} |COST Economy- {2} $; Business {3} $", pr.port, pr.aircompany, pr.priceEcon, pr.priceBusiness);
            }
         }



    }
}
