using Library_nameSpace;
using Book_nameSpace;
using System.Xml.Linq;
using System.ComponentModel.Design.Serialization;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        var books1 = new Book[]
        {
            new Book("Tale of Two Cities", "Charles Dickens", 1859, 8.0),
            new Book("Thus Spoke Zarathustra", "Friedrich Nietzsche", 1883),
            new Book("Pride and Prejudice", "Jane Austen", 1813, 9.0),
            new Book("1984", "George Orwell", 1949, 9.0),
            new Book("To Kill a Mockingbird", "Harper Lee", 1961, 19.0),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 28.0),
            new Book("Moby Dick", "Herman Melville", 1851, 7.0),
            new Book("War and Peace", "Leo Tolstoy", 1869, 9.0),
            new Book("The Brothers Karamazov", "Fyodor Dostoevsky", 1880, 9.0),
            new Book("Crime and Punishment", "Fyodor Dostoevsky", 1866, 8.0),
            new Book("Jane Eyre", "Charlotte Brontë", 1847, 1.0),
            new Book("Brave New World", "Aldous Huxley", 1932, 1.0),
            new Book("The Catcher in the Rye", "J.D. Salinger", 1951, 0.0),
            new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954, 9.0),
            new Book("The Hobbit", "J.R.R. Tolkien", 1937, 9.0),
            new Book("Don Quixote", "Miguel de Cervantes", 1605, 6.0),
            new Book("Les Misérables", "Victor Hugo", 1862, 11.0),
            new Book("The Divine Comedy", "Dante Alighieri", 1320, 14.0),
            new Book("Frankenstein", "Mary Shelley", 1818, 8.0),
            new Book("Dracula", "Bram Stoker", 1897, 7.0),
            new Book("Fahrenheit 451", "Ray Bradbury", 1953, 8.0),
            new Book("Wuthering Heights", "Emily Brontë", 1847, 2.0),
            new Book("Anna Karenina", "Leo Tolstoy", 1878, 9.0),
            new Book("Ulysses", "James Joyce", 1922, 13.0),
            new Book("One Hundred Years of Solitude", "Gabriel García Márquez", 1967, 20.0),
            new Book("The Sound and the Fury", "William Faulkner", 1929, 7.0),
            new Book("Beloved", "Toni Morrison", 1987, 8.0),
            new Book("Lolita", "Vladimir Nabokov", 1955, 4.0),
            new Book("The Stranger", "Albert Camus", 1942, 10.0),
            new Book("A Clockwork Orange", "Leo Tolstoy", 1962, 8.0),
        };


        Library l1 = new Library("Alex library", books1);
        l1.SuperVisior.name = "Ahmed ";
        l1.SuperVisior.salary = 8000;
        l1.librarian.name = "Aya";
        l1.librarian.salary = 3500;
        l1.dustman.name = "AbdulRahman";
        l1.dustman.salary = 3500;


        l1[4].Year = 1960;
        l1[29].Author = "Anthony Burgess";
        l1.borrowBookHandler += BorrowProcess;
        l1.returnBookHandler += ReturnProcess;
        Book b1 = new Book("Elayam", "Taha Hussien");
        Book b2 = new Book("Anna Karenina", "Leo Tolstoy");
        l1.AddBook(b1);
        l1.AddBook(b2);
        l1.BorrowBook("Crime and Punishment");
        l1.ReturnBook("To Kill a Mockingbird");

        l1.ShowAuthorBooks("Charles Dickens");

    }
    public static void BorrowProcess(Library lib,int i)
    {
        lib[i].NumOfCopies--;
        Console.WriteLine($"{lib[i].Title} : Successful borrow process . num of copies {lib[i].NumOfCopies}");
    }
    public static void ReturnProcess(Library lib,int i)
    {
        lib[i].NumOfCopies++;
        Console.WriteLine($"{lib[i].Title} : Successful return process . num of copies {lib[i].NumOfCopies}");
    }
}

