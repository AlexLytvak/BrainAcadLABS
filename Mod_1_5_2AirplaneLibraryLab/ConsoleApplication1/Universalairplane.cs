using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneLibrary
{
    [AirplaneLibrary.AirplaneTypeAttribute]
   public  class UniversalAirplane
    {
        public void ShowAirplane()
        {
            Console.WriteLine("It is UniversalAirplane ");
        }
    }
}
