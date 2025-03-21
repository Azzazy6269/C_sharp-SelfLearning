using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class book
    {
            private string title;
            private string author;
            private uint id;
            private uint copiesAvailable;
        public book(string title, string author, uint id,uint copiesAvailable)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.copiesAvailable = copiesAvailable;
        }

        public book(string title, string author, uint id) : this(title , author , id , 1)
        {

        }

        
        public void borrowBook()
        {
            if (copiesAvailable > 0)
            {
                copiesAvailable--;
                Console.WriteLine($"a copy of {this.title} has been borrowd");
            }
            else
            {
                Console.WriteLine($"there is no copies of {this.title} at current time");
            }
        }
        public void returnBook()
        {
            copiesAvailable++;
            Console.WriteLine($"a copy of {this.title} has been returned");
        }

        public string showInfo()
        {
            return$"title : {this.title}\n" +
                  $"author : {this.author}\n" +
                  $"id : {this.id}\n" +
                  $"copiesAvailable : {this.copiesAvailable}\n";
        }
    }
}
