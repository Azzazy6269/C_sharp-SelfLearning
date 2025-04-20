class bird : Animal
{
    private bool canFly { get; set; }
    public bird(int id, string name, int age,string habitat, bool canFly) : base(id,name,age,habitat)
    {
        this.canFly = canFly;
    }
    public bird(int id, string name, string habitat, bool canFly) : base(id, name, 0,habitat) // for newborn
    {
        this.canFly = canFly;
    }

    public sealed override void makeSound()
    {
        Console.WriteLine("bird chrips");
    }
    public sealed override void move()
    {
        Console.WriteLine($"{_name} is flying");
    }
}
