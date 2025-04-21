using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        var persons = new List<Person>(); // List is type safe as it depends on generics
        persons.Add(new Person("Hesham", "Ibraheem"));
        persons.Add(new Person("Mona", "Omran"));
        persons.Add(new Person("Menna", "Ibraheem"));
        persons.Insert(1, new Person("othman", "Maged"));
        persons.Clear();
        persons.Add(new Person("Hesham", "Ibraheem"));
        persons.Add(new Person("Mona", "Omran"));
        persons.Add(new Person("Menna", "Ibraheem"));
        persons.Insert(1, new Person("othman", "Maged"));
        persons.RemoveAt(2);
        for (int i = 0; i < persons.Count; i++) Console.WriteLine(persons[i]);

        var arr = new ArrayList(); // ArrayList isn't type safe(can contain many dataTypes)
        arr.Clear();
        arr.Add(1);
        arr.Add("Kareem");
        arr.Add(true);
        arr.Add(new Person("Menna", "Ibraheem"));
        arr.Insert(3, 6);
        for (int i = 0; i < arr.Count; i++) Console.WriteLine(arr[i]);

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
    public Person(string FName, string LName)
    {
        this.FName = FName;
        this.LName = LName;
    }
    public override string ToString()
    {
        return $"{FName} {LName}";
    }
}