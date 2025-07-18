﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_nameSpace;
namespace Library_nameSpace
{
    /// <include file='Docs.xml' path='doc/members/member[@name="T:Library_nameSpace.Library"]/*'/>
    public class Library
    {
        private string _libName;
        private Book [] _books = new Book[500];
        /// <include file='Docs.xml' path='doc/members/member[@name="F:Library_nameSpace.Library.SuperVisior"]'/>
        public libraryEmployee SuperVisior = new libraryEmployee();
        /// <include file='Docs.xml' path='doc/members/member[@name="F:Library_nameSpace.Library.librarian"]'/>
        public libraryEmployee librarian = new libraryEmployee();
        /// <include file='Docs.xml' path='doc/members/member[@name="F:Library_nameSpace.Library.dustman"]'/>
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
        /// <include file='Docs.xml' path='doc/members/member[@name="M:Library_nameSpace.Library.AddBook(Book_nameSpace.Book)"]'/>
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
        /// <include file='Docs.xml' path='doc/members/member[@name="M:Library_nameSpace.Library.BorrowBook(System.String)"]'/>
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
        /// <include file='Docs.xml' path='doc/members/member[@name="M:Library_nameSpace.Library.ReturnBook(System.String)"]'/>
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
        /// <include file='Docs.xml' path='doc/members/member[@name="M:Library_nameSpace.Library.ShowAuthorBooks(System.String)"]'/>
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
        /// <include file='Docs.xml' path='doc/members/member[@name="T:Library_nameSpace.Library.libraryEmployee"]'/>
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
