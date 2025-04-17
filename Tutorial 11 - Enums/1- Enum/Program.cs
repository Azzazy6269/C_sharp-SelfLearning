class Program
{
    static void Main (string[] args)
    {
        // Printing enum elemnts
        Console.WriteLine(Month.Feb); // Feb
        Console.WriteLine((int)Month.Feb); // 2
        Console.WriteLine((double)Month.Feb); // 2
        Console.WriteLine("---------------");


        // Treating with flag enums
        var day = DAY.Saturday | DAY.Tuesday;
        if (day.HasFlag(DAY.Weekend))
        {
            Console.WriteLine("It's weekend");
        }
        else
        {
            Console.WriteLine("It's Business day");
        }
        Console.WriteLine("---------------");


        // Enum.TryParse(stringValue x,out enumType y ) Converts stringValue into enumType
        // Enum.Parse(typeof(enumType),stringValue) Converts stringValue into enumType
        string x = "Feb";
        string y = "Jun";
        Enum.TryParse(x, out Month m);
        Console.WriteLine(m);
        Enum.Parse(typeof(Month),y);
        Console.WriteLine(y);
        Console.WriteLine("---------------");


        // Enum.IsDefined(typeof(enumType),stringValue)  is used to check if this variable is in enumName (return bool)
        string z = "Apr";
        var isdefined = Enum.IsDefined(typeof(Month),z);
        Console.WriteLine(isdefined);
        Console.WriteLine("---------------");


        // Loop in enum
        foreach (var month in Enum.GetNames(typeof(Month)))
        {
            Console.WriteLine($"{month} = {(int)Enum.Parse(typeof(Month),month)}");
        }
        Console.WriteLine("---------------");
        foreach (var month in Enum.GetValues(typeof(Month)))
        {
            Console.WriteLine($"{month} = {(int)month}");
           
        }
        /* Enum.GetNames returns an array of string elements
         * Enum.GetValues returns an array of enumType elements
         */

        

    }



    enum Month // default type : int
               // you can explicit casting it to (byte , sbyte , short , ushort , int , uint , long , ulong)
               // you can assign the same value to the more than one element 
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    enum Month_long : long  //available dataTypes(byte , sbyte , short , ushort , int , uint , long , ulong)
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    /* flag enumeration
     * means that the elements of the enum will be treated as bit fields
     * any element can take more than one value like Busday , Weekend
     */
    [Flags]
    enum DAY /* default type : byte (8 bits) 8 options only
              you can explicit casting it to (short : 16 bits) 16 options
                                             (int : 32 bits) 32 options
                                             (long : 64 bits) 64 options
             */
    {
        NONE = 0b_0000_0000,     //0
        Monday = 0b_0000_0001,   //1
        Tuesday = 0b_0000_0010,  //2
        Wednesday = 0b_0000_0100,//4
        Thursday = 0b_0000_1000, //8
        Friday = 0b_0001_0000,   //16
        Saturday = 0b_0010_0000, //32
        Sunday = 0b_0100_0000,   //64
        Businnessday = Saturday | Sunday | Monday | Tuesday | Wednesday, //0b0110_0111
        Weekend = Thursday | Friday //0b_0001_1000
    }

}

