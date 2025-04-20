class Program
{
    static void Main(string[] args)
    {
        Animal giraffe = new Animal("giraffe");
        Animal lion = new Animal("lion");
        Console.WriteLine(lion.ToString());
        Console.WriteLine(lion.GetType());
        Console.WriteLine(lion.Equals(giraffe));
        Console.WriteLine(lion.GetHashCode());

    }
}

// Any class is inherting Object by default unless you inherit from another one
// Object class has some methods that you can override : ToString(),GetType(),Equals(obj),GetHashCode() 
class Animal : Object // default even if i didn't write it
{
    public string name { get; set; }
    public Animal(string name)
    {
        this.name = name;
    }
    public override string ToString() 
    {
        // return base.ToString();
        return $"Animal : {this.name}";
    }
    
}

/*
Method	            Description
ToString()	        Returns a string representing the object. Default: returns the full type name unless overridden.
Equals(object obj)	Checks if two objects are equal (by default, reference equality).
GetHashCode()	    Returns an integer hash code, useful for hash-based collections.
GetType()	        Returns the runtime type of the object (System.Type).

 */