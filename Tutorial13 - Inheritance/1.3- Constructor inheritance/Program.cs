class Program
{
    static void Main(string[] args)
    {
        Eagle e = new Eagle();
    }
}

class Animal
{
    private int _id;
    public Animal(int id)
    {
        _id = id;
    }
    public Animal()
    {

    }
    public void move() // public is visible for all classes (Eagle,Falcon & Program)
    {
        Console.WriteLine("Moving");
    }
    protected void eat() 
    {
        Console.WriteLine("Eating");
    }
}
class Eagle : Animal
{   
    // if you added parameter constructors or changed the default constructor in base class you have to add them explicity in the derived classes
    public Eagle(int id) : base(id)
    {
        
    }
    public Eagle() : base()
    {

    }
    public Eagle(string x) 
    {
        
    }
    public void fly()
    {
        Console.WriteLine("Flying");
    }
    public void EagleEat()
    {
        eat();
    }

}