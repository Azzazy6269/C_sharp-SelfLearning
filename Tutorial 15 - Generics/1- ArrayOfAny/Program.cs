using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new Any<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);
        numbers.Add(6);
        numbers.Add(7);
        numbers.Disply();

        var persons = new Any<Person>();
        persons.Add(new Person { FName = "Essam", LName = "AbdElkader" });
        persons.Add(new Person { FName = "Yomna", LName = "Elsayed" });
        persons.Add(new Person { FName = "Sara", LName = "Mostafa" });
        persons.Add(new Person { FName = "Hesham", LName = "Isamail" });
        persons.Disply();

        
    }


}

class Person
{
    public string FName { get; set; }
    public string LName { get; set; }
    public override string ToString()
    {
        return $"{FName} {LName}";
    }
}
class Any<T>
{
    private T[] _items;
    public  int length { get => _items.Length; }
    public void Add(T item)
    {
        if(_items is null || length == 0)
        {
            _items = new T[]{ item };
        }
        else
        {
            var dest = new T[length + 1];
            for(int i = 0; i < length; i++)
            {
                dest[i] = _items[i];
            }
            dest[dest.Length - 1] = item;
            _items = dest;
        }
    }
    public void RemoveAt(int position)
    {
        if(position < length && position>=0 && _items != null)
        {
            var dest = new T[length - 1];
            bool checkedPosition = false;
            for(int i = 0; i < length; i++)
            {
                if(i != position)
                {
                    if(!checkedPosition) dest[i] = _items[i];
                    if (checkedPosition) dest[i - 1] = _items[i];
                }
                else
                {
                    checkedPosition = true;
                }
            }
            _items = dest;
        }
    }
    public void Disply()
    {
        Console.Write("[");
        for(int i =0;i< length; i++)
        {
            if(i < length - 1)
            {
                Console.Write($"{_items[i]},");
            }
            else
            {
                Console.Write($"{_items[i]}]\n");
            }
        }
    }
}

