using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        FiveIntegers ints = new FiveIntegers(1,2,3,4,5);
        foreach(var i in ints)
        {
            Console.Write(i + " ");
        }
    }
}

class FiveIntegers : IEnumerable  // An interface in c# . You have to override GetEnumerator() 
                                   
{
    int[] _values;

    public FiveIntegers(int n1,int n2,int n3,int n4,int n5)
    {
        _values = new[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator() => new Enumerator(this);/* Here we override GetEnumerator()
                                                                * we will create class called Enumerator which must have :
                                                                    public object Current
                                                                    public bool MoveNext()
                                                                    public void Reset()
                                                                * You don't have to implement class Enumerator . you will use 'yield'
                                                                * I can use yield keyword instead and it will create class Enumerator implicity
                                                                */

    class Enumerator : IEnumerator
    {
        int CurrentIndex = -1;
        FiveIntegers _integers;
        public Enumerator(FiveIntegers integers)
        {
            _integers = integers;
        }

        public object Current
        {
            get
            {
                if (CurrentIndex == -1)
                    throw new InvalidOperationException("Enumeration hasn't started");
                if (CurrentIndex > _integers._values.Length)
                    throw new InvalidOperationException("Enumeration has ended");
                return _integers._values[CurrentIndex];
            }
        }

        public bool MoveNext()
        {
            if (CurrentIndex >= _integers._values.Length)
                return false;
            return ++CurrentIndex < _integers._values.Length;
        }

        public void Reset() => CurrentIndex = -1;
        
    }
}

