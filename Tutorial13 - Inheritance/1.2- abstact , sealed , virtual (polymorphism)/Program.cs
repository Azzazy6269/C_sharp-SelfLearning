class Program
{
    static void Main(string[] args)
    {
        Eagle e = new Eagle();
        Animal a = new Eagle(); // you made a variable of Animal dataType references an object of Eagle 
                                // There's no problem here as you didn't create an Animal object

    }
}

abstract class Animal // abstract means that you can't create an object of this class (you can't call a constructor) . 
{
    public virtual void move() // virtual member is able to be overrided
    {
        Console.WriteLine("Moving");
    }
    public abstract void eat(); // abstract member must be overrided . must be in abstract class
    
    
}

sealed class Eagle : Animal // sealed class means that you can't inherit it
{
    public override void move() // override to edit move()
    {
       // base.move(); // base is a keyword like this
        Console.WriteLine("Eagle moves");
    }
    public void  fly()
    {
        Console.WriteLine("Flying");
    }
    public override void eat() 
    {
        Console.WriteLine("Eagle is eating");
    }

}

class Falcon : Animal
{
    public sealed override void move() // sealed member is an overrided one that you can't override it again
    {
        Console.WriteLine("Falcon moves");
    }
    public void fly()
    {

    }
    public sealed override void eat()
    {
        Console.WriteLine("Falcon is eating");
    }

}

