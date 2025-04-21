class wild : Animal
{
    private bool Isdangerous { get; set; }
    public wild(int id, string name, int age, string habitat, bool Isdangerous) : base(id, name, age, habitat)
    {
        this.Isdangerous = Isdangerous;
    }
    public wild(int id, string name, string habitat, bool Isdangerous) : base(id, name, 0, habitat) // for newborn
    {
        this.Isdangerous = Isdangerous;
    }
    public sealed override void move()
    {
        Console.WriteLine($"{_name} is walking");
    }
}
