class Program
{
    static void Main(string[] args)
    {
        
        IEnumerable<int> list1 = new int[] {2,8,1,6,7,5,9,4,3} ;
        
        PrintNumbers(list1, n => n < 6,() => Console.WriteLine("Numbers less than 6:"));
        PrintNumbers(list1, n => n > 3, () => Console.WriteLine("Numbers bigger than 3:"));
        PrintNumbers(list1, n => n % 2 == 0,()=> Console.WriteLine("Even Numbers:"));
        PrintNumbers(list1, n => n % 2 == 1, () => Console.WriteLine("Odd Numbers:"));

        IEnumerable<decimal> list2 = new decimal[] { 2.1m, 8.4m, 1.6m, 6.4m, 7.7m, 5.8m, 9.3m, 4.1m, 3m };
        PrintNumbers(list1, n => n < 6, () => Console.WriteLine("Numbers less than 6:"));
        PrintNumbers(list1, n => n > 3, () => Console.WriteLine("Numbers bigger than 3:"));
        PrintNumbers(list1, n => n % 2 == 0, () => Console.WriteLine("Even Numbers:"));
        PrintNumbers(list1, n => n % 2 == 1, () => Console.WriteLine("Odd Numbers:"));
    }
    

    static void PrintNumbers<T>(IEnumerable<T> list , Predicate<T> filter , Action action)
    {
        action();
        foreach (var n in list)
        {
            if (filter(n)) Console.WriteLine(n);
        }
        Console.WriteLine("-----------");
    }

}

