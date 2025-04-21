abstract class Animal
{
    protected readonly int _id;
    protected readonly string _name;
    protected int _age { get; set; }
    protected string _habitat { get; set; }
    protected bool _stillAlived { get; set; }
    public Animal(int id, string name, int age,string habitat)
    {
        this._id = id;
        this._name = name;
        this._age = age;
        this._habitat = habitat;
        this._stillAlived = true;
    }

    public abstract void move();
    public void eat()
    {
        Console.WriteLine($"{_name} is eating it's ordinary food");
    }
    public void eat(string food)
    {
        Console.WriteLine($"{_name} is eating it's {food}");
    }
    public void takesVaccine(string vaccine)
    {
        Console.WriteLine($"{_name} is vaccinating by {vaccine}");
    }
    public void grow()
    {
        ++_age;
        Console.WriteLine($"{_name}'s age became {_age}");
    }
    public void die()
    {
        _stillAlived = false;
        Console.WriteLine($"{_name} is dead");
    }
    public virtual void makeSound()
    {
        Console.WriteLine($"Animal {_name} makes a sound");
    }
    public override string ToString()
    { 
        if (_stillAlived)
        {
            return $"{_name} has {_age} years old";
        }
        return $"{_name} has died at age {_age}";
    }

}
