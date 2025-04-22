class Program
{
    static void Main(string[] args)
    {
        Action<string> print = Print;
        Func<int, int, int> add = Add;
        Predicate<int> iseven = IsEven;
        print("Asmaa");
        Console.WriteLine(add(6, 8));
        Console.WriteLine(IsEven(12));
    }
    static void Print(string name) => Console.WriteLine($"{name}");
    static int Add(int n1, int n2) => n1 + n2;
    static bool IsEven(int n) => n % 2 == 0;
    
}
// IEnumerable<T> , ICollection<T> , List<T>  are generic arrays provided from .Net
// Predicate<T> , Func<T> , Action<T> are generic delegates provided from .Net
// each one of them has different number of parameters to be <in> or <out>
// Predicate<T> , Func<T> , Action<T> can't treat with operators + ,- ,* ,/


