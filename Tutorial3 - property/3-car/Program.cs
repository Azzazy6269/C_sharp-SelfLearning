class Program
{
    static void Main()
    {
        car c1 = new car("BMW", "X7", 2022, 8_000_000, false);
        car c2 = new car("Mercedes", "EQ200", 2025, 5_000_000, true);
        car c3 = new car("Jeep", "cherokee", 2007, 1_500_000, false);

        Console.WriteLine(c1.showInfo());
        Console.WriteLine(c2.showInfo());
        Console.WriteLine(c3.showInfo());
    }
}

public class car
{
    private string _brand;
    private string _model;
    private ushort _year;

    public car(string brand , string model , ushort year , uint price , bool isElectric)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Price = price;
        IsElectric = isElectric;
    }   
    public string Brand
    {
        get
        {
            return _brand;
        }
        set
        {
            _brand = value != null ? value : "Unkown";
        }
    }
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            _model =  value != null ?  value : "Unkown";

        }
    }
    public ushort Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value <= DateTime.Now.Year && value >= 1886)
            {
                _year = value;
            }
        }
    }
    public uint Price { get; set; }
    public bool IsElectric { get; set; }


    public string showInfo()
    {
        if (IsElectric) {
            return    $"brand : {Brand}\n" +
                      $"model : {Model}\n" +
                      $"year  : {Year}\n" +
                      $"price : {Price}\n" +
                      $"electric motor\n";
        }
        else
        {
            return $"brand : {Brand}\n" +
                      $"model : {Model}\n" +
                      $"year  : {Year}\n" +
                      $"price : {Price}\n" +
                      $"thermal motor\n";
        }
        
    }

}