using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_Lab.Exception
{
   [Serializable]
  public  class MyException1:ApplicationException
    {
       public MyException1() { }

        public MyException1(string message) : base(message) { }

        public MyException1(string message, System.Exception inner) : base(message, inner) { }

    }
}
