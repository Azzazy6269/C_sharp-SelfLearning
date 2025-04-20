class fish : Animal
{
    private bool IsSaltWater { get; set; }
    public fish(int id, string name, int age,string habitat, bool IsSaltWater) : base(id, name, age, habitat)
    {
        this.IsSaltWater = IsSaltWater;
    }
    public fish(int id, string name, string habitat, bool IsSaltWater) : base(id, name, 0, habitat) // for newborn
    {
        this.IsSaltWater = IsSaltWater;
    }
    public override void makeSound() 
    {
        
    }
    public sealed override void move()
    {
        Console.WriteLine($"{_name} is swimming");
    }
}