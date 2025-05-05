using System.Collections;

class MyList<T> : IEnumerable
{
    private T[] _values;
    public T[] Values => _values; 
    public MyList(T[] array)
    {
        _values = array;
    }

    public IEnumerator GetEnumerator()
    {
        foreach (T i in _values)
        {
            yield return i;
        }
    }

    public T this[int index]
    {
        get 
        { 
            return _values[index];
        }
        set
        {
            _values[index] = value;
        }
        
    }

}