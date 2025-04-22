class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> list1 = new int[] {1,2,3,4,5,6,7,8,9} ;
        Console.WriteLine("Numbers less than 6:");
        PrintNumbers(list1, n => n < 6);
        Console.WriteLine("Numbers bigger than 3:");
        PrintNumbers(list1, n => n > 3);
        Console.WriteLine("Even Numbers:");
        PrintNumbers(list1, n => n % 2 == 0);
        Console.WriteLine("Odd Numbers:");
        PrintNumbers(list1, n => n % 2 == 1);
    }
    public delegate bool Filter(int number);

    static void PrintNumbers(IEnumerable<int> list , Filter filter)
    {
        foreach (var n in list)
        {
            if (filter(n)) Console.WriteLine(n);
        }
        Console.WriteLine("-----------");
    }

}

