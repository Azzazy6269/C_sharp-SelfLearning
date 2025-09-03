using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Console.ReadLine().WordCount());

    }
}

static class StringExtension
{
    public static int WordCount(this String value)
    {
        string [] newValue =  value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return newValue.Length;
    }
}