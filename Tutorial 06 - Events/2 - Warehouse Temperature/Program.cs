class program
{
    public static void Main(string[] args)
    {
        TemperatureSensor t1 = new TemperatureSensor("warehouse1",25);
        t1.OnTemperatureChanged += Alert;
        t1.Temperature = 42;
        t1.Temperature = 14;
        t1.Temperature = -5;

    }

    public static void Alert(TemperatureSensor t )
    {
        Console.WriteLine($"Alert!! Temperature of {t.SensorName} is {t.Temperature}");
    }
}

public class TemperatureSensor
{
    private string _sensorName;
    private short _tepmerature;
    public short Temperature
    {
        get => _tepmerature;
        set 
        {
            this._tepmerature = value;
            if (OnTemperatureChanged != null && (this._tepmerature<0 || this._tepmerature>40))
            {
                OnTemperatureChanged(this);
            }
        }
    }
    public string SensorName { get => _sensorName; }

    public TemperatureSensor(string sensorName , short temperature)
    {
        this._sensorName = sensorName;
        this.Temperature = temperature;
    }

    public delegate void TemperatureChangedHandler(TemperatureSensor t );
    public event TemperatureChangedHandler OnTemperatureChanged;
    
    

}