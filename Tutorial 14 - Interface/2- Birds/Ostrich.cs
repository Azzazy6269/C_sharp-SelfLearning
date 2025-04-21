class Ostrich : IWalk , IEat
{
    public void move()
    {
        Console.WriteLine("Ostrich is walking");
    }

    public void stop()
    {
        Console.WriteLine("Ostrich stopped walking");
    }
}