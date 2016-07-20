using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using AirplaneLibrary;


namespace UnitTestAirplaneLibrary
{
    
    [TestClass]
    public class UnitTestAirplaneLibraryAtribut
    {
        [TestMethod]
        public void TestMethodAirplaneConstructor()
        {
            //arrange
            //act
            AirplaneLibrary.AirplaneTypeAttribute Uplane = new AirplaneLibrary.AirplaneTypeAttribute();
            AirplaneLibrary.AirplaneTypeAttribute Uplane2 = new AirplaneLibrary.AirplaneTypeAttribute(AirplaneTypes.TurboProp);
           

            //assert
            Assert.AreEqual(Uplane.Tipe, Uplane2.Tipe);

        }

        [TestMethod]
        public void TestCargoAttribute()
        {  //arrange
           
            //act
            AirplaneTypeAttribute[] MyAttribute = (AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(CargoAirplane), typeof(AirplaneTypeAttribute));
            //assert
            foreach (AirplaneTypeAttribute atr in MyAttribute)
            {
                if (atr == null)
                {
                    throw new NullReferenceException();
                }
                if (atr.Tipe != AirplaneTypes.CargoPlane)
                {
                    throw new Exception();
                }
            }
        }

        [TestMethod]
        public void TestUniversalplaneAttribute()
        {  //arrange
           
            //act
            AirplaneTypeAttribute[] MyAttribute = (AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(UniversalAirplane), typeof(AirplaneTypeAttribute));
            //assert
            foreach (AirplaneTypeAttribute atr in MyAttribute)
            {
                if (atr == null)
                {
                    throw new NullReferenceException();
                }
                if (atr.Tipe !=AirplaneTypes.TurboProp )
                {
                    throw new Exception();
                }
            }
        }



            [TestMethod]
        public void TestCargoAttributeCount()
        {  //arrange
            AirplaneTypeAttribute[] MyAttribute = (AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(CargoAirplane), typeof(AirplaneTypeAttribute));
            AirplaneTypeAttribute[] MyAttribute2 = (AirplaneTypeAttribute[])Attribute.GetCustomAttributes(typeof(UniversalAirplane), typeof(AirplaneTypeAttribute)); 
           //act
               
            for (int i = 0; i < MyAttribute.Length; i++)
            {
                //assert
                if (i >= 1)
                    throw new OverflowException();
            }
            for (int i = 0; i < MyAttribute2.Length; i++)
            {
                //assert
                if (i >= 1)
                    throw new OverflowException();
            }
        }








        }
    }

