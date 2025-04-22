using System.Runtime.InteropServices;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine(Calculate(3.3m, 8m, Add));
        Console.WriteLine(Calculate(3.3d, 8d, Substract));
        Console.WriteLine(Calculate(3, 8, Multiply));

    }

    static decimal Add(decimal n1, decimal n2) => n1 + n2;
    static double Substract(double n1 , double n2) => n1 - n2;
    static int Multiply(int n1 , int n2) => n1 * n2;

    public static T Calculate<T>(T n1 , T n2 , Func<T,T,T> calc)
    {
        return calc(n1, n2);
    }

}
