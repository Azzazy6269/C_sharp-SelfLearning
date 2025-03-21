using Library;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        book[] books = new book[6];
        books[0] = new book("Embedded book", "DrPaul", 1, 26);
        books[1] = new book("AI book", "DrSamuel", 2, 7);
        books[2] = new book("JavaScript book", "DrJhon", 1);
        books[3] = new book("C# book", "DrEdrees", 1, 13);
        books[4] = new book("OOP book", "DrThomas", 1);
        books[5] = new book("Data structures book", "DrMax", 1, 42);

        books[4].borrowBook();
        books[1].returnBook();
        books[4].borrowBook();
        books[5].returnBook();
        books[2].borrowBook();
        books[4].returnBook();
        books[3].borrowBook();
        books[5].returnBook();
        books[4].borrowBook();
        books[4].returnBook();

        foreach (book b in books)
        {
            Console.WriteLine(b.showInfo());
        }
       
    }
}

