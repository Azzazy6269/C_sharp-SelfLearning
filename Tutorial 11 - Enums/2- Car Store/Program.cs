class Program
{
    static void Main(string[] args)
    {
        Car_sell c1 = new Car_sell("Essam Elshorbgy", "01067156264", "BMW_X5_2025");
        c1.ShowInfo();
        HowMuch("Jeep_Grand_Cherokee_2025");
        ShowAllExistCar();
    }
    public static void HowMuch(string carModel)
    {
       if( Enum.TryParse(carModel,out Model m))
        {
            Console.WriteLine($"{carModel} price is {((long)m)/1000000f} million\n" +
                $"-------------");
        }
        else
        {
            Console.WriteLine("Car isn't exist\n");
        }
    }
    public static void ShowAllExistCar()
    {
        foreach(var car in Enum.GetValues(typeof(Model)))
        {
            Console.WriteLine($"{car} = {(long)car}");
        }
    }
}
public enum Model : long
{
    Mercedes_GLC_300_Coupe_2022 = 2_467_500,
    Mercedes_E350_2022 = 2_700_150,
    Mercedes_C200_2025 = 2_750_000,
    Mercedes_E200_2025 = 3_350_000,
    Mercedes_AMG_C63_S_E_2023 = 3_760_000,
    Mercedes_S_Class_2024 = 4_500_000,
    Mercedes_G_Class_2024 = 6_000_000,

    BMW_Series_3_320i_2025 = 2_200_000,
    BMW_Series_5_530i_2025 = 2_950_000,
    BMW_X1_2025 = 2_300_000,
    BMW_X3_2025 = 2_850_000,
    BMW_X5_2025 = 3_700_000,
    BMW_iX1_Electric_2025 = 2_650_000,
    BMW_i7_Electric_2025 = 5_500_000,

    RangeRover_Evoque_2025 = 3_000_000,
    RangeRover_Velar_2025 = 3_750_000,
    RangeRover_Sport_2025 = 4_950_000,
    RangeRover_Vogue_2025 = 6_300_000,
    Defender_90_2025 = 3_600_000,
    Defender_110_2025 = 4_100_000,

    Toyota_Corolla_2025 = 1_500_000,
    Toyota_Camry_2025 = 2_200_000,
    Toyota_RAV4_2025 = 2_600_000,
    Toyota_LandCruiser_2025 = 4_300_000,
    Toyota_Hilux_2025 = 2_400_000,

    Jeep_Renegade_2025 = 2_100_000,
    Jeep_Compass_2025 = 2_400_000,
    Jeep_Grand_Cherokee_2025 = 3_600_000,
    Jeep_Wrangler_2025 = 4_200_000
}

class Car_sell
{
    private string _buyerName;
    private string _buyerPhone;
    private Model _model  ;
    private long _price;
    private DateTime _date;

    public Car_sell(string buyerName, string buyerPhone, string model )
    {
        if( Enum.TryParse(model,out Model m))
        {
            _model = m;
            _price = (long)m;
            _buyerName = buyerName;
            _buyerPhone = buyerPhone;
            _date = DateTime.Now;
        }
        else
        {
            throw new ArgumentException("Must be a valid enum value");
        }

    }
    public void ShowInfo()
    {
        Console.WriteLine($"buyer name : {_buyerName}\n" +
                          $"buyer phone : {_buyerPhone}\n" +
                          $"Car model : {_model}\n" +
                          $"Price : {_price}\n" +
                          $"Date {_date}\n" +
                          $"-----------------");
    }


}