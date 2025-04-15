using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Library_nameSpace;

namespace Book_nameSpace
{
    public class Book
    {
        private string _title;
        private string _author;
        private UInt16 _year;
        private double _numOfCopies;

        public string Title
        {
            get =>  _title; 
            set { _title = value; }
        }
        public string Author
        {
            get => _author;
            set { _author = value; }
        }
        public UInt16 Year
        {
            get => _year;
            set { if (value >= 1800 && value <= DateTime.Now.Year) 
                    {
                        _year = value;
                    } else
                    {
                        _year = 0;
                    }
            }
        }
        public bool IsAvailable
        {
            get => _isAvailable;
            set { _isAvailable = value; }
        }
        public double NumOfCopies
        {
            get => _numOfCopies;
            set { _numOfCopies = value; }
        }

        public Book(string title , string author , UInt16 year , double numOfCopies)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.NumOfCopies = numOfCopies;
        }
        public Book(string title, string author) : this(title, author, 0, 1) { }
        public Book(string title, string author, UInt16 year) : this(title, author, year, 1) { }
        public Book(string title, string author, double numOfCopies) : this(title, author, 0, numOfCopies) { }


    }
}
