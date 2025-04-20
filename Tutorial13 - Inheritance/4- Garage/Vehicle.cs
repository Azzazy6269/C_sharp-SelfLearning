public abstract class Vehicle
{
    public Vehicle(int id, string model, string brand, decimal fuelLitres, decimal maxFuel, bool isRunning)
    {
        Id = id;
        Model = model;
        Brand = brand;
        FuelLitres = fuelLitres;
        MaxFuel = maxFuel;
        IsRunning = isRunning;
    }

    protected int Id { get; set; }
    protected string Model { get; set; }
    protected string Brand { get; set; }
    protected decimal FuelLitres { get; set; }
    protected decimal MaxFuel { get; set; }
    protected bool IsRunning { get; set; }

    protected void Start()
    {
        Console.WriteLine($"{Brand} {Model} start moving");
        IsRunning = true;
    }
    protected void Stop()
    {
        Console.WriteLine($"{Brand} {Model} stop moving");
        IsRunning = false;
    }
    protected void Refuel(double amount)
    {
        FuelLitres = MaxFuel;
    }
    private string checkStatus()
    {
        if (FuelLitres <= (0.33m * MaxFuel))  return"low fuel";
        if (FuelLitres <= (0.66m * MaxFuel)) return "moderate fuel";
        return "high fuel";
    }
    protected abstract void Drive(decimal km);
    public override string ToString()
    {
        return $"\nId : {Id}\n" +
               $"Type :{this.GetType()}\n" +
               $"Brand : {Brand}\n" +
               $"Model : {Model}\n" +
               $"Fuel level : {FuelLitres} litre\n" +
               $"Fuel status : {checkStatus()}\n" +
               $"Is running : {IsRunning}\n";
    }
}