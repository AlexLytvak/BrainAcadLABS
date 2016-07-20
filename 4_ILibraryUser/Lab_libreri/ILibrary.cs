using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_libreri
{
   public interface ILibrary
    {
        void AddBook(string book);
        void RemoveBook(string book);
      
        int  BooksCount();
    }
}
