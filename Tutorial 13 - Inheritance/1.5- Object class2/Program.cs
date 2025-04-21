class Progarm
{
    static void Main(string[] args)
    {
        print("Osama");
        print("Ibraheem");
        print(26);
        print(new { FName = "Osama", LName = "Ibraheem", age = 26 });
        print(new Person());
        Person p = new Person();
        print(p);
    }

    static void print(object obj) // int , string , double , char , classType , interfaceType
    {
        Console.WriteLine(obj.ToString());
    }
}

class Person
{

}