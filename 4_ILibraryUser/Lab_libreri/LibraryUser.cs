using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_libreri
{
    class LibraryUser:ILibrary
    {
        private string firstName;
        private string lastName;
        private int id;
        private string phone;
        static private int BOOKLimit=10;
        private string[] bookList=new string[BOOKLimit];

        public  string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public int Id
        {
            get { return id; }
        }
        public string  Phone
        {
            get { return phone; }
            set { this.phone = Phone; }
        }
        public int BookLimit
        {
            get { return BOOKLimit; }
        }

        public LibraryUser()
        {
            this.firstName="first";
            this.lastName="last";
            this.id = -1;
            this.phone = "none";

        }
        public LibraryUser(string name, string lastname, int id, string phone)
        {
            this.firstName = name;
            this.lastName = lastname;
            this.phone = phone;
        }
        public string this[int i]
        {
            get
            {
                return bookList[i];
            }
            set
            {
                bookList[i] = value;
            }
        }

       public void  AddBook(string book)
        {
           
            for (int i = 0; i < bookList.Length; i++)
            {
                if (String.IsNullOrEmpty(bookList[i]))
                {
                    bookList[i] = book;
                    break;
                }
                
             }
            bool flag = false;
            for (int i = 0; i < bookList.Length; i++)
            {  
                
                if (bookList[i] == book)
                {
                    Console.WriteLine("book << {0} >> added", book);
                    flag=true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("book << {0} >> did not add. limit is exceeded!!!", book);
            }
          

        }

       public int BooksCount()
       {
           int count=0;
           for (int i = 0; i < bookList.Length; i++)
           {
               if (!String.IsNullOrEmpty(bookList[i]))
               {
                   count++;
               }
           }
           return count;
       }
       public void RemoveBook(string book)
       {
           bool flag = false;
           for (int i = 0; i < bookList.Length; i++)
           {
               if (bookList[i] == book)
               {
                   bookList[i] = null;
                   Console.WriteLine("Book << {0} >> deleted", book);
                   flag = true;
                   break;
               }
           }
           if (flag == false)
           {
               Console.WriteLine("Takoy knigi << {0} >> net v kartochke chitatelya!!!", book);
           }
       }

      public  void BookInfo(int index )
       {
           if (index > this.bookList.Length)
           {
               Console.WriteLine("Index {0} out of range", index);
           }
           else
           {
               Console.WriteLine(" Book of index {0} is <<{1}>>", index, this[index]);
           }
       }

      public void shouUser()
       {
           Console.WriteLine("{0} {1}; ID-{2}; Phone-{3}", this.FirstName, this.LastName, this.Id, this.Phone);
       }






       

    }

   
}
