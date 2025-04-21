using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var persons = new AnyClass<Person>();
        persons.Add(new Person("Essam", "AbdElkader"));
        persons.Add(new Person("Yomna",  "Elsayed"));
        persons.Add(new Person( "Sara", "Mostafa"));
        persons.Add(new Person( "Hesham", "Isamail"));
        persons.Disply();
    }
}

class Person
{
    private string FName { get; set; }
    private string LName { get; set; }
    public Person() // you have to  add parameterless constructor to this class to apply the requirments of AnyClass<T>
                    // as you can't add new(string x,string y) as generic constraint
    {
        
    }
    public Person(string FName , string LName)
    {
        this.FName = FName;
        this.LName = LName;
    }
    public override string ToString()
    {
        return $"{FName} {LName}";
    }
}

//Constraint is some descriptions to the dataType T 
class AnyClass<T> where T : class, new()/* Constraint is some descriptions to the dataType T 
                                         * we added class to avoid dataTypes like int , double ,float ,bool
                                         * but string is still available so we added new() as string doesn't created using constructors
                                         * 
                                         */
{
    private T[] _items;
    public int length { get => _items.Length; }
    public void Add(T item)
    {
        if (_items is null || length == 0)
        {
            _items = new T[] { item };
        }
        else
        {
            var dest = new T[length + 1];
            for (int i = 0; i < length; i++)
            {
                dest[i] = _items[i];
            }
            dest[dest.Length - 1] = item;
            _items = dest;
        }
    }
    public void RemoveAt(int position)
    {
        if (position < length && position >= 0 && _items != null)
        {
            var dest = new T[length - 1];
            bool checkedPosition = false;
            for (int i = 0; i < length; i++)
            {
                if (i != position)
                {
                    if (!checkedPosition) dest[i] = _items[i];
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
        for (int i = 0; i < length; i++)
        {
            if (i < length - 1)
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

/*
Constraint	   Meaning
class	       Type must be a reference type
struct         Type must be a non-nullable value type
unmanaged	   Type must be an unmanaged type (no references; good for interop/unsafe code)
notnull	       Type must be a non-nullable type (value type or non-nullable reference type)
new()	       Type must have a public parameterless constructor
BaseClass	   Type must inherit from or be the specified base class
InterfaceName  Type must implement the specified interface
U : T	       One type parameter must be a subclass or implementation of another
 */
 