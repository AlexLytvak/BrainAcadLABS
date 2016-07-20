using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexator
{
    class MyClass
    {
        private int x;
        private string name;
       private  string[] mas=new string[5]{"reg","reter","wrew","wtrrt","rtergter"};

        public string this[int i]
        {
            get
            {
                return mas[i];
            }
            set
            {
                mas[i] = value;
            }
        }

    }
}
