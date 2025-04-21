class Lorry : Vehicle , ILoader //concrate type
{
    public Lorry(string brand, string model, int year) : base(brand, model, year)
    {

    }

    public void Load()
    {
        Console.WriteLine("Loading");
    }

    public void Unload()
    {
        Console.WriteLine("UnLoading");
    }
}

