using RectangleSpace;


class Program
{
    public delegate void RectangleCalc(decimal width, decimal length);

    static void Main(string[] args)
    {
        var R1 = new Rectangle { Width = 5 , Length = 10 };
        R1.Calculate();
    }
}