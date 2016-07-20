using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_libreri
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryUser user1 = new LibraryUser();
            LibraryUser user2 = new LibraryUser("Hulio", "Pedrovich", 1, "911-01-01");
            bool flag = true;
            while (flag==true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" Dlya rabotu s programoy najmite cufru menu :");


                Console.WriteLine("0-EXIT; 1-INFO USER1; 2-INFO USER2; 3-ADD USER1's BOOK; 4-ADD USER2's BOOK;");
                Console.WriteLine("5-DELETE USER1's BOOK; 6-DELETE USER2's BOOK; 7-COUNT BOOKS of USER1; ");
                Console.WriteLine("8-COUNT BOOKS of USER2; 9-INFO BY INDEX BOOK USER1; 10-INFO BY INDEX BOOK USER2");
                int number_of_menu = Convert.ToInt16(Console.ReadLine());

                switch (number_of_menu)
                {
                    case 0:
                        {
                            flag=false;
                            break;
                        }
                    case 1:
                        {
                            user1.shouUser();
                            break;
                        }
                    case 2:
                        {
                            user2.shouUser();
                            break;
                        }
                    case  3:
                        {
                            Console.WriteLine("Add User1's book: ");
                            string book = Console.ReadLine();
                            user1.AddBook(book);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Add User2's book: ");
                            string book = Console.ReadLine();
                            user2.AddBook(book);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("enter the name of the book:");
                            string book = Console.ReadLine();
                            user1.RemoveBook(book);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("enter the name of the book:");
                            string book = Console.ReadLine();
                            user2.RemoveBook(book);
                            break;

                        }
                    case 7:
                        {
                           
                            int count=user1.BooksCount();
                            Console.WriteLine("the number of user1 books:{0}",count);
                            break;
                        }
                    case 8:
                        {
                            int count = user2.BooksCount();
                            Console.WriteLine("the number of user2 books:{0}", count);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Enter the index book user1:/0 to 10/ ");
                            int index = Convert.ToInt16(Console.ReadLine());
                            user1.BookInfo(index);
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Enter the index book user2:/0 to 10/ ");
                            int index = Convert.ToInt16(Console.ReadLine());
                            user2.BookInfo(index);
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }

            }

        
        
        
        
        }

 







    }
}
