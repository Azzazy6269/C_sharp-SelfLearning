class Program
{
    static void Main(string[] args)
    {
        var temp = new List<Temperature>();
        Random rand = new Random();
        for(var i = 0; i < 100; i++)
        {
            var x = rand.Next(-40, 60);
            temp.Add(new Temperature(x));
        }
        foreach(var i in temp)
        {
            Console.WriteLine(i.Value);
        }
        Console.WriteLine("---------------");
        temp.Sort();
        foreach (var i in temp)
        {
            Console.WriteLine(i.Value);
        }
    }
}

class Temperature : IComparable
{
    private int _value;
    public Temperature(int value)
    {
        _value = value;
    }
    public int Value => _value; // getter function

    public int CompareTo(object? obj)
    {
        if (obj is null)
            return 1;
        var temp = obj as Temperature;
        if (temp is null)
            throw new ArgumentException("obj isn't Temperature");
        return this.Value.CompareTo(temp.Value);
    }
}
/*IComparable is an interface in C# that allows you to define how objects of a class are compared to each other
 * we use it for comparing and sorting
 * What Does CompareTo Return?
     negative number → this object is less than the other.
     zero → this object is equal to the other.
     positive number → this object is greater than the other.
*/
