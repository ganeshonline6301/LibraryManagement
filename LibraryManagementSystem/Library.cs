using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int bookId;
        public string bookName;
        public string bookAuthor;
        public int bookCount;
        public int x;
    }
    public class BorrowDetails
    {
        public static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        public int userId;
        public string userName;
        public string userAddress;
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }
    public class Library
    {
        Book book = new Book();
        BorrowDetails borrow = new BorrowDetails();
        public List<Book> booklist = new List<Book>();
        public void AddBook()
        {  
            Console.WriteLine("Book Id:{0}", book.bookId = booklist.Count + 1);
            Console.WriteLine("Book Name:");
            book.bookName = Console.ReadLine();
            Console.WriteLine("Book Author:");
            book.bookAuthor = Console.ReadLine();
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            booklist.Add(book);
        }

        public void SearchBook()
        {

            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (booklist.Exists(x => x.bookId == find))
            {
                foreach (Book searchId in booklist)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book author :{2}\n" +
                        "No.of books available in library:{3}", searchId.bookId, searchId.bookName, searchId.bookAuthor,searchId.bookCount);
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }

        public void BorrowBook()
        {
            Console.WriteLine("User id : {0}", (borrow.userId = BorrowDetails.borrowList.Count + 1));
            Console.Write("Name :");
            borrow.userName = Console.ReadLine();
            Console.Write("Book id :");
            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.borrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.userAddress = Console.ReadLine();
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Borrowed Date - {0} and Borrowed Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());
            if(booklist.Exists(x => x.bookId == borrow.borrowBookId))
            {
                foreach (Book searchId in booklist)
                {
                    if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                    {
                        if (searchId.bookId == borrow.borrowBookId)
                        {
                            searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                            Console.WriteLine("Make Sure to return back borrowed books!!!!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.bookCount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }
            BorrowDetails.borrowList.Add(borrow);
        }

        public void ReturnBook()
        {
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (booklist.Exists(y => y.bookId == returnId))
            {
                foreach (Book addReturnBookCount in booklist)
                {
                    if (addReturnBookCount.x >= returnCount + addReturnBookCount.bookCount)
                    {
                        if (addReturnBookCount.bookId == returnId)
                        {
                            addReturnBookCount.bookCount = addReturnBookCount.bookCount + returnCount;
                            Console.WriteLine("Thanks for returning the books!!!!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Count exists the actual count");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("List of All books available in Library!!!!!!!!!");
            foreach(Book books in booklist)
            {
                Console.WriteLine("Book Id is: {0},"+
                    "{1},"+
                    "{2}\n",books.bookId,books.bookName,books.bookAuthor);
            }
        }
    }
}
