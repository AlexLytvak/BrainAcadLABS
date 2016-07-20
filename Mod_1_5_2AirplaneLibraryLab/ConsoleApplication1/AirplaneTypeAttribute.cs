using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AirplaneLibrary
{
   
  public   enum AirplaneTypes { SportPlane, CargoPlane, TurboProp, Jet }


[System.AttributeUsage(System.AttributeTargets.Class,
                       
                       AllowMultiple = true,Inherited=true)]


    public class AirplaneTypeAttribute:System.Attribute
    {

   
    public AirplaneTypes Tipe { set; get; }

       
    public AirplaneTypeAttribute()
    {
        Tipe = AirplaneTypes.TurboProp;
    }

    public AirplaneTypeAttribute(AirplaneTypes t)
    {
        Tipe = t;
    }

   

      

    }
}
