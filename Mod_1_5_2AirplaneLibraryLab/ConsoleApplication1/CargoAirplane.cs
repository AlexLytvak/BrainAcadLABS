using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AirplaneLibrary
{
    [AirplaneLibrary.AirplaneTypeAttribute(AirplaneLibrary.AirplaneTypes.CargoPlane)]
   public  class CargoAirplane
    {
        public void ShowAirplane()
        {
            Console.WriteLine("It is CargoAirplane ");
        }
    }
}
