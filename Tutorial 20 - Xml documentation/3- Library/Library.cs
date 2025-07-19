using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_nameSpace;
namespace Library_nameSpace
{
    /// <summary>
    /// This class implements library and allow you to add info about books and Employees
    /// </summary>
    public class Library
    {
        private string _libName;
        private Book [] _books = new Book[500];
        /// <value> SuperVisior is libraryEmployee dataType </value>
        public libraryEmployee SuperVisior = new libraryEmployee();
        /// <value> librarian is libraryEmployee dataType </value>
        public libraryEmployee librarian = new libraryEmployee();
        /// <value> dustman is libraryEmployee dataType </value>
        public libraryEmployee dustman = new libraryEmployee();

        public string LibName
        {
            get => _libName;
            set { _libName = value; }
        }
        public Book this[int i] 
        {
            get => _books[i];
            set { _books[i] = value; }
        }
        public Library(string libName , Book[] books)
        {
            this._libName = libName;
            Array.Copy(books, _books, books.Length);
        }

        public delegate void NumOfBookChange(Library lib,int i );
        public event NumOfBookChange returnBookHandler;
        public event NumOfBookChange borrowBookHandler;
        /// <summary>
        /// Add Book to the Library list using <paramref name="book"/> . 
        /// this increases num of copies of this book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int AddBook(Book book)
        {
            for (int i = 0; i < 500; i++)
            {
               
                if (_books[i]!=null && _books[i].Title == book.Title)
                {
                    Console.WriteLine("Book is already exist");
                    return 0;
                }
            }
            for (int i = 0; i <= 500; i++) { 
                if (_books[i] == null) 
                {
                    _books[i] = book;
                    Console.WriteLine("book has been added");
                    return 1;
                }
            }
            return 0;
        }
        /// <summary>
        /// Borrow Book from the library using <paramref name="bookNmae"/> .
        /// this decreases num of copies of this book
        /// </summary>
        /// <param name="bookNmae"></param>
        /// <returns></returns>
        public int BorrowBook(string bookNmae)
        {
            for(int i=0; i<500; i++)
            {
                if (_books[i] != null && _books[i].Title == bookNmae && _books[i].NumOfCopies >0)
                {
                    borrowBookHandler(this, i);
                    return 1;
                    
                }
            }
            Console.WriteLine($"there's no copies of {bookNmae}");
            return 0;
        }
        /// <summary>
        /// Return Book that was borrowd before using <paramref name="bookNmae"/> .
        /// this increases num of copies of this book
        /// </summary>
        /// <param name="bookNmae"></param>
        /// <returns></returns>
        public int ReturnBook(string bookNmae)
        {
            for (int i = 0; i < 500; i++)
            {
                if (_books[i] != null && _books[i].Title == bookNmae )
                {
                    returnBookHandler(this, i);
                    return 1;
                }
            }
            Console.WriteLine($"{bookNmae} isn't in our system . Try to use AddBook method instead");
            return 0;
        }
        /// <summary>
        /// Prints all books of <paramref name="authorName"/>
        /// </summary>
        /// <param name="authorName"></param>
        public void ShowAuthorBooks(string authorName)
        {
            Console.WriteLine($"Books of {authorName} :");
            for (int i = 0; i < 500; i++)
            {

                if (_books[i] != null && _books[i].Author == authorName)
                {
                    Console.WriteLine($"   {_books[i].Title}  ");
                }
            }
        }
        /// <summary>
        /// LibraryEmployee class .
        /// defines any employee by his <paramref name="name"/> and <paramref name="salary"/>
        /// </summary>
        public class libraryEmployee
        {
            public string name { get; set; }
            public int salary { get; set; }

            public libraryEmployee()
            {
                
            }
            public libraryEmployee(string name, int salary)
            {
                this.name = name;
                this.salary = salary;
            }

        }
    }
}
