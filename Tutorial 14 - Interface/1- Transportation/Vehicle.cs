abstract class Vehicle : IDrivable, IMaintainable  // abstract type
                                                   // you can inherit multiple interfaces but only one class
{
    protected string Brand;
    protected string Model;
    protected int year;

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        this.year = year;
    }

    public void move()
    {
        Console.WriteLine("Moving");
    }
    public void stop()
    {
        Console.WriteLine("Stopping");
    }
    public void Fuel()
    {
        Console.WriteLine("is fueling");
    }
    public void Maintain()
    {
        Console.WriteLine("is being fixed");
    }
}

