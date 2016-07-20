using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelBubleSort
{
    class DelSort
    {
        public static void Sort<T>(IList<T> SortArray, Func<T, T, bool> Compare)
        {   
            bool flag=true ;
            do{
                flag = false;
            for (int i = 0; i < SortArray.Count-1; i++)
            {
                
                if ( Compare(SortArray[i],SortArray[i+1]))
                {
                    T temp=SortArray[i];
                    SortArray[i]=SortArray[i+1];
                    SortArray[i+1]=temp;
                    flag = true;
                }
               
            }
           
            }
            while(flag);
        }
   
   
    }
}
