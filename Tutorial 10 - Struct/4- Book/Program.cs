class Program
{
    static void Main(string[] args)
    {
        Book b1 = new Book("Clean Code", "Robert C. Martin", 464, new DateTime(2008,5,12));
        b1.GetSummary();
        b1.HowYearsOldTheBook();
    }
}

readonly struct Book
{
    readonly string _title;
    readonly string _author;
    readonly int _pages;
    readonly DateTime _publishedDate;

    public Book(string title , string author, int pages, DateTime publishedDate)
    {
        this._title = title;
        this._author = author;
        this._pages = pages;
        this._publishedDate = publishedDate;
    }

    public void GetSummary()
    {
        Console.WriteLine($"The book '{this._title}' by {this._author} has {this._pages} pages and was published in {this._publishedDate.Year} .");
    }

    public void HowYearsOldTheBook()
    {
        Console.WriteLine($"The book was published {DateTime.Now.Year - _publishedDate.Year} years ago");
    }

}