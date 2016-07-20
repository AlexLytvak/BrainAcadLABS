using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_Lab.Exception
{
    
    
        [Serializable]
        public class MyException2 : System.Exception
        {
            public MyException2() { }
            public MyException2(string message) : base(message) { }
            public MyException2(string message, System.Exception inner) : base(message, inner) { }
            protected MyException2(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context)
                : base(info, context) { }




      


        }
    }
