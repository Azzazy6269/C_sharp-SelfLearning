using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        FiveIntegers ints = new FiveIntegers(1, 2, 3, 4, 5);
        foreach (var i in ints)
        {
            Console.Write(i + " ");
        }
                
        
    }
}

class FiveIntegers : IEnumerable
{
    int[] _values;

    public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator() 
    {
        foreach (var item in _values)
        {
            yield return item;
        }
    }

}
/* Enumeration allows us to make a loop using foreach but you can't never select a specific element 
 * if you want a specific element you have to use indexers (ints[3]) 
 */
