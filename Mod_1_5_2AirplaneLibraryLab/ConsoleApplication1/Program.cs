using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace AirplaneLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
             Object[] MyPlane =
        (AirplaneLibrary.AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(AirplaneLibrary.CargoAirplane), typeof(AirplaneLibrary.AirplaneTypeAttribute));
            AirplaneLibrary.AirplaneTypeAttribute[] MyPlane2 = (AirplaneLibrary.AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(AirplaneLibrary.UniversalAirplane), typeof(AirplaneLibrary.AirplaneTypeAttribute));
            foreach (AirplaneLibrary.AirplaneTypeAttribute plane in MyPlane)
            {
                
                Console.WriteLine(plane.Tipe);
            }
            foreach (AirplaneLibrary.AirplaneTypeAttribute plane in MyPlane2)
            {

                Console.WriteLine(plane.Tipe);
            }

            //рефлексія без атрибутів
            Type myType = Type.GetType("AirplaneLibrary.CargoAirplane", false, true);
            Console.WriteLine(myType.ToString());
            foreach (MethodInfo meth in myType.GetMethods())
            {
                Console.WriteLine(meth.Name);
            }
          
          
            Console.ReadKey();
        }
    }
}
