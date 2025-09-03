class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine($"DateTime.Now = {dt}");

        DateTimeOffset dts = DateTimeOffset.Now;
        Console.WriteLine($"DateTimeOffset.Now = {dts}");

        dts = DateTimeOffset.UtcNow;
        Console.WriteLine($"DateTimeOffset.UtcNow = {dts}");

        TimeSpan ts = new TimeSpan(2, 15, 0);
        dts = dts.Add(ts);
        Console.WriteLine($"DateTimeOffset.UtcNow after adding timespan = {dts}");

        dts = dts.AddDays(6);
        Console.WriteLine($"DateTimeOffset.UtcNow after adding days = {dts}");
        
        // Using extension DateTime methods 
        Console.WriteLine($"IsWeekEnd : {dt.IsWeekEnd()}");
        Console.WriteLine($"IsWeekDay : {dt.IsWeekDay()}");
        Console.WriteLine($"IsWeekEnd : {DateTimeExtension.IsWeekEnd(dt)}");
        Console.WriteLine($"IsWeekDay : {DateTimeExtension.IsWeekDay(dt)}");


    }
}

/*
 Meaning of Extension Methods
Extension methods in C# are a way to add new methods to an existing type (class, struct, or interface) without modifying the original source code and without creating a derived class.
It’s like you are “extending” the functionality of that type from the outside.

How They Work
You write them inside a static class.
The method itself must be static.
The first parameter must have the keyword this before the type you want to extend.

That tells the compiler: “Treat this method as if it belongs to that type.”

Examples
Adding new methods to the struct "string"
 */