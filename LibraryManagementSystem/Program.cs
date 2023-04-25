using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Program
    {
        //static Book book = new Book();
        //static BorrowDetails borrow = new BorrowDetails();


        static void Main(string[] args)
        {
            Library library = new Library();
            Console.Write("Welcome !!!\nEnter your password :");
            string password = Console.ReadLine();

            if (password == "Ganesh")
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\nMenu\n" +
                    "1)Add book\n" +
                    "2)Search book\n" +
                    "3)Borrow book\n" +
                    "4)Return book\n" +
                    "5)view all books\n" +
                    "6)Close\n\n");
                    Console.Write("Choose your option from menu :");

                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        library.AddBook();
                    }
                    else if (option == 2)
                    {
                        library.SearchBook();
                    }
                    else if (option == 3)
                    {
                        library.BorrowBook();
                    }
                    else if (option == 4)
                    {
                        library.ReturnBook();
                    }
                    else if(option == 5)
                    {
                        library.ViewAllBooks();
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("Thank you");
                        close = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option\nRetry !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
            Console.ReadLine();
        }
    }
}
