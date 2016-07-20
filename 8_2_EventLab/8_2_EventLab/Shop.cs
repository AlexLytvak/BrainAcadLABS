using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_EventLab
{
   
    class Shop
    {
       
        public string Milk { get; set; }
        public string  Bread { get; set; }
        public string Tea { get; set; }

        public Shop()
        {
            Milk ="milk";
            Bread ="bread";
            Tea ="tea";
        }

        public delegate void Funchandler(string msg);
        public event Funchandler add;
       

        public void Attention(string str)
        {
            
            
                if (add != null)
                {
                    add(str);
                }
            
           
        }


    }
}
